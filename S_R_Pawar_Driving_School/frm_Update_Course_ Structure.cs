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
    public partial class frm_Update_Course_Structure : Form
    {
        public frm_Update_Course_Structure()
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
            tb_Course_ID.Clear();
            tb_Course_Name.Clear();
            tb_Vehical_Type.Clear();
            tb_Training_Fee.Clear();
            tb_Licence_Fee.Clear();
            tb_Duration.Clear();
            tb_Other_Details.Clear();

            tb_Course_ID.Focus();
            tb_Course_ID.Enabled = true;
        }
        #endregion

        private void frm_Update_Course_Structure_Load(object sender, EventArgs e)
        {
            tb_Course_ID.Focus();
        }

        #region Search

        private void pb_Course_ID_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Course_ID.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Select * From Course_Structure Where Course_ID = '" + tb_Course_ID.Text + "' ", Con);

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Course_Name.Text = Dr.GetString(Dr.GetOrdinal("Course_Name"));
                    tb_Vehical_Type.Text = Dr["Vehicle_Type"].ToString();
                    tb_Other_Details.Text = Dr.GetString(Dr.GetOrdinal("Other_Details"));
                    tb_Training_Fee.Text = (Dr["Training_Fee"].ToString());
                    tb_Licence_Fee.Text = (Dr["Licence_Fee"].ToString());
                    tb_Duration.Text = Dr.GetString(Dr.GetOrdinal("Duration"));

                    tb_Course_ID.Enabled = false;
                }

                else
                {
                    MessageBox.Show("Invalid Course ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Course_ID.Clear();
                }
             }
                else
                {

                    MessageBox.Show("Frist Fill Course ID", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                Con_Close();

        }
        #endregion

        #region Update

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

           if(tb_Course_Name.Text != ""  && tb_Other_Details.Text != "" && tb_Training_Fee.Text != "" && tb_Licence_Fee.Text != "" && tb_Duration.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Update Course_Structure Set Course_Name = '"+tb_Course_Name.Text+"',Other_Details = '"+tb_Other_Details.Text+"',Training_Fee = '"+tb_Training_Fee.Text+"',Licence_Fee = '"+tb_Licence_Fee.Text+"',Duration = '"+tb_Duration.Text+"'Where Course_ID = '"+tb_Course_ID.Text+"'",Con);

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Course Details Update Successfully", "UPDATE SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void Is_Amount(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
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
