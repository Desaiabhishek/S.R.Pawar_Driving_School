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
    public partial class frm_login_page : Form
    {
        public frm_login_page()
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

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            this.Hide();
            obj.Show();
        }

        #region login

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
                frm_Add_login_User man = new frm_Add_login_User();
                man.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incurrect Password & UserName", "Incurrect Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con_Close();
        }

        #endregion
    }
}
