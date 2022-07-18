
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
    public partial class frm_Fees : Form
    {
        int pCnt = 1;
        double totalfee = 0;

        public frm_Fees()
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
            tb_Mobile_No.Clear();
            tb_Name.Clear();
            tb_Paid_Fee.Clear();
            tb_Unpaid_fee.Clear();
            tb_Total_fee.Clear();
            tb_Student_ID.Clear();
            dtp_date.ResetText();
            cmb_vehical_type.SelectedIndex = -1;
            tb_Fee.Clear();
            dgv_fee_add_details.Rows.Clear();
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

        #region Combo Box Bind

        void Combo_Box_Bind()
        {
            cmb_vehical_type.Items.Clear();

            Con.Open();

            SqlCommand Cmd = new SqlCommand("Select Vehicle_Type From Course_Structure", Con);

            SqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {

                cmb_vehical_type.Items.Add(Dr.GetString(Dr.GetOrdinal("Vehicle_Type")));
            }
            Con.Close();
        }

        #endregion

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Main obj = new frm_Main();
            this.Hide();
            obj.Show();
        }

        #region form load

        private void frm_Fees_Load(object sender, EventArgs e)
        {
            Con_Open();
            SqlCommand cmd = new SqlCommand("Select * From Student_Registrion where Student_ID = (select max(Student_ID) From Student_Registrion)", Con);
            var obj = cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Student_ID.Text = obj["Student_ID"].ToString();
                tb_Mobile_No.Text = obj["Mobile_No"].ToString();
                tb_Name.Text = obj["First_Name"].ToString();
            }
            Con_Close();

            Combo_Box_Bind();
            Auto_Incr();
        }
        #endregion

        private void cmb_vehical_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand("Select Training_Fee + Licence_Fee from Course_Structure where Vehicle_Type = '" + cmb_vehical_type.Text + "'", Con);
            tb_Fee.Text = Convert.ToString(cmd.ExecuteScalar());

            Con_Close();
        }

        #region Add

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(cmb_vehical_type.Text != "" && tb_Fee.Text != "")
            {
                dgv_fee_add_details.Rows.Add(pCnt, cmb_vehical_type.Text, tb_Fee.Text);

                pCnt++;

                totalfee = totalfee + Convert.ToDouble(tb_Fee.Text);
                cmb_vehical_type.SelectedIndex = -1;
                tb_Fee.Clear();

                tb_Total_fee.Text = Convert.ToString(totalfee);
            }
            else
            {
                MessageBox.Show("Please Enter Details", "Please Enter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region paid_fee_textchanged

        private void tb_Paid_Fee_TextChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(tb_Total_fee.Text);
            int j = 0;
            if(tb_Paid_Fee.Text == "")
            {
                tb_Paid_Fee.Text = "0";
            }
            else
            {
                j = Convert.ToInt32(tb_Paid_Fee.Text);
            }
            tb_Total_fee.Text = Convert.ToString(totalfee);
            tb_Unpaid_fee.Text = Convert.ToString(totalfee - j);
        }

        #endregion

        #region Save & print

        private void btn_Save_Print_Click(object sender, EventArgs e)
        {
            if(pCnt > 1 && tb_Paid_Fee.Text != "")
            {
                Con_Open();

                SqlCommand cmd = new SqlCommand("Insert Into Fee_Details Values(@fee,@Sid,@Name,@Mno,@date,@Pfee,@Ufee,@Tfee)",Con);

                cmd.Parameters.Add("fee", SqlDbType.Int).Value = tb_Fee_ID.Text;
                cmd.Parameters.Add("Sid", SqlDbType.Int).Value = tb_Student_ID.Text;
                cmd.Parameters.Add("Name", SqlDbType.NVarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("Mno", SqlDbType.NVarChar).Value = tb_Mobile_No.Text;
                cmd.Parameters.Add("date", SqlDbType.DateTime).Value = dtp_date.Text;
                cmd.Parameters.Add("Pfee", SqlDbType.NVarChar).Value = tb_Paid_Fee.Text;
                cmd.Parameters.Add("Ufee", SqlDbType.NVarChar).Value = tb_Unpaid_fee.Text;
                cmd.Parameters.Add("Tfee", SqlDbType.NVarChar).Value = tb_Total_fee.Text;

                cmd.ExecuteNonQuery();

                cmd.Dispose();

                Con_Close();

                for(int i = 0; i <= dgv_fee_add_details.Rows.Count -1;i++)
                {
                    Con_Open();

                    SqlCommand cmdd = new SqlCommand("Insert Into Student_Course_Details_dgv values('" + tb_Student_ID.Text + "','" + dgv_fee_add_details.Rows[i].Cells[1].Value + "','" + dgv_fee_add_details.Rows[i].Cells[2].Value + "')",Con);

                    cmdd.ExecuteNonQuery();

                    Con_Close();
                }

                MessageBox.Show("Admission Sucssesfull", "Sucsses", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
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

                Con_Close();
                #endregion

                Auto_Incr();
                Clear();

            }
            else
            {
                MessageBox.Show("Please Enter All Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
