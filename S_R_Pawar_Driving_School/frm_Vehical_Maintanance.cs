 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace S_R_Pawar_Driving_School
{
    public partial class frm_Vehical_Maintanance : Form
    {
        public frm_Vehical_Maintanance()
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
            tb_Vehical_ID.Clear();
            tb_vehical_No.Clear();
            tb_Name.Clear();
            tb_Model.Clear();
            dtp_Servicing_Date.ResetText();
            tb_Description.Clear();
            tb_Payment.Clear();
            tb_Payment_By.Clear();

            tb_Vehical_ID.Focus();
            tb_Vehical_ID.Enabled = true;
            pb_Search_Vehical_ID.Enabled = true;
        }

        #endregion

        private void frm_Vehical_Maintanance_Load(object sender, EventArgs e)
        {
            tb_Vehical_ID.Focus();
        }

        #region Search

        private void pb_Search_Vehical_ID_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Vehical_ID.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Select Name,Model,Vehicle_No from Add_Vehicle_Details Where Vehicle_ID = '" + tb_Vehical_ID.Text + "' ", Con);

                SqlDataReader Dr = Cmd.ExecuteReader();

                if(Dr.Read())
                {
                    tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                    tb_Model.Text = Dr.GetString(Dr.GetOrdinal("Model"));
                    tb_vehical_No.Text = Dr.GetString(Dr.GetOrdinal("Vehicle_No"));

                    tb_Vehical_ID.Enabled = false;
                    pb_Search_Vehical_ID.Enabled = false;
                }

                else
                {
                    MessageBox.Show("Invalid Vehicle ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Vehical_ID.Clear();
                }
            }
            else
            {
                MessageBox.Show("first Fill Vehicle ID", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }

        #endregion
        
        #region Bill Image Upload

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C://Desktop";

            openFileDialog1.Title = "Select file to be upload.";

            openFileDialog1.Filter = "Select Valid Image((*.jpg;*.png;*)| *.jpg;*.png;";

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
                    MessageBox.Show("Please Upload Image.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    if (tb_Vehical_ID.Text != "" && dtp_Servicing_Date.Text != "" && tb_Description.Text != "" && tb_Payment.Text != "" && tb_Payment_By.Text != "")
                    {
                        SqlCommand Cmd = new SqlCommand();

                        Cmd.Connection = Con;

                        Cmd.CommandText = "Insert into Vehicle_Maintanance Values(@VID,@SDate,@Desc,@Pay,@PayBy,'\\Vehical_Maintanance_Bill_Upload\\" + filename + "')";

                        Cmd.Parameters.Add("VID", SqlDbType.Int).Value = tb_Vehical_ID.Text;
                        Cmd.Parameters.Add("SDate", SqlDbType.Date).Value = dtp_Servicing_Date.Text;
                        Cmd.Parameters.Add("Desc", SqlDbType.NVarChar).Value = tb_Description.Text;
                        Cmd.Parameters.Add("Pay", SqlDbType.NVarChar).Value = tb_Payment.Text;
                        Cmd.Parameters.Add("PayBy", SqlDbType.NVarChar).Value = tb_Payment_By.Text;

                        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                        File.Copy(openFileDialog1.FileName, path + "\\Vehical_Maintanance_Bill_Upload\\" + filename);

                        Cmd.ExecuteNonQuery();

                        MessageBox.Show("Vehicle Maintanance Save Successfully", "SAVED SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb_Vehical_ID.Clear();
                        Clear();
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
