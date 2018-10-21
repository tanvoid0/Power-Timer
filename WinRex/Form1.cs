using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WinRex
{
    
    public partial class Form1 : Form
    {
        int timeSec, timeMin, timeHr;
        bool isActive;
        bool warn;

        string action;
        public Form1()
        {
            InitializeComponent();
        }

        private void shut_Click(object sender, EventArgs e)
        {
            action = "poweroff";
            start();
            
        }

        private void restart_Click(object sender, EventArgs e)
        {
            action = "restart";
            start();
        }

        private void sleep_Click(object sender, EventArgs e)
        {
            action = "sleep";
            start();
        }

        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);

        private void hibernate_Click(object sender, EventArgs e)
        {
            action = "hibernate";
            start();
        }

        private void ResetTime()
        {
            timeSec = 0;
            timeMin = 0;
            timeHr = 0;
            isActive = false;
            warn = false;
            action = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeMin == 0 && timeHr == 0 && timeSec == 1)
            {
                ResetTime();
                
                if(action == "poweroff")
                {
                    Process.Start("shutdown", "/s /t 0");    // starts the shutdown application 
                                                             // the argument /s is to shut down the computer
                                                             // the argument /t 0 is to tell the process that 
                                                             // the specified operation needs to be completed 
                                                             // after 0 seconds

                }
                else if(action == "restart")
                {
                    Process.Start("shutdown", "/r /t 0"); // the argument /r is to restart the computer
                }
                else if(action == "sleep")
                {
                    SetSuspendState(false, true, true);

                }
                else if (action == "hibernate")
                {
                    SetSuspendState(true, true, true);
                }
                Console.WriteLine(action);

            }
            if (timeHr ==0 && timeMin ==0 && timeSec == 30 && !warn)
            {
                warn = true;
                DialogResult res = MessageBox.Show("Your Computer will "+action+" in 30 seconds!\nDo you want to Cancel", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    btnReset.PerformClick();
                    MessageBox.Show("Your Timer has been reset! Enjoy some more time!");

                }
                if (res == DialogResult.Cancel)
                {
                    MessageBox.Show("Your device will be "+action+" soon!");
                    //Some task…  
                }
            }
            if (isActive)
            {
                timeSec--;

                if(timeSec <= 00)
                {
                    timeMin--;
                    timeSec = 59;

                    if(timeMin <= 00 && timeHr != 00)
                    {
                        timeHr--;
                        timeMin = 59;
                    }
                }
            }
            
            DrawTime();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            start();
        }

        private void start()
        {
            if (Convert.ToInt32(hour.Text) == 0 && Convert.ToInt32(minute.Text) == 0)
            {
                MessageBox.Show("Please Set Time first!");
                return;
            }
            view();
            timeMin = Convert.ToInt32(minute.Text);
            timeHr = Convert.ToInt32(hour.Text);
            isActive = true;

            MessageBox.Show("Timer started for " + action);
            // notifyIcon.Visible = true;
            // notifyIcon.ShowBalloonTip(3000);
            // this.Hide();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTime();
            hide();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void hour_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void minute_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void DrawTime()
        {
            lblSec.Text = String.Format("{0:00}", timeSec);
            lblMin.Text = String.Format("{0:00}", timeMin);
            lblHr.Text = String.Format("{0:00}", timeHr);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            timeSec = 0;
            timeMin = 0;
            timeHr = 0;
            isActive = false;
            
            warn = false;
            hide();
        }

        private void view()
        {
            lblTimer.Show();
            lblHr.Show();
            lblMin.Show();
            lblSec.Show();
            lblCol.Show();
            lblCol2.Show();
            btnStart.Show();
            btnStop.Show();
            btnReset.Show();
        }


        private void hide()
        {
            lblTimer.Hide();
            lblHr.Hide();
            lblMin.Hide();
            lblSec.Hide();
            lblCol.Hide();
            lblCol2.Hide();
            btnStart.Hide();
            btnStop.Hide();
            btnReset.Hide();
        }
    }
}
