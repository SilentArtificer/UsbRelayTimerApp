/*
 * Created by SharpDevelop.
 * User: SilentArtificer
 * Date: 06/06/2026
 * Time: 13:58
 * USB Relay Timer App
 * v1.7.0.7
 */
using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Configuration;

namespace UsbRelayTimerApp
{
    public partial class MainForm : Form
    {
        private int remainingSeconds;
        private Timer countdownTimer;
        private bool relayError = false;
        private bool relayIsOn = false;
        private DateTime startTime;
        private TimeSpan pausedElapsed = TimeSpan.Zero;

        public MainForm()
        {
            InitializeComponent();

            countdownTimer = new Timer();
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += CountdownTimer_Tick;

            RunRelayCommand(relayCloseCmd);
            relayIsOn = false;

            lblRelayStatus.Text = "Status: Off (Init)";
            pnlIndicator.BackColor = System.Drawing.Color.DarkSlateGray;
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            if (relayError) return;

            if (!relayIsOn)
            {
                RunRelayCommand(relayOpenCmd);
                relayIsOn = true;
                startTime = DateTime.Now;
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
                pausedElapsed += DateTime.Now - startTime; // hold elapsed
                RunRelayCommand(relayCloseCmd);
                relayIsOn = false;
            }

            countdownTimer.Stop();
            lblRelayStatus.Text = "Status: Off";
            lblCountdown.Text = "Standby.";
            pnlIndicator.BackColor = System.Drawing.Color.DarkSlateGray;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (relayError) return;

            if (countdownTimer.Enabled)
            {
                countdownTimer.Stop();
                pausedElapsed += DateTime.Now - startTime; // hold pause
                lblRelayStatus.Text = "Status: Timer (Pause)";
                lblCountdown.Text = "Paused: " + FormatTime(remainingSeconds);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (relayError) return;

            countdownTimer.Stop();
            remainingSeconds = 0;
            progressBar1.Value = 0;

            pausedElapsed = TimeSpan.Zero;
            lblElapsed.Text = "00:00:00";

            lblRelayStatus.Text = "Status: Timer (Reset)";
            lblCountdown.Text = "Timer " + FormatTime(remainingSeconds);
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            if (relayError) return;

            if (remainingSeconds > 0 && !countdownTimer.Enabled)
            {
                if (!relayIsOn)
                {
                    RunRelayCommand(relayOpenCmd);
                    relayIsOn = true;
                }
                startTime = DateTime.Now;
                lblRelayStatus.Text = "Status: On (Resume)";
                countdownTimer.Start();
                pnlIndicator.BackColor = System.Drawing.Color.LimeGreen;
                return;
            }

            int hours = (int)numHours.Value;
            int minutes = (int)numMinutes.Value;
            if (hours == 0 && minutes == 0)
            {
                lblRelayStatus.Text = "Status: Error";
                lblCountdown.Text = "No valid time input.";
                return;
            }

            remainingSeconds = (hours * 3600) + (minutes * 60);
            startTime = DateTime.Now;
            pausedElapsed = TimeSpan.Zero;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = remainingSeconds;
            progressBar1.Value = 0;

            countdownTimer.Start();

            if (!relayIsOn)
            {
                RunRelayCommand(relayOpenCmd);
                relayIsOn = true;
            }

            lblRelayStatus.Text = "Status: On (Timer)";
            pnlIndicator.BackColor = System.Drawing.Color.LimeGreen;
            lblCountdown.Text = "Remaining: " + FormatTime(remainingSeconds);
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (relayError)
            {
                countdownTimer.Stop();
                return;
            }

            remainingSeconds--;

            if (remainingSeconds >= 0 && progressBar1.Value < progressBar1.Maximum)
                progressBar1.Value = progressBar1.Maximum - remainingSeconds;

            lblCountdown.Text = "Remaining: " + FormatTime(remainingSeconds);

            // elapsed offset
            TimeSpan elapsed = (DateTime.Now - startTime) + pausedElapsed;
            lblElapsed.Text = FormatTime((int)elapsed.TotalSeconds);

            if (remainingSeconds <= 0)
            {
                btnOff_Click(null, null); // relay off
                lblCountdown.Text = "Timer Done.";
                pnlIndicator.BackColor = System.Drawing.Color.DarkSlateGray;
            }
        }

        private string FormatTime(int seconds)
        {
            TimeSpan ts = TimeSpan.FromSeconds(seconds);
            return string.Format("{0:D2}:{1:D2}:{2:D2}",
                                 (int)ts.TotalHours, ts.Minutes, ts.Seconds);
        }

        string relayOpenCmd = ConfigurationManager.AppSettings["RelayOpenCommand"];
        string relayCloseCmd = ConfigurationManager.AppSettings["RelayCloseCommand"];
        string relayExe = ConfigurationManager.AppSettings["RelayExe"];

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