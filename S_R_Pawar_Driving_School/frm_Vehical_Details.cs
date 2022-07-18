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
    public partial class frm_Vehical_Details : Form
    {
        public frm_Vehical_Details()
        {
            InitializeComponent();
        }

        #region Connection

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=S.R.Pawar_Driving_School;Integrated Security=True");

        void Con_Open()
        {
            if(Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if(Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        #endregion

        #region Auto Incr

        void Auto_Incr()
        {
            int Cnt = 0;

            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Count(Vehicle_ID) From Add_Vehicle_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if(Cnt > 0)
            {
                Cmd.Connection = Con;

                Cmd.CommandText = "Select Max(Vehicle_ID) From Add_Vehicle_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            }
            else
            {
                Cnt = 100;
            }

            tb_Vehical_ID.Text = Convert.ToString(Cnt + 1);

            Con_Close();
        }
        #endregion

        #region Clear

        void Clear()
        {
            tb_Name.Clear();
            tb_Model.Clear();
            tb_Vehical_Type.Clear();
            tb_vehical_No.Clear();
            tb_Owner.Clear();
            tb_Details.Clear();
            dtp_Insurance_Upto.ResetText();

            tb_Name.Focus();
        }
        #endregion

        private void frm_Vehical_Details_Load(object sender, EventArgs e)
        {
            tb_Name.Focus();
            Auto_Incr();
        }

        #region Save

        private void btn_Add_Click(object sender, EventArgs e)
        {
      
        }
        private void btn_Add_Click_1(object sender, EventArgs e)
        {
            Con.Open();

            if (tb_Vehical_ID.Text != "" && tb_Name.Text != "" && tb_Model.Text != "" && tb_Vehical_Type.Text != "" && tb_vehical_No.Text != "" && tb_Owner.Text != "" && dtp_Insurance_Upto.Text != "" && tb_Details.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Insert Into Add_Vehicle_Details Values('" + tb_Vehical_ID.Text + "','" + tb_Name.Text + "','" + tb_Model.Text + "','" + tb_Vehical_Type.Text + "','" + tb_vehical_No.Text + "','" + tb_Owner.Text + "','" + dtp_Insurance_Upto.Text + "','" + tb_Details.Text + "')",Con);

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Vehical Details Save Successfully", "SAVED SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Vehical_ID.Clear();
                Clear();
                Auto_Incr();
            }
            else
            {
                MessageBox.Show("First Fill All Fields", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con.Close();
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
