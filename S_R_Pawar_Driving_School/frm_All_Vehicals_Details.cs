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
    public partial class frm_All_Vehicals_Details : Form
    {
        public frm_All_Vehicals_Details()
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

            dgv_All_Vehical_Details.DataSource = "";

            SqlDataAdapter SDA = new SqlDataAdapter(Quary, Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_All_Vehical_Details.DataSource = dt;

            Con_Close();
        }
        #endregion


        private void frm_All_Vehicals_Details_Load(object sender, EventArgs e)
        {
            tb_Vehical_ID.Focus();
            Data_Griade_View_Bind("Select * From Add_Vehicle_Details");
        }

        #region Search Vehical ID

        private void pb_Vehical_ID_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Vehical_ID.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Select * From Add_Vehicle_Details Where Vehicle_ID = '" + tb_Vehical_ID.Text + "'", Con);

               SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    Con_Close();
                    Con_Open();
                    Data_Griade_View_Bind("Select * From Add_Vehicle_Details Where Vehicle_ID = '" + tb_Vehical_ID.Text + "'");
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

        #region Vehical Name

        private void pb_Name_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Name.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Select * From Add_Vehicle_Details Where Name = '" + tb_Name.Text + "'", Con);

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    Con_Close();

                    Con_Open();
                    Data_Griade_View_Bind("Select * From Add_Vehicle_Details Where Name = '" + tb_Name.Text + "'");
                }

                else
                {
                    MessageBox.Show("Invalid Vaihicle Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Name.Clear();
                }
            }
            else
            {
                MessageBox.Show("Frist Fill Vehicle Name", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            Con_Close();
        }

        #endregion

        #region Vehicle_No

        private void pb_Vehical_No_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_vehical_No.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Select * From Add_Vehicle_Details Where Vehicle_No = '" + tb_vehical_No.Text + "'", Con);

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    Con_Close();

                    Con_Open();
                    Data_Griade_View_Bind("Select * From Add_Vehicle_Details Where Vehicle_No = '" + tb_vehical_No.Text + "'");
                }

                else
                {
                    MessageBox.Show("Invalid Vaihicle No", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_vehical_No.Clear();
                }
            }
            else
            {
                MessageBox.Show("Frist Fill Vehicle No", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            Con_Close();
        }

        #endregion

        #region Clear

        private void btn_Clear_Click_1(object sender, EventArgs e)
        {
            tb_Vehical_ID.Clear();
            tb_Name.Clear();
            tb_vehical_No.Clear();

            Data_Griade_View_Bind("Select * From Add_Vehicle_Details");
        }
        #endregion

        #region keypress

        private void Is_Letter(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void IS_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Is_Letter_Digit(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetterOrDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}
