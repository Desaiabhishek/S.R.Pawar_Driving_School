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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        #region Connection

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=S.R.Pawar_Driving_School;Integrated Security=True");
        // private string filename;

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

        void clear()
        {
            tb_username.Clear();
            tb_Password.Clear();

            tb_username.Focus();
        }

        #region Login

        private void btn_Login_Click(object sender, EventArgs e)
        {
            int cnt = 0;

            Con_Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = Con;
            cmd.CommandText = "Select Count(*) From Login Where Username = @Uname And Password = @Pswd";

            cmd.Parameters.Add("Uname", SqlDbType.NVarChar).Value = tb_username.Text;
            cmd.Parameters.Add("Pswd", SqlDbType.NVarChar).Value = tb_Password.Text;

            cnt = Convert.ToInt32(cmd.ExecuteScalar());

            if (cnt > 0)
            {
                MessageBox.Show("Welcome", "Login Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Globalvar.add = tb_username.Text;

                frm_Main man = new frm_Main();
                man.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Falid", "Incurrect Details", MessageBoxButtons.OK, MessageBoxIcon.Error);

                clear();
            }
            Con_Close();
        }

        #endregion

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_Register_Click(object sender, EventArgs e)
        {
            frm_Add_login_User obj = new frm_Add_login_User();
            this.Hide();
            obj.Show();
        }
    }
}
