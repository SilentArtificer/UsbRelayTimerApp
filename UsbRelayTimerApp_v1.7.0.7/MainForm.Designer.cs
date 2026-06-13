/*
 * Created by SharpDevelop.
 * User: SilentArtificer
 * Date: 06/06/2026
 * Time: 13:58
 * USB Relay Timer App
 * v1.7.0.7
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblElapsed;

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
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.lblElapsed = new System.Windows.Forms.Label();
        	this.groupBox2 = new System.Windows.Forms.GroupBox();
        	this.groupBox3 = new System.Windows.Forms.GroupBox();
        	((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
        	this.groupBox1.SuspendLayout();
        	this.groupBox2.SuspendLayout();
        	this.groupBox3.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// btnOn
        	// 
        	this.btnOn.BackColor = System.Drawing.SystemColors.Info;
        	this.btnOn.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.btnOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnOn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnOn.Location = new System.Drawing.Point(59, 19);
        	this.btnOn.Name = "btnOn";
        	this.btnOn.Size = new System.Drawing.Size(70, 22);
        	this.btnOn.TabIndex = 0;
        	this.btnOn.Text = "ON";
        	this.btnOn.UseVisualStyleBackColor = false;
        	this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
        	// 
        	// btnOff
        	// 
        	this.btnOff.BackColor = System.Drawing.SystemColors.Info;
        	this.btnOff.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.btnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnOff.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnOff.Location = new System.Drawing.Point(135, 19);
        	this.btnOff.Name = "btnOff";
        	this.btnOff.Size = new System.Drawing.Size(70, 22);
        	this.btnOff.TabIndex = 1;
        	this.btnOff.Text = "OFF";
        	this.btnOff.UseVisualStyleBackColor = false;
        	this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
        	// 
        	// btnPause
        	// 
        	this.btnPause.BackColor = System.Drawing.SystemColors.Info;
        	this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnPause.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnPause.Location = new System.Drawing.Point(135, 64);
        	this.btnPause.Name = "btnPause";
        	this.btnPause.Size = new System.Drawing.Size(70, 22);
        	this.btnPause.TabIndex = 3;
        	this.btnPause.Text = "║ Pause";
        	this.btnPause.UseVisualStyleBackColor = false;
        	this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
        	// 
        	// btnReset
        	// 
        	this.btnReset.BackColor = System.Drawing.SystemColors.Info;
        	this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnReset.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnReset.Location = new System.Drawing.Point(135, 36);
        	this.btnReset.Name = "btnReset";
        	this.btnReset.Size = new System.Drawing.Size(70, 22);
        	this.btnReset.TabIndex = 2;
        	this.btnReset.Text = "↺ Reset";
        	this.btnReset.UseVisualStyleBackColor = false;
        	this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
        	// 
        	// btnStartTimer
        	// 
        	this.btnStartTimer.BackColor = System.Drawing.Color.PaleGreen;
        	this.btnStartTimer.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.btnStartTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnStartTimer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnStartTimer.Location = new System.Drawing.Point(135, 92);
        	this.btnStartTimer.Name = "btnStartTimer";
        	this.btnStartTimer.Size = new System.Drawing.Size(70, 22);
        	this.btnStartTimer.TabIndex = 4;
        	this.btnStartTimer.Text = "► Run";
        	this.btnStartTimer.UseVisualStyleBackColor = false;
        	this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
        	// 
        	// lblRelayStatus
        	// 
        	this.lblRelayStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblRelayStatus.Location = new System.Drawing.Point(3, 16);
        	this.lblRelayStatus.Name = "lblRelayStatus";
        	this.lblRelayStatus.Size = new System.Drawing.Size(201, 20);
        	this.lblRelayStatus.TabIndex = 0;
        	this.lblRelayStatus.Text = "Status: Off";
        	// 
        	// lblCountdown
        	// 
        	this.lblCountdown.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblCountdown.Location = new System.Drawing.Point(6, 39);
        	this.lblCountdown.Name = "lblCountdown";
        	this.lblCountdown.Size = new System.Drawing.Size(198, 20);
        	this.lblCountdown.TabIndex = 0;
        	this.lblCountdown.Text = "Standby.";
        	// 
        	// numHours
        	// 
        	this.numHours.Location = new System.Drawing.Point(7, 94);
        	this.numHours.Name = "numHours";
        	this.numHours.Size = new System.Drawing.Size(52, 20);
        	this.numHours.TabIndex = 5;
        	// 
        	// numMinutes
        	// 
        	this.numMinutes.Location = new System.Drawing.Point(70, 94);
        	this.numMinutes.Name = "numMinutes";
        	this.numMinutes.Size = new System.Drawing.Size(52, 20);
        	this.numMinutes.TabIndex = 6;
        	// 
        	// progressBar1
        	// 
        	this.progressBar1.BackColor = System.Drawing.SystemColors.Info;
        	this.progressBar1.Location = new System.Drawing.Point(7, 19);
        	this.progressBar1.Name = "progressBar1";
        	this.progressBar1.Size = new System.Drawing.Size(199, 10);
        	this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
        	this.progressBar1.TabIndex = 0;
        	// 
        	// label1
        	// 
        	this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(7, 68);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(52, 23);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "Hours";
        	// 
        	// label2
        	// 
        	this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.Location = new System.Drawing.Point(70, 68);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(57, 23);
        	this.label2.TabIndex = 0;
        	this.label2.Text = "Minutes";
        	// 
        	// pnlIndicator
        	// 
        	this.pnlIndicator.BackColor = System.Drawing.Color.DarkSlateGray;
        	this.pnlIndicator.Location = new System.Drawing.Point(12, 19);
        	this.pnlIndicator.Name = "pnlIndicator";
        	this.pnlIndicator.Size = new System.Drawing.Size(30, 22);
        	this.pnlIndicator.TabIndex = 0;
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.Controls.Add(this.lblElapsed);
        	this.groupBox1.Controls.Add(this.label1);
        	this.groupBox1.Controls.Add(this.label2);
        	this.groupBox1.Controls.Add(this.progressBar1);
        	this.groupBox1.Controls.Add(this.numHours);
        	this.groupBox1.Controls.Add(this.btnReset);
        	this.groupBox1.Controls.Add(this.btnPause);
        	this.groupBox1.Controls.Add(this.btnStartTimer);
        	this.groupBox1.Controls.Add(this.numMinutes);
        	this.groupBox1.Location = new System.Drawing.Point(5, 129);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Size = new System.Drawing.Size(215, 122);
        	this.groupBox1.TabIndex = 0;
        	this.groupBox1.TabStop = false;
        	this.groupBox1.Text = "Timer";
        	// 
        	// lblElapsed
        	// 
        	this.lblElapsed.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblElapsed.Location = new System.Drawing.Point(4, 35);
        	this.lblElapsed.Name = "lblElapsed";
        	this.lblElapsed.Size = new System.Drawing.Size(118, 23);
        	this.lblElapsed.TabIndex = 0;
        	this.lblElapsed.Text = "00:00:00";
        	// 
        	// groupBox2
        	// 
        	this.groupBox2.Controls.Add(this.pnlIndicator);
        	this.groupBox2.Controls.Add(this.btnOn);
        	this.groupBox2.Controls.Add(this.btnOff);
        	this.groupBox2.Location = new System.Drawing.Point(6, 5);
        	this.groupBox2.Name = "groupBox2";
        	this.groupBox2.Size = new System.Drawing.Size(214, 50);
        	this.groupBox2.TabIndex = 0;
        	this.groupBox2.TabStop = false;
        	this.groupBox2.Text = "Power";
        	// 
        	// groupBox3
        	// 
        	this.groupBox3.BackColor = System.Drawing.Color.AliceBlue;
        	this.groupBox3.Controls.Add(this.lblRelayStatus);
        	this.groupBox3.Controls.Add(this.lblCountdown);
        	this.groupBox3.Location = new System.Drawing.Point(6, 61);
        	this.groupBox3.Name = "groupBox3";
        	this.groupBox3.Size = new System.Drawing.Size(214, 62);
        	this.groupBox3.TabIndex = 0;
        	this.groupBox3.TabStop = false;
        	this.groupBox3.Text = "Main";
        	// 
        	// MainForm
        	// 
        	this.BackColor = System.Drawing.Color.AliceBlue;
        	this.ClientSize = new System.Drawing.Size(224, 255);
        	this.Controls.Add(this.groupBox1);
        	this.Controls.Add(this.groupBox2);
        	this.Controls.Add(this.groupBox3);
        	this.ForeColor = System.Drawing.SystemColors.Highlight;
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	this.HelpButton = true;
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.MaximizeBox = false;
        	this.Name = "MainForm";
        	this.Text = "USB Relay Timer";
        	((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
        	this.groupBox1.ResumeLayout(false);
        	this.groupBox2.ResumeLayout(false);
        	this.groupBox3.ResumeLayout(false);
        	this.ResumeLayout(false);

        }
        }
    }