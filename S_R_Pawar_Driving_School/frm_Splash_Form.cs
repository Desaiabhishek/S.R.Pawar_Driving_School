using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace S_R_Pawar_Driving_School
{
    public partial class frm_Splash_Form : Form
    {
        public frm_Splash_Form()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pb_Loading.PerformStep();

            if (pb_Loading.Value <= 10)
            {
                lbl_Note.Text = "Loading Application Please Wait ....";
            }
            if (pb_Loading.Value >= 10 && pb_Loading.Value <= 20)
            {
                lbl_Note.Text = "Loading Forms Please Wait ....";
            }
            if (pb_Loading.Value >= 20 && pb_Loading.Value <= 50)
            {
                lbl_Note.Text = "Starting Application Please Wait ....";
            }
            if (pb_Loading.Value >= 50 && pb_Loading.Value <= 75)
            {
                lbl_Note.Text = "Loading Database Please Wait ....";
            }
            if (pb_Loading.Value >= 75 && pb_Loading.Value <= 85)
            {
                lbl_Note.Text = "Loading And Connection To Database Please Wait ....";
            }
            if (pb_Loading.Value >= 85 && pb_Loading.Value <= 100)
            {
                lbl_Note.Text = "Loading Forms Is Opening Please Wait ....";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            System.Threading.Thread.Sleep(200);
            timer3.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Enabled = false;

            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }

        private void frm_Splash_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
