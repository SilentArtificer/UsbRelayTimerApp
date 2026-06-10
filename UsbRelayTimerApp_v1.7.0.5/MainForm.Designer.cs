/*
 * Created by SharpDevelop.
 * User: SilentArtificer
 * Date: 06/06/2026
 * Time: 13:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UsbRelayTimerApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.Label lblRelayStatus;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.NumericUpDown numHours;
        private System.Windows.Forms.NumericUpDown numMinutes;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlIndicator;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        	this.btnOn = new System.Windows.Forms.Button();
        	this.btnOff = new System.Windows.Forms.Button();
        	this.btnPause = new System.Windows.Forms.Button();
        	this.btnReset = new System.Windows.Forms.Button();
        	this.btnStartTimer = new System.Windows.Forms.Button();
        	this.lblRelayStatus = new System.Windows.Forms.Label();
        	this.lblCountdown = new System.Windows.Forms.Label();
        	this.numHours = new System.Windows.Forms.NumericUpDown();
        	this.numMinutes = new System.Windows.Forms.NumericUpDown();
        	this.progressBar1 = new System.Windows.Forms.ProgressBar();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.pnlIndicator = new System.Windows.Forms.Panel();
        	((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// btnOn
        	// 
        	this.btnOn.BackColor = System.Drawing.Color.PaleGreen;
        	this.btnOn.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.btnOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnOn.Location = new System.Drawing.Point(4, 10);
        	this.btnOn.Name = "btnOn";
        	this.btnOn.Size = new System.Drawing.Size(76, 22);
        	this.btnOn.TabIndex = 0;
        	this.btnOn.Text = "Relay ON";
        	this.btnOn.UseVisualStyleBackColor = false;
        	this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
        	// 
        	// btnOff
        	// 
        	this.btnOff.BackColor = System.Drawing.Color.MistyRose;
        	this.btnOff.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.btnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnOff.Location = new System.Drawing.Point(110, 10);
        	this.btnOff.Name = "btnOff";
        	this.btnOff.Size = new System.Drawing.Size(76, 22);
        	this.btnOff.TabIndex = 1;
        	this.btnOff.Text = "Relay OFF";
        	this.btnOff.UseVisualStyleBackColor = false;
        	this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
        	// 
        	// btnPause
        	// 
        	this.btnPause.BackColor = System.Drawing.Color.Khaki;
        	this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnPause.Location = new System.Drawing.Point(126, 129);
        	this.btnPause.Name = "btnPause";
        	this.btnPause.Size = new System.Drawing.Size(60, 21);
        	this.btnPause.TabIndex = 2;
        	this.btnPause.Text = "║ Pause";
        	this.btnPause.UseVisualStyleBackColor = false;
        	this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
        	// 
        	// btnReset
        	// 
        	this.btnReset.BackColor = System.Drawing.Color.LightSkyBlue;
        	this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnReset.Location = new System.Drawing.Point(126, 102);
        	this.btnReset.Name = "btnReset";
        	this.btnReset.Size = new System.Drawing.Size(60, 21);
        	this.btnReset.TabIndex = 3;
        	this.btnReset.Text = "↺ Reset";
        	this.btnReset.UseVisualStyleBackColor = false;
        	this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
        	// 
        	// btnStartTimer
        	// 
        	this.btnStartTimer.BackColor = System.Drawing.Color.PaleGreen;
        	this.btnStartTimer.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.btnStartTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnStartTimer.Location = new System.Drawing.Point(126, 158);
        	this.btnStartTimer.Name = "btnStartTimer";
        	this.btnStartTimer.Size = new System.Drawing.Size(60, 21);
        	this.btnStartTimer.TabIndex = 4;
        	this.btnStartTimer.Text = "► Run";
        	this.btnStartTimer.UseVisualStyleBackColor = false;
        	this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
        	// 
        	// lblRelayStatus
        	// 
        	this.lblRelayStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        	this.lblRelayStatus.Location = new System.Drawing.Point(4, 35);
        	this.lblRelayStatus.Name = "lblRelayStatus";
        	this.lblRelayStatus.Size = new System.Drawing.Size(182, 20);
        	this.lblRelayStatus.TabIndex = 5;
        	this.lblRelayStatus.Text = "Status: Off";
        	// 
        	// lblCountdown
        	// 
        	this.lblCountdown.Location = new System.Drawing.Point(4, 55);
        	this.lblCountdown.Name = "lblCountdown";
        	this.lblCountdown.Size = new System.Drawing.Size(182, 20);
        	this.lblCountdown.TabIndex = 6;
        	this.lblCountdown.Text = "Standby.";
        	// 
        	// numHours
        	// 
        	this.numHours.Location = new System.Drawing.Point(60, 129);
        	this.numHours.Name = "numHours";
        	this.numHours.Size = new System.Drawing.Size(52, 20);
        	this.numHours.TabIndex = 7;
        	// 
        	// numMinutes
        	// 
        	this.numMinutes.Location = new System.Drawing.Point(60, 158);
        	this.numMinutes.Name = "numMinutes";
        	this.numMinutes.Size = new System.Drawing.Size(52, 20);
        	this.numMinutes.TabIndex = 8;
        	// 
        	// progressBar1
        	// 
        	this.progressBar1.BackColor = System.Drawing.SystemColors.Info;
        	this.progressBar1.Location = new System.Drawing.Point(4, 78);
        	this.progressBar1.Name = "progressBar1";
        	this.progressBar1.Size = new System.Drawing.Size(182, 10);
        	this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
        	this.progressBar1.TabIndex = 9;
        	// 
        	// label1
        	// 
        	this.label1.Location = new System.Drawing.Point(5, 131);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(42, 23);
        	this.label1.TabIndex = 10;
        	this.label1.Text = "Hours:";
        	// 
        	// label2
        	// 
        	this.label2.Location = new System.Drawing.Point(4, 160);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(50, 23);
        	this.label2.TabIndex = 11;
        	this.label2.Text = "Minutes:";
        	// 
        	// pnlIndicator
        	// 
        	this.pnlIndicator.BackColor = System.Drawing.Color.DarkSlateGray;
        	this.pnlIndicator.Location = new System.Drawing.Point(4, 102);
        	this.pnlIndicator.Name = "pnlIndicator";
        	this.pnlIndicator.Size = new System.Drawing.Size(108, 10);
        	this.pnlIndicator.TabIndex = 12;
        	// 
        	// MainForm
        	// 
        	this.BackColor = System.Drawing.Color.AliceBlue;
        	this.ClientSize = new System.Drawing.Size(191, 185);
        	this.Controls.Add(this.pnlIndicator);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.btnOn);
        	this.Controls.Add(this.btnOff);
        	this.Controls.Add(this.btnPause);
        	this.Controls.Add(this.btnReset);
        	this.Controls.Add(this.btnStartTimer);
        	this.Controls.Add(this.lblRelayStatus);
        	this.Controls.Add(this.lblCountdown);
        	this.Controls.Add(this.numHours);
        	this.Controls.Add(this.numMinutes);
        	this.Controls.Add(this.progressBar1);
        	this.ForeColor = System.Drawing.SystemColors.Highlight;
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	this.HelpButton = true;
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.MaximizeBox = false;
        	this.Name = "MainForm";
        	this.Text = "USB Relay Timer";
        	((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
        	this.ResumeLayout(false);

        }
    }
}