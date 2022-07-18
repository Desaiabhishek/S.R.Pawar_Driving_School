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
    public partial class frm_All_Vehical_Maintanance_Details : Form
    {
        public frm_All_Vehical_Maintanance_Details()
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

        #region Data Griade View Bind

        void Data_Griade_View_Bind(string Quary)
        {
            Con_Open();

            dgv_All_V_Maintanance.DataSource = "";

            SqlDataAdapter SDA = new SqlDataAdapter(Quary, Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_All_V_Maintanance.DataSource = dt;

            Con_Close();
        }
        #endregion

        private void frm_All_Vehical_Maintanance_Details_Load(object sender, EventArgs e)
        {
            Data_Griade_View_Bind("Select Vehicle_ID,Servicing_Date,Description,Payment,Payment_By From Vehicle_Maintanance");
        }

        #region Search Vehical_ID

        private void pb_Search_Vehical_ID_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Vehical_ID.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Select Vehicle_ID,Servicing_Date,Description,Payment,Payment_By From Vehicle_Maintanance where Vehicle_ID = '" + tb_Vehical_ID.Text + "' ", Con);

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    Con_Close();
                    Con_Open();
                    Data_Griade_View_Bind("Select Vehicle_ID,Servicing_Date,Description,Payment,Payment_By From Vehicle_Maintanance where Vehicle_ID = '" + tb_Vehical_ID.Text + "' ");
                }

                else
                {
                    MessageBox.Show("Invalid Vehicle ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Vehical_ID.Clear();
                }
            }
            else
            {

                MessageBox.Show("Frist Fill Vehical ID", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Con_Close();
        }

        #endregion

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_Vehical_ID.Clear();
            Data_Griade_View_Bind("Select Vehicle_ID,Servicing_Date,Description,Payment,Payment_By From Vehicle_Maintanance");
        }

        #region keypress

        private void IS_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}
