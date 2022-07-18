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
    public partial class frm_Update_Trainer : Form
    {
        public frm_Update_Trainer()
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
            tb_Trainer_ID.Clear();
            tb_Name.Clear();
            tb_Address.Clear();
            tb_Mobile_No.Clear();
            tb_PAN_No.Clear();
            tb_Addhar_No.Clear();
            cmb_Vehical_Type.SelectedIndex = -1;
            tb_Licence_No.Clear();
            cmb_Post.SelectedIndex = -1;
            tb_Salary.Clear();

            tb_Trainer_ID.Focus();
            tb_Trainer_ID.Enabled = true;
        }

        #endregion

        #region Combo Box Bind Vehical Type

        void Combo_Box_Bind_Vehical_Type()
        {
            cmb_Vehical_Type.Items.Clear();

            Con.Open();

            SqlCommand Cmd = new SqlCommand("Select Vehicle_Type From Course_Structure", Con);

            SqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                cmb_Vehical_Type.Items.Add(Dr.GetString(Dr.GetOrdinal("Vehicle_Type")));
            }
            Con.Close();
        }

        #endregion

        private void frm_Update_Trainer_Load(object sender, EventArgs e)
        {
            tb_Trainer_ID.Focus();
            Combo_Box_Bind_Vehical_Type();
        }

        #region Search

        private void pb_Search_Trainer_ID_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Trainer_ID.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Select * From Add_Trainer Where Trainer_ID = '" + tb_Trainer_ID.Text + "' ", Con);

                SqlDataReader Dr = Cmd.ExecuteReader();

                if(Dr.Read())
                {
                    tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                    tb_Address.Text = Dr.GetString(Dr.GetOrdinal("Address"));
                    tb_Mobile_No.Text = (Dr["Mobile_No"].ToString());
                    tb_Addhar_No.Text = (Dr["Addhar_No"].ToString());
                    tb_PAN_No.Text = (Dr["PAN_No"].ToString());
                    cmb_Vehical_Type.Text = Dr.GetString(Dr.GetOrdinal("Vehicle_Type"));
                    tb_Licence_No.Text = (Dr["Licence_No"].ToString());
                    cmb_Post.Text = Dr.GetString(Dr.GetOrdinal("Post"));
                    tb_Salary.Text = (Dr["Salary"].ToString());

                    tb_Trainer_ID.Enabled = false;            
                    
                }
                else
                {
                    MessageBox.Show("Invalid Trainer ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Trainer_ID.Clear();
                }

            }
            else
            {
                MessageBox.Show("First Fill Trainer ID", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }
        #endregion

        #region Update

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Name.Text != "" && tb_Address.Text != "" && tb_Mobile_No.TextLength == 10 && tb_Addhar_No.TextLength == 12 && tb_PAN_No.Text != "" && cmb_Vehical_Type.Text != ""  && tb_Licence_No.Text != "" && cmb_Post.Text != "" && tb_Salary.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Update Add_Trainer Set Name = @Name,Address =@Add,Mobile_No = @Mob ,Addhar_No = @Addhar ,PAN_No = @PAN ,Vehicle_Type = @VType ,Licence_No = @LNo ,Post = @Post ,Salary = @Salary Where  Trainer_ID = @TID ", Con);

                Cmd.Parameters.Add("TID", SqlDbType.Int).Value = tb_Trainer_ID.Text;
                Cmd.Parameters.Add("Name", SqlDbType.NVarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("Add", SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("Mob", SqlDbType.NVarChar).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("Addhar", SqlDbType.NVarChar).Value = tb_Addhar_No.Text;
                Cmd.Parameters.Add("PAN", SqlDbType.NVarChar).Value = tb_PAN_No.Text;
                Cmd.Parameters.Add("VType", SqlDbType.NVarChar).Value = cmb_Vehical_Type.Text;
                Cmd.Parameters.Add("LNo", SqlDbType.NVarChar).Value = tb_Licence_No.Text;
                Cmd.Parameters.Add("Post", SqlDbType.NVarChar).Value = cmb_Post.Text;
                Cmd.Parameters.Add("Salary", SqlDbType.NVarChar).Value = tb_Salary.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Trainer Details Update Successfully", "UPDATE SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
