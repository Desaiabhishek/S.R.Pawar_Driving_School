using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace S_R_Pawar_Driving_School
{
    public partial class frm_Trainer_Registration : Form
    {
        public frm_Trainer_Registration()
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

        #region Auto Incr

        void Auto_Incr()
        {
            int Cnt = 0;

           Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Count(Trainer_ID) From Add_Trainer";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;

                Cmd.CommandText = "Select Max(Trainer_ID) From Add_Trainer";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            }
            else
            {
                Cnt = 1000;
            }

            tb_Trainer_ID.Text = Convert.ToString(Cnt + 1);

            Con_Close();
        }
        #endregion

        #region Clear

        void Clear()
        {
            tb_Name.Clear();
            tb_Address.Clear();
            tb_Mobile_No.Clear();
            tb_Addhar_No.Clear();
            tb_PAN_No.Clear();
            dtp_Joining_Date.ResetText();
            cmb_Vehical_Type.SelectedIndex = -1;
            tb_Licence_No.Clear();
            cmb_Post.SelectedIndex = -1;
            tb_Salary.Clear();

            tb_Name.Focus();
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

        private void frm_Trainer_Registration_Load(object sender, EventArgs e)
        {
            tb_Name.Focus();
            Auto_Incr();
            Combo_Box_Bind_Vehical_Type();
        }

        #region file Update

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C://Desktop";

            openFileDialog1.Title = "Select file to be upload.";

            openFileDialog1.Filter = "Select Valid Document(*.pdf; *.doc)|*.pdf; *.docx";

            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        //string path = Path.GetFullPath(openFileDialog1.FileName);
                        // label1.Text = path;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload document.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
        
        #region Save

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            try
            {
                string filename = Path.GetFileName(openFileDialog1.FileName);
                if (filename == null)
                {
                    MessageBox.Show("Please select a valid document.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                            Con_Open();

                    if (tb_Trainer_ID.Text != "" && tb_Name.Text != "" && tb_Address.Text != "" && tb_Mobile_No.TextLength == 10 && tb_Addhar_No.Text != "" && tb_PAN_No.Text != "" && dtp_Joining_Date.Text != "" && cmb_Vehical_Type.Text != "" && tb_Licence_No.Text != "" && cmb_Post.Text != "" && tb_Salary.Text != "" )
                    {
                        SqlCommand Cmd = new SqlCommand();

                        Cmd.Connection = Con;

                        Cmd.CommandText = "Insert Into Add_Trainer Values(@Tid,@Name,@Add,@Mob,@Addhar,@Pan,@DOB,@Vtype,@LNo,@Post,@Salary,'\\Trainer_Document\\" + filename + "')";

                        Cmd.Parameters.Add("Tid", SqlDbType.Int).Value = tb_Trainer_ID.Text;
                        Cmd.Parameters.Add("Name", SqlDbType.NVarChar).Value = tb_Name.Text;
                        Cmd.Parameters.Add("Add", SqlDbType.NVarChar).Value = tb_Address.Text;
                        Cmd.Parameters.Add("Mob", SqlDbType.NVarChar).Value = tb_Mobile_No.Text;
                        Cmd.Parameters.Add("Addhar", SqlDbType.NVarChar).Value = tb_Addhar_No.Text;
                        Cmd.Parameters.Add("Pan", SqlDbType.NVarChar).Value = tb_PAN_No.Text;
                        Cmd.Parameters.Add("DOB", SqlDbType.DateTime).Value = dtp_Joining_Date.Text;
                        Cmd.Parameters.Add("Vtype", SqlDbType.NVarChar).Value = cmb_Vehical_Type.Text;
                        Cmd.Parameters.Add("LNo", SqlDbType.NVarChar).Value = tb_Licence_No.Text;
                        Cmd.Parameters.Add("Post", SqlDbType.NVarChar).Value = cmb_Post.Text;
                        Cmd.Parameters.Add("Salary", SqlDbType.NVarChar).Value = tb_Salary.Text;

                        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                        File.Copy(openFileDialog1.FileName, path + "\\Trainer_Document\\" + filename);

                        Cmd.ExecuteNonQuery();

                        MessageBox.Show("Trainer Registration Save Successfully", "SAVED SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb_Trainer_ID.Clear();
                        Clear();
                        Auto_Incr();
                    }
                    else
                    {
                        MessageBox.Show("First Fill All Fields", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    Con_Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
