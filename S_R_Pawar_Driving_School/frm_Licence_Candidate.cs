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
    public partial class frm_Licence_Candidate : Form
    {
        public frm_Licence_Candidate()
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

            Cmd.CommandText = "Select Count(Candidate_ID) From Licence_Candidate";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;

                Cmd.CommandText = "Select Max(Candidate_ID) From Licence_Candidate";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            }
            else
            {
                Cnt = 1000;
            }

            tb_Candidate_ID.Text = Convert.ToString(Cnt + 1);

            Con_Close();
        }
        #endregion

        #region Combo Box Bind

        void Combo_Box_Bind()
        {
            cmb_Vehical_Type.Items.Clear();

            Con.Open();

            SqlCommand Cmd = new SqlCommand("Select Vehicle_Type From Add_Vehicle_Details", Con);

            SqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {

                cmb_Vehical_Type.Items.Add(Dr.GetString(Dr.GetOrdinal("Vehicle_Type")));
            }
            Con.Close();
        }

        #endregion

        #region Clear

        void Clear()
        {
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            tb_Addhar_No.Clear();
            tb_PAN_No.Clear();
            cmb_Vehical_Type.SelectedIndex = -1;

            tb_Name.Focus();
        }
        #endregion

        #region File Upload

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C://Desktop";

            openFileDialog1.Title = "Select file to be upload.";

            openFileDialog1.Filter = "Select Valid Document(*.pdf; *.doc)|*.pdf; *.doc";

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


        private void frm_Licence_Candidate_Load(object sender, EventArgs e)
        {
            tb_Name.Focus();
            Auto_Incr();
            Combo_Box_Bind();
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


        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        #region Save & Next

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

                    if (tb_Candidate_ID.Text != "" && tb_Name.Text != "" && tb_Mobile_No.TextLength == 10 && tb_Addhar_No.TextLength == 12 && tb_PAN_No.Text != "" && cmb_Vehical_Type.Text != "")
                    {
                        SqlCommand cmd = new SqlCommand("Insert Into Licence_Candidate Values('" + tb_Candidate_ID.Text + "','" + tb_Name.Text + "','" + tb_Mobile_No.Text + "','" + tb_Addhar_No.Text + "','" + tb_PAN_No.Text + "','" + cmb_Vehical_Type.Text + "','\\Licence_Candidate_Document\\" + filename + "')", Con);

                        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                        File.Copy(openFileDialog1.FileName, path + "\\Licence_Candidate_Document\\" + filename);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Save Successfully", "SAVED SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Form formbackground = new Form();
                        try
                        {
                            using (frm_License_Fee fee = new frm_License_Fee())
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

                        tb_Candidate_ID.Clear();
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

    }
}