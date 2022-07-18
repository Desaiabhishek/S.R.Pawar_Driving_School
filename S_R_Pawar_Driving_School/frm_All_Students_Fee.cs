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
    public partial class frm_All_Students_Fee : Form
    {
        public frm_All_Students_Fee()
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

            dgv_All_Student_Fee.DataSource = "";

            SqlDataAdapter SDA = new SqlDataAdapter(Quary, Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_All_Student_Fee.DataSource = dt;

            Con_Close();
        }
        #endregion

        private void All_Students_Fee_Load(object sender, EventArgs e)
        {
            Data_Griade_View_Bind("Select * from Fee_Details");
        }

        #region Search Student ID

        private void pb_Search_Student_ID_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Student_ID.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select * from Fee_Details where Student_ID = '" + tb_Student_ID.Text + "'",Con);

                SqlDataReader Dr = cmd.ExecuteReader();

                if(Dr.Read())
                {
                    Con_Close();
                    Con_Open();
                    Data_Griade_View_Bind("Select * from Fee_Details where Student_ID = '" + tb_Student_ID.Text + "'");
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

        #region Search Name

        private void pb_search_Name_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Name.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select * from Fee_Details where Name = '" + tb_Name.Text + "'", Con);

                SqlDataReader Dr = cmd.ExecuteReader();

                if (Dr.Read())
                {
                    Con_Close();
                    Con_Open();
                    Data_Griade_View_Bind("Select * from Fee_Details where Name = '" + tb_Name.Text + "'");
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
            tb_Name.Clear();
            tb_Student_ID.Clear();
            Data_Griade_View_Bind("Select * from Fee_Details");
        }

        #region keypress

        private void Is_Letter(object sender, KeyPressEventArgs e)
        {

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
