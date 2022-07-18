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
    public partial class frm_Single_Fee_Details : Form
    {
        public frm_Single_Fee_Details()
        {
            InitializeComponent();
        }

        int i, j, k;

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

            Cmd.CommandText = "Select Count(Fee_ID) From Fee_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;

                Cmd.CommandText = "Select Max(Fee_ID) From Fee_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            }
            else
            {
                Cnt = 100;
            }

            tb_Fee_ID.Text = Convert.ToString(Cnt + 1);

            Con_Close();
        }
        #endregion

        #region Clear

        void Clear()
        {
            tb_Student_ID.Clear();
            tb_Name.Clear();
            tb_Unpaid_fee.Clear();
            tb_Mobile_No.Clear();
            tb_Current_Fees.Clear();
            tb_Paid_Fee.Clear();
            tb_Total_fee.Clear();
            tb_Student_ID.Focus();
            tb_Student_ID.Enabled = true;
            pb_Search_Student_ID.Enabled = true;
            dgv_fee_add_details.DataSource = null;
        }
        #endregion

        #region Data Griade View Bind

        void Data_Griade_View_Bind(string Quary)
        {
            Con_Open();

            dgv_fee_add_details.DataSource = "";

            SqlDataAdapter SDA = new SqlDataAdapter(Quary, Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_fee_add_details.DataSource = dt;

            Con_Close();
        }
        #endregion

        #region Search

        private void pb_Search_Student_ID_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Student_ID.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Select * from Fee_Details where Student_ID = '" + tb_Student_ID.Text + "'", Con);

                SqlDataReader Dr = Cmd.ExecuteReader();

                if(Dr.Read())
                {
                    tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                    tb_Mobile_No.Text = (Dr["Mobile_No"].ToString());
                    tb_Paid_Fee.Text = (Dr["Paid_Fee"].ToString());
                    tb_Unpaid_fee.Text = (Dr["Unpaid_Fee"].ToString());
                    tb_Total_fee.Text = (Dr["Total_Fee"].ToString());

                    Con_Close();

                    Con_Open();
                    Data_Griade_View_Bind("Select * From Student_Course_Details_dgv where Student_ID = '" + tb_Student_ID.Text + "'");

                }
                else
                {
                    MessageBox.Show("Invalid Student ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Student_ID.Clear();
                }
                k = Convert.ToInt32(tb_Unpaid_fee.Text);
                i = Convert.ToInt32(tb_Paid_Fee.Text);
            }
            else
            {
                MessageBox.Show("First Fill Student ID", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }
        #endregion

        private void frm_Single_Fee_Details_Load(object sender, EventArgs e)
        {
            Auto_Incr();
        }

        #region Save

        private void btn_Save_Print_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Student_ID.Text != "" && tb_Current_Fees.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Insert Into Fee_Details Values(@fee,@Sid,@Name,@Mno,@date,@Pfee,@Ufee,@Tfee)", Con);

                cmd.Parameters.Add("fee", SqlDbType.Int).Value = tb_Fee_ID.Text;
                cmd.Parameters.Add("Sid", SqlDbType.Int).Value = tb_Student_ID.Text;
                cmd.Parameters.Add("Name", SqlDbType.NVarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("Mno", SqlDbType.NVarChar).Value = tb_Mobile_No.Text;
                cmd.Parameters.Add("date", SqlDbType.DateTime).Value = dtp_date.Text;
                cmd.Parameters.Add("Pfee", SqlDbType.NVarChar).Value = tb_Paid_Fee.Text;
                cmd.Parameters.Add("Ufee", SqlDbType.NVarChar).Value = tb_Unpaid_fee.Text;
                cmd.Parameters.Add("Tfee", SqlDbType.NVarChar).Value = tb_Total_fee.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Fee Add Sucssesfull", "Sucsses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Con_Close();

                #region report

                Reports_From.frm_rep_Single_Student_Details f1 = new Reports_From.frm_rep_Single_Student_Details();
                f1.Show();

                Con_Open();
                SqlCommand Scmd = new SqlCommand("Select * from Fee_Details where Student_ID = '" + tb_Student_ID.Text + "'", Con);
                SqlDataAdapter sda = new SqlDataAdapter(Scmd);
                DataSet ds = new DataSet();
                sda.Fill(ds, "Fee_Details");
                Report.cryrep_Single_Student_Fee crl = new Report.cryrep_Single_Student_Fee();
                crl.SetDataSource(ds);
                f1.crv_singal_Student_Fee.ReportSource = crl;
                f1.crv_singal_Student_Fee.Refresh();

                #endregion

                Clear();
                Auto_Incr();

            }
            else
            {
                MessageBox.Show("Please Fill Information", "FillAll", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        #endregion


        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        #region Current_Fees_TextChanged

        private void tb_Current_Fees_TextChanged(object sender, EventArgs e)
        {
            if (tb_Current_Fees.Text == "")
            {
                tb_Current_Fees.Text = "";
            }
            else
            {
                j = Convert.ToInt32(tb_Current_Fees.Text);
            }
            tb_Paid_Fee.Text = Convert.ToString(j);
            tb_Unpaid_fee.Text = Convert.ToString(k - j);
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

        private void tb_Unpaid_fee_TextChanged(object sender, EventArgs e)
        {

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
