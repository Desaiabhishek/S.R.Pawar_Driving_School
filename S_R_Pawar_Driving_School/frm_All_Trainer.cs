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
    public partial class frm_All_Trainer : Form
    {
        public frm_All_Trainer()
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

            dgv_All_Trainer.DataSource = "";

            SqlDataAdapter SDA = new SqlDataAdapter(Quary, Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_All_Trainer.DataSource = dt;

            Con_Close();
        }
        #endregion

        private void frm_All_Trainer_Load(object sender, EventArgs e)
        {
            tb_Trainer_ID.Focus();
            Data_Griade_View_Bind("Select Trainer_ID,Name,Address,Mobile_No,Addhar_No,Jioning_Date,Vehicle_Type,Licence_No,Post,Salary From Add_Trainer");
        }

        #region Trianer ID Search

        private void pb_Trianer_ID_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Trainer_ID.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Select Trainer_ID,Name,Address,Mobile_No,Addhar_No,Jioning_Date,Vehicle_Type,Licence_No,Post,Salary From Add_Trainer Where Trainer_ID = '" + tb_Trainer_ID.Text + "'", Con);

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    Con_Close();
                    Con_Open();
                    Data_Griade_View_Bind("Select Trainer_ID,Name,Address,Mobile_No,Addhar_No,Jioning_Date,Vehicle_Type,Licence_No,Post,Salary From Add_Trainer Where Trainer_ID = '" + tb_Trainer_ID.Text + "'");
                }

                else
                {
                    MessageBox.Show("Invalid Trainer ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Trainer_ID.Clear();
                }
            }
            else
            {

                MessageBox.Show("Frist Fill Trainer ID", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Con_Close();
        }
        #endregion

        #region Name Search

        private void pb_Name_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Name.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Select Trainer_ID,Name,Address,Mobile_No,Addhar_No,Jioning_Date,Vehicle_Type,Licence_No,Post,Salary From Add_Trainer Where Name = '" + tb_Name.Text + "'", Con);

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    Con_Close();
                    Con_Open();
                    Data_Griade_View_Bind("Select Trainer_ID,Name,Address,Mobile_No,Addhar_No,Jioning_Date,Vehicle_Type,Licence_No,Post,Salary From Add_Trainer Where Name = '" + tb_Name.Text + "'");
                }

                else
                {
                    MessageBox.Show("Invalid Trainer Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Name.Clear();
                }
            }
            else
            {

                MessageBox.Show("Frist Fill Trainer Name", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Con_Close();
        }
        #endregion

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_Trainer_ID.Clear();
            tb_Name.Clear();
            Data_Griade_View_Bind("Select Trainer_ID,Name,Address,Mobile_No,Addhar_No,Jioning_Date,Vehicle_Type,Licence_No,Post,Salary From Add_Trainer");
        }

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
