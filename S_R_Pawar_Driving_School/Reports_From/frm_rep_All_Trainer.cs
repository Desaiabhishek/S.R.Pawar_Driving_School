using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace S_R_Pawar_Driving_School.Reports_From
{
    public partial class frm_rep_All_Trainer : Form
    {
        public frm_rep_All_Trainer()
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

        private void frm_rep_All_Trainer_Load(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand("Select * from Add_Trainer", Con);
            SqlDataAdapter Sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            Sda.Fill(ds, "Add_Trainer");
            Report.cryrep_All_trainer src = new Report.cryrep_All_trainer();
            src.SetDataSource(ds);
            this.crv_All_trainer.ReportSource = src;
            this.crv_All_trainer.Refresh();
            Con_Close();
        }
    }
}
