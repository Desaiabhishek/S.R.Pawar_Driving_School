namespace S_R_Pawar_Driving_School
{
    partial class frm_Update_Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Student_ID = new System.Windows.Forms.Label();
            this.tb_Student_ID = new System.Windows.Forms.TextBox();
            this.tb_First_Name = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Update_Student = new System.Windows.Forms.Label();
            this.lbl_First_Name = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Addhar_No = new System.Windows.Forms.Label();
            this.pnl_Bottam = new System.Windows.Forms.Panel();
            this.lbl_PAN_No = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Update = new System.Windows.Forms.Button();
            this.gb_Student_Registration = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pb_Search_Student_ID = new System.Windows.Forms.PictureBox();
            this.lbl_Middle_Name = new System.Windows.Forms.Label();
            this.tb_Middle_Name = new System.Windows.Forms.TextBox();
            this.lbl_Last_Name = new System.Windows.Forms.Label();
            this.tb_Last_Name = new System.Windows.Forms.TextBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.tb_Batch = new System.Windows.Forms.TextBox();
            this.tb_PAN_No = new System.Windows.Forms.TextBox();
            this.tb_Addhar_No = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.gb_Student_Registration.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Search_Student_ID)).BeginInit();
            this.pnl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Student_ID
            // 
            this.lbl_Student_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Student_ID.AutoSize = true;
            this.lbl_Student_ID.Font = new System.Drawing.Font("Century Schoolbook", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Student_ID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Student_ID.Location = new System.Drawing.Point(22, 91);
            this.lbl_Student_ID.Name = "lbl_Student_ID";
            this.lbl_Student_ID.Size = new System.Drawing.Size(208, 33);
            this.lbl_Student_ID.TabIndex = 40;
            this.lbl_Student_ID.Text = "Student ID";
            // 
            // tb_Student_ID
            // 
            this.tb_Student_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Student_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Student_ID.Location = new System.Drawing.Point(236, 92);
            this.tb_Student_ID.MaxLength = 20;
            this.tb_Student_ID.Name = "tb_Student_ID";
            this.tb_Student_ID.Size = new System.Drawing.Size(265, 31);
            this.tb_Student_ID.TabIndex = 0;
            this.tb_Student_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IS_Numeric);
            // 
            // tb_First_Name
            // 
            this.tb_First_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_First_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_First_Name.Location = new System.Drawing.Point(236, 164);
            this.tb_First_Name.MaxLength = 60;
            this.tb_First_Name.Name = "tb_First_Name";
            this.tb_First_Name.Size = new System.Drawing.Size(265, 31);
            this.tb_First_Name.TabIndex = 1;
            this.tb_First_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Is_Letter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.64567F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.33071F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.10236F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Update_Student, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1046, 60);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_Update_Student
            // 
            this.lbl_Update_Student.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Update_Student.AutoSize = true;
            this.lbl_Update_Student.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Update_Student.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Update_Student.Location = new System.Drawing.Point(411, 11);
            this.lbl_Update_Student.Name = "lbl_Update_Student";
            this.lbl_Update_Student.Size = new System.Drawing.Size(260, 38);
            this.lbl_Update_Student.TabIndex = 0;
            this.lbl_Update_Student.Text = "Update Student";
            // 
            // lbl_First_Name
            // 
            this.lbl_First_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_First_Name.AutoSize = true;
            this.lbl_First_Name.Font = new System.Drawing.Font("Century Schoolbook", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_First_Name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_First_Name.Location = new System.Drawing.Point(22, 163);
            this.lbl_First_Name.Name = "lbl_First_Name";
            this.lbl_First_Name.Size = new System.Drawing.Size(208, 33);
            this.lbl_First_Name.TabIndex = 42;
            this.lbl_First_Name.Text = "First Name";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Century Schoolbook", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(549, 91);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(201, 33);
            this.lbl_Mobile_No.TabIndex = 44;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // lbl_Addhar_No
            // 
            this.lbl_Addhar_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Addhar_No.AutoSize = true;
            this.lbl_Addhar_No.Font = new System.Drawing.Font("Century Schoolbook", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Addhar_No.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Addhar_No.Location = new System.Drawing.Point(549, 163);
            this.lbl_Addhar_No.Name = "lbl_Addhar_No";
            this.lbl_Addhar_No.Size = new System.Drawing.Size(201, 33);
            this.lbl_Addhar_No.TabIndex = 45;
            this.lbl_Addhar_No.Text = "Addhar No";
            // 
            // pnl_Bottam
            // 
            this.pnl_Bottam.BackColor = System.Drawing.Color.MediumPurple;
            this.pnl_Bottam.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_Bottam.Location = new System.Drawing.Point(0, 590);
            this.pnl_Bottam.Name = "pnl_Bottam";
            this.pnl_Bottam.Size = new System.Drawing.Size(1050, 30);
            this.pnl_Bottam.TabIndex = 32;
            // 
            // lbl_PAN_No
            // 
            this.lbl_PAN_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PAN_No.AutoSize = true;
            this.lbl_PAN_No.Font = new System.Drawing.Font("Century Schoolbook", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PAN_No.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_PAN_No.Location = new System.Drawing.Point(549, 235);
            this.lbl_PAN_No.Name = "lbl_PAN_No";
            this.lbl_PAN_No.Size = new System.Drawing.Size(201, 33);
            this.lbl_PAN_No.TabIndex = 46;
            this.lbl_PAN_No.Text = "PAN No";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Clear.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Clear.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Clear.Location = new System.Drawing.Point(306, 13);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(127, 45);
            this.btn_Clear.TabIndex = 1;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 7;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.001601F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.37766F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.72777F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.091267F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.41306F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.14162F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.124311F));
            this.tableLayoutPanel4.Controls.Add(this.btn_Clear, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Update, 4, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 517);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1050, 72);
            this.tableLayoutPanel4.TabIndex = 34;
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Update.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Update.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Update.Location = new System.Drawing.Point(614, 13);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(135, 45);
            this.btn_Update.TabIndex = 0;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // gb_Student_Registration
            // 
            this.gb_Student_Registration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Student_Registration.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gb_Student_Registration.Controls.Add(this.tableLayoutPanel3);
            this.gb_Student_Registration.Location = new System.Drawing.Point(0, 60);
            this.gb_Student_Registration.Name = "gb_Student_Registration";
            this.gb_Student_Registration.Size = new System.Drawing.Size(1050, 451);
            this.gb_Student_Registration.TabIndex = 33;
            this.gb_Student_Registration.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.895386F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.42444F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.8657F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.021801F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.76378F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.06299F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.896826F));
            this.tableLayoutPanel3.Controls.Add(this.pb_Search_Student_ID, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.tb_First_Name, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_First_Name, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.tb_Student_ID, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Student_ID, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Middle_Name, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.tb_Middle_Name, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Last_Name, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.tb_Last_Name, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.lbl_time, 4, 4);
            this.tableLayoutPanel3.Controls.Add(this.tb_Batch, 5, 4);
            this.tableLayoutPanel3.Controls.Add(this.lbl_PAN_No, 4, 3);
            this.tableLayoutPanel3.Controls.Add(this.tb_PAN_No, 5, 3);
            this.tableLayoutPanel3.Controls.Add(this.tb_Addhar_No, 5, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Addhar_No, 4, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Mobile_No, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.tb_Mobile_No, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_DOB, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.dtp_DOB, 2, 5);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1, 9);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1049, 436);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // pb_Search_Student_ID
            // 
            this.pb_Search_Student_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_Search_Student_ID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_Search_Student_ID.Image = global::S_R_Pawar_Driving_School.Properties.Resources.search_icon_transparent_19;
            this.pb_Search_Student_ID.Location = new System.Drawing.Point(509, 89);
            this.pb_Search_Student_ID.Name = "pb_Search_Student_ID";
            this.pb_Search_Student_ID.Size = new System.Drawing.Size(31, 38);
            this.pb_Search_Student_ID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Search_Student_ID.TabIndex = 74;
            this.pb_Search_Student_ID.TabStop = false;
            this.pb_Search_Student_ID.Click += new System.EventHandler(this.pb_Search_Student_ID_Click);
            // 
            // lbl_Middle_Name
            // 
            this.lbl_Middle_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Middle_Name.AutoSize = true;
            this.lbl_Middle_Name.Font = new System.Drawing.Font("Century Schoolbook", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Middle_Name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Middle_Name.Location = new System.Drawing.Point(22, 235);
            this.lbl_Middle_Name.Name = "lbl_Middle_Name";
            this.lbl_Middle_Name.Size = new System.Drawing.Size(208, 33);
            this.lbl_Middle_Name.TabIndex = 76;
            this.lbl_Middle_Name.Text = "Middle Name";
            // 
            // tb_Middle_Name
            // 
            this.tb_Middle_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Middle_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Middle_Name.Location = new System.Drawing.Point(236, 236);
            this.tb_Middle_Name.Name = "tb_Middle_Name";
            this.tb_Middle_Name.Size = new System.Drawing.Size(265, 31);
            this.tb_Middle_Name.TabIndex = 2;
            this.tb_Middle_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Is_Letter);
            // 
            // lbl_Last_Name
            // 
            this.lbl_Last_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Last_Name.AutoSize = true;
            this.lbl_Last_Name.Font = new System.Drawing.Font("Century Schoolbook", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Last_Name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Last_Name.Location = new System.Drawing.Point(22, 307);
            this.lbl_Last_Name.Name = "lbl_Last_Name";
            this.lbl_Last_Name.Size = new System.Drawing.Size(208, 33);
            this.lbl_Last_Name.TabIndex = 78;
            this.lbl_Last_Name.Text = "Last Name";
            // 
            // tb_Last_Name
            // 
            this.tb_Last_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Last_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Last_Name.Location = new System.Drawing.Point(236, 308);
            this.tb_Last_Name.MaxLength = 10;
            this.tb_Last_Name.Name = "tb_Last_Name";
            this.tb_Last_Name.Size = new System.Drawing.Size(265, 31);
            this.tb_Last_Name.TabIndex = 3;
            this.tb_Last_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Is_Letter);
            // 
            // lbl_time
            // 
            this.lbl_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Century Schoolbook", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_time.Location = new System.Drawing.Point(549, 307);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(201, 33);
            this.lbl_time.TabIndex = 67;
            this.lbl_time.Text = "Time";
            // 
            // tb_Batch
            // 
            this.tb_Batch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Batch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Batch.Location = new System.Drawing.Point(756, 308);
            this.tb_Batch.MaxLength = 50;
            this.tb_Batch.Name = "tb_Batch";
            this.tb_Batch.Size = new System.Drawing.Size(267, 31);
            this.tb_Batch.TabIndex = 8;
            // 
            // tb_PAN_No
            // 
            this.tb_PAN_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_PAN_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PAN_No.Location = new System.Drawing.Point(756, 236);
            this.tb_PAN_No.MaxLength = 20;
            this.tb_PAN_No.Name = "tb_PAN_No";
            this.tb_PAN_No.Size = new System.Drawing.Size(267, 31);
            this.tb_PAN_No.TabIndex = 7;
            // 
            // tb_Addhar_No
            // 
            this.tb_Addhar_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Addhar_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Addhar_No.Location = new System.Drawing.Point(756, 164);
            this.tb_Addhar_No.MaxLength = 12;
            this.tb_Addhar_No.Name = "tb_Addhar_No";
            this.tb_Addhar_No.Size = new System.Drawing.Size(267, 31);
            this.tb_Addhar_No.TabIndex = 6;
            this.tb_Addhar_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IS_Numeric);
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(756, 92);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(267, 31);
            this.tb_Mobile_No.TabIndex = 5;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IS_Numeric);
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Font = new System.Drawing.Font("Century Schoolbook", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_DOB.Location = new System.Drawing.Point(22, 381);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(208, 33);
            this.lbl_DOB.TabIndex = 80;
            this.lbl_DOB.Text = "DOB";
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_DOB.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(236, 383);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(265, 30);
            this.dtp_DOB.TabIndex = 4;
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.MediumPurple;
            this.pnl_top.Controls.Add(this.tableLayoutPanel1);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1050, 60);
            this.pnl_top.TabIndex = 31;
            // 
            // frm_Update_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1050, 620);
            this.Controls.Add(this.pnl_Bottam);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.gb_Student_Registration);
            this.Controls.Add(this.pnl_top);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Update_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Student";
            this.Load += new System.EventHandler(this.frm_Update_Student_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Is_Letter);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.gb_Student_Registration.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Search_Student_ID)).EndInit();
            this.pnl_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Student_ID;
        private System.Windows.Forms.TextBox tb_Student_ID;
        private System.Windows.Forms.TextBox tb_First_Name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Update_Student;
        private System.Windows.Forms.Label lbl_First_Name;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Addhar_No;
        private System.Windows.Forms.Panel pnl_Bottam;
        private System.Windows.Forms.Label lbl_PAN_No;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.GroupBox gb_Student_Registration;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_Addhar_No;
        private System.Windows.Forms.TextBox tb_PAN_No;
        private System.Windows.Forms.TextBox tb_Batch;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.PictureBox pb_Search_Student_ID;
        private System.Windows.Forms.Label lbl_Middle_Name;
        private System.Windows.Forms.TextBox tb_Middle_Name;
        private System.Windows.Forms.Label lbl_Last_Name;
        private System.Windows.Forms.TextBox tb_Last_Name;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
    }
}