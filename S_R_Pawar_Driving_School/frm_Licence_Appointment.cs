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
    public partial class frm_Licence_Appointment : Form
    {
        public frm_Licence_Appointment()
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
            tb_Mobile_No.Clear();
            tb_Name.Clear();
            dtp_Appointment_date.ResetText();
            tb_Student_ID.Clear();
        }

        #endregion

        #region Data Griade View Bind

        void Data_Griade_View_Bind(string Quary)
        {
            Con_Open();

            dgv_License_App.DataSource = "";

            SqlDataAdapter SDA = new SqlDataAdapter(Quary, Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_License_App.DataSource = dt;

            Con_Close();
        }
        #endregion

        private void frm_Licence_Appointment_Load(object sender, EventArgs e)
        {
            Data_Griade_View_Bind("Select Student_ID,Name,Mobile_No,Appointment_Date From Student_Licence_Appointment");
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
                    tb_Name.Text = Dr.GetString(Dr.GetOrdinal("First_Name"));
                    tb_Mobile_No.Text = (Dr["Mobile_No"].ToString());

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

        #region save

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Student_ID.Text != "" && tb_Name.Text != "" && tb_Mobile_No.Text != "" && dtp_Appointment_date.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert Into Student_Licence_Appointment (Student_ID,Name,Mobile_No,Appointment_Date) Values(@Sid,@Name,@Mob,@Date)";

                Cmd.Parameters.Add("Sid",SqlDbType.Int).Value = tb_Student_ID.Text;
                Cmd.Parameters.Add("Name",SqlDbType.NVarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("Mob",SqlDbType.NVarChar).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("Date",SqlDbType.DateTime).Value = dtp_Appointment_date.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Save Successfully", "SAVED SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                Data_Griade_View_Bind("Select Student_ID,Name,Mobile_No,Appointment_Date From Student_Licence_Appointment");
            }
            else
            {
                MessageBox.Show("First Fill All Fields", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }

        #endregion

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
