using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace S_R_Pawar_Driving_School
{
    public partial class frm_Update_Vehical : Form
    {
        public frm_Update_Vehical()
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

        #region Clear

        void Clear()
        {
            tb_Vehical_ID.Clear();
            tb_Name.Clear();
            tb_Model.Clear();
            tb_Vehical_Type.Clear();
            tb_vehical_No.Clear();
            tb_Owner.Clear();
            dtp_Insurance_Upto.ResetText();
            tb_Details.Clear();

            tb_Vehical_ID.Enabled = true;
            tb_Vehical_ID.Focus();
        }
        #endregion

        private void frm_Update_Vehical_Load(object sender, EventArgs e)
        {
            tb_Vehical_ID.Focus();
        }

        #region Search

        private void pb_Search_Vehical_ID_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Vehical_ID.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Select * From Add_Vehicle_Details Where Vehicle_ID = '" + tb_Vehical_ID.Text + "'", Con);

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                    tb_Model.Text = Dr.GetString(Dr.GetOrdinal("Model"));
                    tb_Vehical_Type.Text = Dr.GetString(Dr.GetOrdinal("Vehicle_Type"));
                    tb_vehical_No.Text = (Dr["Vehicle_No"].ToString()); 
                    tb_Owner.Text = Dr.GetString(Dr.GetOrdinal("Owner"));
                    dtp_Insurance_Upto.Text = (Dr["Insurance_Upto"].ToString());
                    tb_Details.Text = Dr.GetString(Dr.GetOrdinal("Details"));

                    tb_Vehical_ID.Enabled = false;

                }
           
                else
                {
                    MessageBox.Show("Invalid Vehicle ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Vehical_ID.Clear();
                }
            }
            else
            {

                MessageBox.Show("Frist Fill Vehicle ID", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Con_Close();
        }

        #endregion

        #region Update

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            if ( tb_Name.Text != "" && tb_Model.Text != "" && tb_Vehical_Type.Text != "" && tb_vehical_No.Text != "" && tb_Owner.Text != "" && dtp_Insurance_Upto.Text != "" && tb_Details.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Update Add_Vehicle_Details Set Name = '" + tb_Name.Text + "',Model = '" + tb_Model.Text + "',Vehicle_Type = '" + tb_Vehical_Type.Text + "',Vehicle_No = '" + tb_vehical_No.Text + "',Owner = '" + tb_Owner.Text + "',Insurance_Upto = '" + dtp_Insurance_Upto.Text + "',Details = '" + tb_Details.Text + "' Where Vehicle_ID  = '" + tb_Vehical_ID.Text + "' ", Con);

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Vehical Details Update Successfully", "UPDATE SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Clear();
            }
            else
            {
                MessageBox.Show("First Fill All Fields", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }

        #endregion

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
