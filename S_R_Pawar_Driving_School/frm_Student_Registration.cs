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
    public partial class frm_Student_Registration : Form
    {
        public frm_Student_Registration()
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

        #region Auto Incr

        void Auto_Incr()
        {
            int Cnt = 0;

            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Count(Student_ID) From Student_Registrion";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;

                Cmd.CommandText = "Select Max(Student_ID) From Student_Registrion";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            }
            else
            {
                Cnt = 1000;
            }

            tb_Student_ID.Text = Convert.ToString(Cnt + 1);

            Con_Close();
        }
        #endregion

        #region Clear

        void Clear()
        {
            tb_First_Name.Clear();
            tb_Mobile_No.Clear();
            tb_Addhar_No.Clear();
            tb_Middle_Name.Clear();
            tb_Last_Name.Clear();
            tb_PAN_No.Clear();
            dtp_Addmission_Date.ResetText();
            dtp_DOB.ResetText();
            tb_Time.Clear();

            tb_First_Name.Focus();

        }
        #endregion

        #region File Upload

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
                        string path = Path.GetFullPath(openFileDialog1.FileName);
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

        private void frm_Student_Registration_Load(object sender, EventArgs e)
        {
            tb_First_Name.Focus();
            Auto_Incr();
        }

        #region Next and Save

        private void btn_Next_Click(object sender, EventArgs e)
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

                    if (tb_Student_ID.Text != "" && tb_First_Name.Text != "" && tb_Middle_Name.Text != "" && tb_Last_Name.Text != "" && tb_Mobile_No.TextLength == 10 && tb_Addhar_No.TextLength == 12 && tb_PAN_No.Text != "" && dtp_Addmission_Date.Text != "" && tb_Time.Text != "" && dtp_DOB.Text != "")
                    {
                        SqlCommand Cmd = new SqlCommand();

                        Cmd.Connection = Con;

                        Cmd.CommandText = "Insert Into Student_Registrion Values(@Sid,@FName,@MName,@LName,@Mob,@Addmi,@Addhar,@Pan,@Time,'\\Student_Document\\" + filename + "',@Dob)";

                        Cmd.Parameters.Add("Sid", SqlDbType.Int).Value = tb_Student_ID.Text;
                        Cmd.Parameters.Add("FName", SqlDbType.NVarChar).Value = tb_First_Name.Text;
                        Cmd.Parameters.Add("MName", SqlDbType.NVarChar).Value = tb_Middle_Name.Text;
                        Cmd.Parameters.Add("LName", SqlDbType.NVarChar).Value = tb_Last_Name.Text;
                        Cmd.Parameters.Add("Mob", SqlDbType.NVarChar).Value = tb_Mobile_No.Text;
                        Cmd.Parameters.Add("Addmi", SqlDbType.DateTime).Value = dtp_Addmission_Date.Text;
                        Cmd.Parameters.Add("Addhar", SqlDbType.NVarChar).Value = tb_Addhar_No.Text;
                        Cmd.Parameters.Add("Pan", SqlDbType.NVarChar).Value = tb_PAN_No.Text;
                        Cmd.Parameters.Add("Time", SqlDbType.NVarChar).Value = tb_Time.Text;
                        Cmd.Parameters.Add("Dob", SqlDbType.DateTime).Value = dtp_DOB.Text;

                        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                        File.Copy(openFileDialog1.FileName, path + "\\Student_Document\\" + filename);

                        Cmd.ExecuteNonQuery();

                        MessageBox.Show("Registration Save Successfully", "SAVED SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        #region background dispose

                        Form formbackground = new Form();
                        try
                        {
                            using (frm_Fees fee = new frm_Fees())
                            {
                                formbackground.StartPosition = FormStartPosition.Manual;
                                formbackground.FormBorderStyle = FormBorderStyle.None;
                                formbackground.Opacity = .70d;
                                formbackground.BackColor = Color.Black;
                                formbackground.WindowState = FormWindowState.Maximized;
                                formbackground.TopMost = true;
                                formbackground.Location = this.Location;
                                formbackground.ShowInTaskbar = false;

                                //formbackground.Show();

                                fee.Owner = formbackground;
                                fee.ShowDialog();

                                formbackground.Dispose();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            formbackground.Dispose();
                        }

                        #endregion

                        tb_Student_ID.Clear();
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

        #region Clear

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        #endregion

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
