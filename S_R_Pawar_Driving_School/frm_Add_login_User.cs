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
    public partial class frm_Add_login_User : Form
    {
        public frm_Add_login_User()
        {
            InitializeComponent();
        }

        #region Clear

        void Clear()
        {
            tb_username.Clear();
            tb_Password.Clear();
            tb_reenter_password.Clear();

            tb_username.Focus();
        }
        #endregion

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

        private void lbl_Back_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            this.Hide();
            obj.Show();
        }

        #region Save

        private void btn_Save_Click(object sender, EventArgs e)
        {

            if(tb_username.Text != "" && tb_Password.Text != "" && tb_reenter_password.Text != "")
            {
                Con_Open();

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Con;
                cmd.CommandText = "Select * From Login Where Username = '" + tb_username.Text + "'";

                SqlDataReader Dr = cmd.ExecuteReader();

                if (Dr.Read())
                {
                    MessageBox.Show("all ready exist username", "Duplicate UserName", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb_username.Clear();
                    tb_username.Focus();
                    Con_Close();
                }

                else if (tb_username.Text != "" && tb_Password.TextLength == 8 && tb_reenter_password.Text == tb_Password.Text)
                {
                    Dr.Close();
                    Con_Open();
                   
                    SqlCommand Cmd = new SqlCommand("Insert Into Login values('" + tb_username.Text + "','" + tb_Password.Text + "')", Con);
                    Cmd.ExecuteNonQuery();

                    MessageBox.Show("User Add Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    Con_Close();
                }
                else
                {
                    if(tb_Password.TextLength != 8)
                    {
                        MessageBox.Show("Password Must Be 8 Character", "WARNING", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                    MessageBox.Show("ReEnter Password And Password Not Same","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("First Fill All Fileds", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        #endregion
    }
}
