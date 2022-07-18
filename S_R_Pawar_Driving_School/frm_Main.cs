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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        #region CoustamiseDesign

        private void CoustamiseDesign()
        {
            pnl_Student.Visible = false;
            pnl_Trainer.Visible = false;
            pnl_Vehical_Details.Visible = false;
            pnl_Licence.Visible = false;
            pnl_Maintannce.Visible = false;
        }
        #endregion

        #region hidesubmenu

        private void hidesubmenu()
        {
            if(pnl_Student.Visible == true)
            {
                pnl_Student.Visible = false;
            }
            if (pnl_Trainer.Visible == true)
            {
                pnl_Trainer.Visible = false;
            }
            if (pnl_Vehical_Details.Visible == true)
            {
                pnl_Vehical_Details.Visible = false;
            }
            if (pnl_Course.Visible == true)
            {
                pnl_Course.Visible = false;
            }
            if (pnl_Licence.Visible == true)
            {
                pnl_Licence.Visible = false;
            }
            if (pnl_Maintannce.Visible == true)
            {
                pnl_Maintannce.Visible = false;
            }
            if (pnl_fee_details.Visible == true)
            {
                pnl_fee_details.Visible = false;
            }
            if (pnl_report.Visible == true)
            {
                pnl_report.Visible = false;
            }
        }

        #endregion

        #region showsubmenu

        private void showsubmenu(Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                hidesubmenu();
                Submenu.Visible = true;
            }
            else
            {
                Submenu.Visible = false;
            }
        }

#endregion

        #region btn_Student

        private void btn_Student_Click(object sender, EventArgs e)
        {
            showsubmenu(pnl_Student);
        }

        private void btn_Student_Registration_Click(object sender, EventArgs e)
        {
            openChiledForm(new frm_Student_Registration());

            hidesubmenu();
        }

        private void btn_Update_Student_Click(object sender, EventArgs e)
        {
            openChiledForm(new frm_Update_Student());

            hidesubmenu();
        }

        private void btn_All_Student_Click(object sender, EventArgs e)
        {
            openChiledForm(new frm_All_Student());

            hidesubmenu();
        }
        #endregion

        #region btn_Trainer

        private void btn_Trainer_Click(object sender, EventArgs e)
        {
            showsubmenu(pnl_Trainer);
        }

        private void btn_Trainer_Registration_Click(object sender, EventArgs e)
        {
            openChiledForm(new frm_Trainer_Registration());

            hidesubmenu();
        }

        private void btn_Trainer_Update_Click(object sender, EventArgs e)
        {
            openChiledForm(new frm_Update_Trainer());

            hidesubmenu();
        }

        private void btn_All_Trainers_Click(object sender, EventArgs e)
        {
            openChiledForm(new frm_All_Trainer());

            hidesubmenu();
        }

        #endregion

        #region btn_Vehical

        private void btn_Vehical_Details_Click(object sender, EventArgs e)
        {
            showsubmenu(pnl_Vehical_Details);
        }

        private void btn_Add_Vehical_Details_Click(object sender, EventArgs e)
        {
            openChiledForm(new frm_Vehical_Details());

            hidesubmenu();
        }

        private void btn_Update_Vehical_Click(object sender, EventArgs e)
        {
            openChiledForm(new frm_Update_Vehical());

            hidesubmenu();
        }

        private void btn_All_Vehical_Click(object sender, EventArgs e)
        {
            openChiledForm(new frm_All_Vehicals_Details());

            hidesubmenu();
        }

        #endregion

        #region btn_Course

        private void btn_Course_Click(object sender, EventArgs e)
        {
            showsubmenu(pnl_Course);
        }

        private void btn_Course_Structure_Click(object sender, EventArgs e)
        {
            openChiledForm(new frm_Course_Structure());

            hidesubmenu();
        }

        private void btn_Course_Update_Click(object sender, EventArgs e)
        {
            openChiledForm(new frm_Update_Course_Structure());

            hidesubmenu();
        }

        #endregion

        #region btn_Licence

        private void btn_Licence_Click(object sender, EventArgs e)
        {
            showsubmenu(pnl_Licence);
        }

        private void btn_Licence_Candidate_Click(object sender, EventArgs e)
        {
            openChiledForm(new frm_Licence_Candidate());

            hidesubmenu();
        }

        private void btn_Licence_Appointment_Click(object sender, EventArgs e)
        {
            openChiledForm(new frm_Licence_Appointment());

            hidesubmenu();
        }

        #endregion

        #region btn_Maintanance

        private void btn_Maintanance_Click(object sender, EventArgs e)
        {
            showsubmenu(pnl_Maintannce);
        }

        private void btn_Vehical_Maintanance_Click(object sender, EventArgs e)
        {
            openChiledForm(new frm_Vehical_Maintanance());
            hidesubmenu();
        }

        private void btn_All_V_Maintanance_Click(object sender, EventArgs e)
        {
            openChiledForm(new frm_All_Vehical_Maintanance_Details());
            hidesubmenu();
        }
        #endregion

        #region Fee

        private void btn_Fee_Details_Click(object sender, EventArgs e)
        {
            showsubmenu(pnl_fee_details);
        }

        private void btn_All_Fee_Click(object sender, EventArgs e)
        {
            openChiledForm(new frm_All_Students_Fee());
            hidesubmenu();
        }

        private void btn_Fee_Click(object sender, EventArgs e)
        {
            openChiledForm(new frm_Single_Fee_Details());
            hidesubmenu();
        }

        #endregion

        #region Active_From


        private Form ActiveFrom = null;

        private void openChiledForm(Form ChiledForm)
        {
            if (ActiveFrom != null)
                ActiveFrom.Close();

            ActiveFrom = ChiledForm;
            ChiledForm.TopLevel = false;
            ChiledForm.FormBorderStyle = FormBorderStyle.None;
            ChiledForm.Dock = DockStyle.Fill;
            pnl_Main.Controls.Add(ChiledForm);
            pnl_Main.Tag = ChiledForm;
            ChiledForm.BringToFront();
            ChiledForm.Show();
        }

        #endregion

        #region Log Out

        private void pb_Log_out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure ???", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Res == DialogResult.Yes)
            {
                frm_Login obj = new frm_Login();
                obj.Show();
                this.Hide();
            }
        }





        #endregion

        #region report

        private void btn_Report_Click(object sender, EventArgs e)
        {
            showsubmenu(pnl_report);
        }

        private void btn_V_All_Maintanance_Click(object sender, EventArgs e)
        {
            openChiledForm(new Reports_From.frm_rep_All_Vehical_Maintanance());
            hidesubmenu();
        }

        private void btn_Rep_All_Student_Fee_Click(object sender, EventArgs e)
        {
            openChiledForm(new Reports_From.frm_rep_All_Student_Fee());
            hidesubmenu();
        }

        private void btn_All_Trainer_Click(object sender, EventArgs e)
        {
            openChiledForm(new Reports_From.frm_rep_All_Trainer());
            hidesubmenu();
        }

        #endregion

        #region dashbord

        private void btn_dashbord_Click(object sender, EventArgs e)
        {
            if (ActiveFrom != null)
                ActiveFrom.Close();

            pnl_Main.Controls.Add(pnl_Cover);
        }



        #endregion

        
    }
}

