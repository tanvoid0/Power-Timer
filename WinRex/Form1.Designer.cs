namespace WinRex
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.shut = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.sleep = new System.Windows.Forms.Button();
            this.hibernate = new System.Windows.Forms.Button();
            this.hour = new System.Windows.Forms.TextBox();
            this.minute = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblHr = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblCol = new System.Windows.Forms.Label();
            this.lblCol2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shut
            // 
            this.shut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shut.Location = new System.Drawing.Point(469, 53);
            this.shut.Name = "shut";
            this.shut.Size = new System.Drawing.Size(153, 31);
            this.shut.TabIndex = 0;
            this.shut.Text = "Shut Down";
            this.shut.UseVisualStyleBackColor = true;
            this.shut.Click += new System.EventHandler(this.shut_Click);
            // 
            // restart
            // 
            this.restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart.Location = new System.Drawing.Point(469, 110);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(153, 31);
            this.restart.TabIndex = 1;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // sleep
            // 
            this.sleep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sleep.Location = new System.Drawing.Point(469, 167);
            this.sleep.Name = "sleep";
            this.sleep.Size = new System.Drawing.Size(153, 31);
            this.sleep.TabIndex = 2;
            this.sleep.Text = "Sleep";
            this.sleep.UseVisualStyleBackColor = true;
            this.sleep.Click += new System.EventHandler(this.sleep_Click);
            // 
            // hibernate
            // 
            this.hibernate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hibernate.Location = new System.Drawing.Point(469, 224);
            this.hibernate.Name = "hibernate";
            this.hibernate.Size = new System.Drawing.Size(153, 31);
            this.hibernate.TabIndex = 3;
            this.hibernate.Text = "Hibernate";
            this.hibernate.UseVisualStyleBackColor = true;
            this.hibernate.Click += new System.EventHandler(this.hibernate_Click);
            // 
            // hour
            // 
            this.hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour.Location = new System.Drawing.Point(190, 65);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(42, 31);
            this.hour.TabIndex = 8;
            this.hour.Text = "0";
            this.hour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hour_KeyPress);
            // 
            // minute
            // 
            this.minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minute.Location = new System.Drawing.Point(312, 65);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(42, 31);
            this.minute.TabIndex = 9;
            this.minute.Text = "0";
            this.minute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minute_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Minute";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hour";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(68, 170);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(46, 20);
            this.lblTimer.TabIndex = 12;
            this.lblTimer.Text = "Timer";
            // 
            // lblHr
            // 
            this.lblHr.AutoSize = true;
            this.lblHr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr.ForeColor = System.Drawing.Color.Red;
            this.lblHr.Location = new System.Drawing.Point(151, 166);
            this.lblHr.Name = "lblHr";
            this.lblHr.Size = new System.Drawing.Size(41, 29);
            this.lblHr.TabIndex = 13;
            this.lblHr.Text = "00";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.Red;
            this.lblMin.Location = new System.Drawing.Point(227, 166);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(41, 29);
            this.lblMin.TabIndex = 14;
            this.lblMin.Text = "00";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.ForeColor = System.Drawing.Color.Red;
            this.lblSec.Location = new System.Drawing.Point(300, 171);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(32, 24);
            this.lblSec.TabIndex = 15;
            this.lblSec.Text = "00";
            // 
            // lblCol
            // 
            this.lblCol.AutoSize = true;
            this.lblCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCol.Location = new System.Drawing.Point(198, 164);
            this.lblCol.Name = "lblCol";
            this.lblCol.Size = new System.Drawing.Size(20, 29);
            this.lblCol.TabIndex = 16;
            this.lblCol.Text = ":";
            // 
            // lblCol2
            // 
            this.lblCol2.AutoSize = true;
            this.lblCol2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCol2.Location = new System.Drawing.Point(274, 166);
            this.lblCol2.Name = "lblCol2";
            this.lblCol2.Size = new System.Drawing.Size(20, 29);
            this.lblCol2.TabIndex = 17;
            this.lblCol2.Text = ":";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(64, 232);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(168, 232);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 19;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(279, 232);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "Open winrex from here!";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "From Now :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(671, 389);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblCol2);
            this.Controls.Add(this.lblCol);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblHr);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minute);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.hibernate);
            this.Controls.Add(this.sleep);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.shut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Power Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button shut;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Button sleep;
        private System.Windows.Forms.Button hibernate;
        private System.Windows.Forms.TextBox hour;
        private System.Windows.Forms.TextBox minute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblHr;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblCol;
        private System.Windows.Forms.Label lblCol2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label label3;
    }
}

