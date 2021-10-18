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
    public partial class frmCountDown : Form
    {
        public frmCountDown()
        {
            InitializeComponent();
           
        }

       
        DateTime NewYear;
        
        private void btnStart_Click(object sender, EventArgs e)
        {
           

            timer1.Start();
            btnStart.Visible = false;

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year + 1;
            NewYear = new DateTime(year, 01, 01, 00, 00, 00);

            TimeSpan ts = NewYear.Subtract(DateTime.Now);
            int days = ts.Days;
            int hours = ts.Hours;
            int minutes = ts.Minutes;   
            int seconds = ts.Seconds;
            int result = days - hours - minutes;
            
            if (seconds == 10 && ( result == 0))
            {
                

                lbldays.Visible = false;
                lblhours.Visible = false;
                lblminutes.Visible = false;
                lblseconds.Visible = false;
                lblTitle.Visible = false;
                lbldesc.Visible = false;

                btnStart.Visible = false; 

                player.Visible = true;
                player.Ctlcontrols.play();
            } 
            else if(player.Ctlcontrols.currentPosition > 49)
            {
                
                    player.Visible = false;

                    lbldays.Visible = true;
                    lblhours.Visible = true;
                    lblminutes.Visible = true;
                    lblseconds.Visible = true;
                    lblTitle.Visible = true;
                
            }

            else
            {
                lbldays.Text = $"{days:0#}";
                lblhours.Text = $"{hours:0#}";
                lblminutes.Text = $"{minutes:0#}";
                lblseconds.Text = $"{seconds:0#}";
            }

        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCountDown_Load(object sender, EventArgs e)
        {
            this.player.Ctlcontrols.stop();
           
        }

        private void hours_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void player_Enter(object sender, EventArgs e)
        {

        }
    }
}
