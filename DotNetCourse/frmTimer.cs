using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetCourse
{
    public partial class frmTimer : Form
    {
        public frmTimer()
        {
            InitializeComponent();
        }

        private string formatTime(int second)
        {
            TimeSpan t = TimeSpan.FromSeconds(second);
            string answer = string.Format("{0:D2}h:{1:D2}m:{2:D2}s",
                t.Hours,
                t.Minutes,
                t.Seconds);

            return answer;
        }
        int TotalSecond = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TotalSecond == 0) timer1.Stop();
            else
            {
                TotalSecond--;
                // string time = formatTime(second);
                lblTimer.Text = $"{player.Ctlcontrols.currentPosition:0#}";
            }

        }

       
       
        private void btnStart_Click(object sender, EventArgs e)
        {
            var minute = (int)numTimer.Value;
            TotalSecond = minute * 60;
            timer1.Start();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmTimer_Load(object sender, EventArgs e)
        {

        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
