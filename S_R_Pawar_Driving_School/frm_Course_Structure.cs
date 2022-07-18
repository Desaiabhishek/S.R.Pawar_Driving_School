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
    public partial class frm_Course_Structure : Form
    {
        public frm_Course_Structure()
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

            Cmd.CommandText = "Select Count(Course_ID) From Course_Structure";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;

                Cmd.CommandText = "Select Max(Course_ID) From Course_Structure";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            }
            else
            {
                Cnt = 100;
            }

            tb_Course_ID.Text = Convert.ToString(Cnt + 1);

            Con_Close();
        }
        #endregion

        #region Clear

        void Clear()
        {
            tb_Course_Name.Clear();
            cmb_Vehical_Type.SelectedIndex = -1;
            tb_Duration.Clear();
            tb_Licence_Fee.Clear();
            tb_Training_Fee.Clear();
            tb_Other_Details.Clear();

            tb_Course_Name.Focus();
        }

        #endregion

        #region Combo Box Bind

        void Combo_Box_Bind()
        {
            cmb_Vehical_Type.Items.Clear();

            Con.Open();

            SqlCommand Cmd = new SqlCommand("Select Vehicle_Type From Add_Vehicle_Details",Con);

            SqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {

                cmb_Vehical_Type.Items.Add(Dr.GetString(Dr.GetOrdinal("Vehicle_Type")));
            }
            Con.Close();
        }

        #endregion

        #region Data Griade View Bind

        void Data_Griade_View_Bind(string Quary)
        {
            Con.Open();

            dgv_View_All_Course.DataSource = "";

            SqlDataAdapter SDA = new SqlDataAdapter(Quary,Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_View_All_Course.DataSource = dt;

            Con.Close();
        }
        #endregion

        private void frm_Course_Structure_Load(object sender, EventArgs e)
        {
            tb_Course_Name.Focus();
            Auto_Incr();
            Combo_Box_Bind();
            Data_Griade_View_Bind("Select * From Course_Structure");
        }

        #region Save

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }
        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            Con.Open();

            if (tb_Course_ID.Text != "" && tb_Course_Name.Text != "" && cmb_Vehical_Type.Text != "" && tb_Other_Details.Text != "" && tb_Training_Fee.Text != "" && tb_Licence_Fee.Text != "" && tb_Duration.Text != "")
            {
                SqlDataAdapter Sda = new SqlDataAdapter("Insert Into Course_Structure Values('" + tb_Course_ID.Text + "','" + tb_Course_Name.Text + "','" + cmb_Vehical_Type.Text + "','" + tb_Other_Details.Text + "','" + tb_Training_Fee.Text+ "','" + tb_Licence_Fee.Text + "','" + tb_Duration.Text + "')",Con);

                DataTable dt = new DataTable();
                Sda.Fill(dt);

                MessageBox.Show("Course Structure Save Successfully", "SAVED SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Course_ID.Clear();
                Clear();
                Auto_Incr();
                Data_Griade_View_Bind("Select * From Course_Structure");
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

        private void Is_Amount(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }

      
    }
}
