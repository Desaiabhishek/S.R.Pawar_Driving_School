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
    public partial class frm_All_Student : Form
    {
        public frm_All_Student()
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

            dgv_All_Student.DataSource = "";

            SqlDataAdapter SDA = new SqlDataAdapter(Quary, Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_All_Student.DataSource = dt;

            Con_Close();
        }
        #endregion

        private void frm_All_Student_Load(object sender, EventArgs e)
        {
            tb_Student_ID.Focus();
            Data_Griade_View_Bind("Select Student_ID,First_Name,Last_Name,Mobile_No,DOB,Addhar_No,PAN_No,Addmition_Date,Time From Student_Registrion");
        }

        #region Search Student ID

        private void pb_Search_Student_ID_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Student_ID.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Select Student_ID,First_Name,Last_Name,Mobile_No,DOB,Addhar_No,PAN_No,Addmition_Date,Time From Student_Registrion Where Student_ID = '" + tb_Student_ID.Text + "'", Con);

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    Con_Close();
                    Con_Open();
                    Data_Griade_View_Bind("Select Student_ID,First_Name,Last_Name,Mobile_No,DOB,Addhar_No,PAN_No,Addmition_Date,Time From Student_Registrion Where Student_ID = '" + tb_Student_ID.Text + "'");
                }

                else
                {
                    MessageBox.Show("Invalid Student ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Student_ID.Clear();
                }
            }
            else
            {

                MessageBox.Show("Frist Fill Student ID", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Con_Close();
        }

        #endregion

        #region Search Student Name

        private void pb_search_Name_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Name.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Select Student_ID,First_Name,Last_Name,Mobile_No,DOB,Addhar_No,PAN_No,Addmition_Date,Time From Student_Registrion Where Name = '" + tb_Name.Text + "'", Con);

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    Con_Close();
                    Con_Open();
                    Data_Griade_View_Bind("Select Student_ID,First_Name,Last_Name,Mobile_No,DOB,Addhar_No,PAN_No,Addmition_Date,Time From Student_Registrion Where Name = '" + tb_Name.Text + "'");
                }

                else
                {
                    MessageBox.Show("Invalid Student Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Student_ID.Clear();
                }
            }
            else
            {

                MessageBox.Show("Frist Fill Student Name", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Con_Close();
        }

        #endregion

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_Student_ID.Clear();
            tb_Name.Clear();
            Data_Griade_View_Bind("Select Student_ID,First_Name,Last_Name,Mobile_No,DOB,Addhar_No,PAN_No,Addmition_Date,Time From Student_Registrion");

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

        #endregion
    }
}
