using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace S_R_Pawar_Driving_School
{
    public partial class frm_License_Fee : Form
    {
        public frm_License_Fee()
        {
            InitializeComponent();
        }

        #region Connection

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=S.R.Pawar_Driving_School;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        #endregion

        private void btn_Next_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Paid_Fee_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Main obj = new frm_Main();
            this.Hide();
            obj.Show();
        }

        private void frm_License_Fee_Load(object sender, EventArgs e)
        {
            Con_Open();
            SqlCommand cmd = new SqlCommand("Select * From Licence_Candidate where Candidate_ID = (select max(Candidate_ID) From Licence_Candidate)", Con);
            var obj = cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Candidate_ID.Text = obj["Candidate_ID"].ToString();
                tb_Mobile_No.Text = obj["Mobile_No"].ToString();
                tb_Name.Text = obj["Name"].ToString();
            }
            Con_Close();
        }
    }
}
