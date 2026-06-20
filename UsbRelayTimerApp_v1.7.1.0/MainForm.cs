/*
 * Created by SharpDevelop.
 * User: SilentArtificer
 * Date: 06/06/2026
 * Time: 13:58
 * USB Relay Timer App
 * v1.7.1.0
 */
using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Configuration;

namespace UsbRelayTimerApp
{
    public partial class MainForm : Form
    {
        private int totalSeconds;
        private int delaySeconds;
        private int pausedDelaySeconds = 0;
        private int pausedRemainingSeconds = 0;

        private bool relayError = false;
        private bool relayIsOn = false;
        private bool delayActive = false;

        private Timer countdownTimer;
        private Timer delayTimer;

        private Stopwatch stopwatch;
        private DateTime endTime;

        string relayOpenCmd = ConfigurationManager.AppSettings["RelayOpenCommand"];
        string relayCloseCmd = ConfigurationManager.AppSettings["RelayCloseCommand"];
        string relayExe = ConfigurationManager.AppSettings["RelayExe"];

        public MainForm()
        {
            InitializeComponent();

            countdownTimer = new Timer();
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += CountdownTimer_Tick;

            delayTimer = new Timer();
            delayTimer.Interval = 1000;
            delayTimer.Tick += DelayTimer_Tick;

            stopwatch = new Stopwatch();

            RunRelayCommand(relayCloseCmd);
            relayIsOn = false;

            if (!relayError)
            {
                lblRelayStatus.Text = "Status: Off (Init)";
                pnlIndicator.BackColor = System.Drawing.Color.DarkSlateGray;
            }
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            if (relayError) return;

            if (delayActive)
            {
                lblRelayStatus.Text = "Status: Delay Active (Manual ON ignored)";
                lblCountdown.Text = "Delay Remaining: " + FormatTime(delaySeconds);
                return;
            }

            if (countdownTimer.Enabled)
            {
                lblRelayStatus.Text = "Status: Timer Active (Manual ON ignored)";
                lblCountdown.Text = "Remaining: " + FormatTime(GetRemainingSeconds());
                return;
            }

            if (!relayIsOn)
            {
                RunRelayCommand(relayOpenCmd);
                relayIsOn = true;
                stopwatch.Reset();
                stopwatch.Start();
            }

            lblRelayStatus.Text = "Status: On";
            lblCountdown.Text = "Manual mode";
            pnlIndicator.BackColor = System.Drawing.Color.LimeGreen;
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            if (relayError) return;

            if (relayIsOn)
            {
                RunRelayCommand(relayCloseCmd);
                relayIsOn = false;
            }

            countdownTimer.Stop();
            delayTimer.Stop();
            delayActive = false;
            pausedDelaySeconds = 0;
            pausedRemainingSeconds = 0;

            stopwatch.Stop();

            lblRelayStatus.Text = "Status: Off";
            lblCountdown.Text = "Standby.";
            pnlIndicator.BackColor = System.Drawing.Color.DarkSlateGray;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (relayError) return;

            if (delayActive && delayTimer.Enabled)
            {
                delayTimer.Stop();
                pausedDelaySeconds = delaySeconds;
                lblRelayStatus.Text = "Status: Delay (Pause)";
                lblCountdown.Text = "Paused Delay: " + FormatTime(delaySeconds);
            }
            else if (countdownTimer.Enabled)
            {
                countdownTimer.Stop();
                stopwatch.Stop();

                pausedRemainingSeconds = GetRemainingSeconds();

                lblRelayStatus.Text = "Status: Timer (Pause)";
                lblCountdown.Text = "Paused: " + FormatTime(pausedRemainingSeconds);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (relayError) return;

            countdownTimer.Stop();
            delayTimer.Stop();
            delayActive = false;
            totalSeconds = 0;
            delaySeconds = 0;
            pausedDelaySeconds = 0;
            pausedRemainingSeconds = 0;

            progressBar1.Value = 0;
            stopwatch.Reset();
            lblElapsed.Text = "00:00:00";

            lblRelayStatus.Text = "Status: Timer (Reset)";
            lblCountdown.Text = "Timer " + FormatTime(totalSeconds);
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            if (relayError) return;

            if (pausedDelaySeconds > 0)
            {
                delaySeconds = pausedDelaySeconds;
                pausedDelaySeconds = 0;
                delayActive = true;
                delayTimer.Start();
                lblRelayStatus.Text = "Status: Delay (Resume)";
                pnlIndicator.BackColor = System.Drawing.Color.Orange;
                return;
            }

            if (pausedRemainingSeconds > 0)
            {
                endTime = DateTime.Now.AddSeconds(pausedRemainingSeconds);
                pausedRemainingSeconds = 0;

                stopwatch.Start();
                countdownTimer.Start();

                lblRelayStatus.Text = "Status: On (Resume)";
                lblCountdown.Text = "Remaining: " + FormatTime(GetRemainingSeconds());
                pnlIndicator.BackColor = System.Drawing.Color.LimeGreen;
                return;
            }

            int hours = (int)numHours.Value;
            int minutes = (int)numMinutes.Value;
            int delayHours = (int)numDelayHours.Value;
            int delayMinutes = (int)numDelayMinutes.Value;

            if (hours == 0 && minutes == 0)
            {
                lblRelayStatus.Text = "Status: Error";
                lblCountdown.Text = "No valid time input.";
                return;
            }

            totalSeconds = (hours * 3600) + (minutes * 60);
            delaySeconds = (delayHours * 3600) + (delayMinutes * 60);

            if (delaySeconds > 0)
            {
                if (relayIsOn)
                {
                    RunRelayCommand(relayCloseCmd);
                    relayIsOn = false;
                }

                delayActive = true;
                delayTimer.Start();

                lblRelayStatus.Text = "Status: Waiting (Delay)";
                lblCountdown.Text = "Delay Remaining: " + FormatTime(delaySeconds);
                pnlIndicator.BackColor = System.Drawing.Color.Orange;
                return;
            }

            StartCountdown();
        }

        private void DelayTimer_Tick(object sender, EventArgs e)
        {
            if (!delayActive) return;

            delaySeconds--;
            lblCountdown.Text = "Delay Remaining: " + FormatTime(delaySeconds);

            if (delaySeconds <= 0)
            {
                delayTimer.Stop();
                delayActive = false;
                StartCountdown();
            }
        }

        private void StartCountdown()
        {
            stopwatch.Reset();
            stopwatch.Start();

            endTime = DateTime.Now.AddSeconds(totalSeconds);

            progressBar1.Minimum = 0;
            progressBar1.Maximum = totalSeconds;
            progressBar1.Value = 0;

            countdownTimer.Start();

            if (!relayIsOn)
            {
                RunRelayCommand(relayOpenCmd);
                relayIsOn = true;
            }

            lblRelayStatus.Text = "Status: On (Timer)";
            pnlIndicator.BackColor = System.Drawing.Color.LimeGreen;
            lblCountdown.Text = "Remaining: " + FormatTime(totalSeconds);
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (relayError)
            {
                countdownTimer.Stop();
                return;
            }

            int remaining = GetRemainingSeconds();

            if (remaining >= 0 && progressBar1.Value < progressBar1.Maximum)
                progressBar1.Value = progressBar1.Maximum - remaining;

            lblCountdown.Text = "Remaining: " + FormatTime(remaining);
            lblElapsed.Text = FormatTime((int)stopwatch.Elapsed.TotalSeconds);

            if (remaining <= 0)
            {
                btnOff_Click(null, null);
                lblCountdown.Text = "Timer Done.";
                pnlIndicator.BackColor = System.Drawing.Color.DarkSlateGray;
            }
        }

        private int GetRemainingSeconds()
        {
            return (int)(endTime - DateTime.Now).TotalSeconds;
        }

        private string FormatTime(int seconds)
        {
            if (seconds < 0) seconds = 0;
            TimeSpan ts = TimeSpan.FromSeconds(seconds);
            return string.Format("{0:D2}:{1:D2}:{2:D2}", (int)ts.TotalHours, ts.Minutes, ts.Seconds);
        }

        private void RunRelayCommand(string args)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = relayExe;
                psi.Arguments = args;
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                Process.Start(psi);
            }
            catch (Exception)
            {
                countdownTimer.Stop();
                delayTimer.Stop();
                relayError = true;
                lblRelayStatus.Text = "Status: Error";
                lblCountdown.Text = "Command program not found.";
                pnlIndicator.BackColor = System.Drawing.Color.Gray;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (relayIsOn)
            {
                RunRelayCommand(relayCloseCmd);
                relayIsOn = false;
            }
        }
    }
}