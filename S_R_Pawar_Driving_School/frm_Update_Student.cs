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
    public partial class frm_Update_Student : Form
    {
        public frm_Update_Student()
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
            tb_Student_ID.Clear();
            tb_First_Name.Clear();
            tb_Middle_Name.Clear();
            tb_Last_Name.Clear();
            tb_Mobile_No.Clear();
            tb_Addhar_No.Clear();
            tb_PAN_No.Clear();
            tb_Batch.Clear();
            dtp_DOB.ResetText();
            tb_Student_ID.Enabled = true;
            tb_Student_ID.Focus();

        }
        #endregion

        private void frm_Update_Student_Load(object sender, EventArgs e)
        {
            tb_Student_ID.Focus();
        }

        #region Search

        private void pb_Search_Student_ID_Click(object sender, EventArgs e)
        {

            Con_Open();

            if (tb_Student_ID.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Select * From Student_Registrion Where Student_ID = '" + tb_Student_ID.Text + "' ", Con);

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_First_Name.Text = Dr.GetString(Dr.GetOrdinal("First_Name"));
                    tb_Middle_Name.Text = Dr.GetString(Dr.GetOrdinal("Middle_Name"));
                    tb_Last_Name.Text = Dr.GetString(Dr.GetOrdinal("Last_Name"));
                    dtp_DOB.Text = (Dr["DOB"].ToString());
                    tb_Mobile_No.Text = (Dr["Mobile_No"].ToString());
                    tb_Addhar_No.Text = (Dr["Addhar_No"].ToString());
                    tb_PAN_No.Text = (Dr["PAN_No"].ToString());
                    tb_Batch.Text = (Dr["Time"].ToString());

                    tb_Student_ID.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Invalid Student ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Student_ID.Clear();
                }

            }
            else
            {
                MessageBox.Show("First Fill Student ID", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }

        #endregion

        #region Update

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_First_Name.Text != "" && tb_Mobile_No.TextLength == 10 && tb_Addhar_No.TextLength == 12 && tb_PAN_No.Text != "" && tb_Batch.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Update Student_Registrion Set First_Name = @Fname,Middle_Name = @Mname,Last_Name = @Lname,DOB = @dob,Mobile_No = @Mob ,Addhar_No = @Addhar ,PAN_No = @PAN,Time = @Time Where  Student_ID = @SID ", Con);

                Cmd.Parameters.Add("SID", SqlDbType.Int).Value = tb_Student_ID.Text;
                Cmd.Parameters.Add("Fname", SqlDbType.NVarChar).Value = tb_First_Name.Text;
                Cmd.Parameters.Add("Mname", SqlDbType.NVarChar).Value = tb_Middle_Name.Text;
                Cmd.Parameters.Add("Lname", SqlDbType.NVarChar).Value = tb_Last_Name.Text;
                Cmd.Parameters.Add("dob", SqlDbType.DateTime).Value = dtp_DOB.Text;
                Cmd.Parameters.Add("Mob", SqlDbType.NVarChar).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("Addhar", SqlDbType.NVarChar).Value = tb_Addhar_No.Text;
                Cmd.Parameters.Add("PAN", SqlDbType.NVarChar).Value = tb_PAN_No.Text;
                Cmd.Parameters.Add("Time", SqlDbType.NVarChar).Value = tb_Batch.Text;


                Cmd.ExecuteNonQuery();

                MessageBox.Show("Student Details Update Successfully", "UPDATE SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear();
            }
            else
            {
                MessageBox.Show("First Fill All Fields", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
