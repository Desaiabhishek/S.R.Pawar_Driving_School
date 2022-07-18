namespace S_R_Pawar_Driving_School
{
    partial class frm_All_Trainer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Trainer_ID = new System.Windows.Forms.Label();
            this.tb_Trainer_ID = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.pnl_Bottam = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_All_Trainer = new System.Windows.Forms.DataGridView();
            this.pb_Trianer_ID_Search = new System.Windows.Forms.PictureBox();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_All_Trainers = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.pb_Name_Search = new System.Windows.Forms.PictureBox();
            this.gb_Search_Trainer = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_All_Trainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Trianer_ID_Search)).BeginInit();
            this.pnl_top.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Name_Search)).BeginInit();
            this.gb_Search_Trainer.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Trainer_ID
            // 
            this.lbl_Trainer_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Trainer_ID.AutoSize = true;
            this.lbl_Trainer_ID.Font = new System.Drawing.Font("Century Schoolbook", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Trainer_ID.Location = new System.Drawing.Point(21, 14);
            this.lbl_Trainer_ID.Name = "lbl_Trainer_ID";
            this.lbl_Trainer_ID.Size = new System.Drawing.Size(157, 33);
            this.lbl_Trainer_ID.TabIndex = 65;
            this.lbl_Trainer_ID.Text = "Trainer ID";
            // 
            // tb_Trainer_ID
            // 
            this.tb_Trainer_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Trainer_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Trainer_ID.Location = new System.Drawing.Point(184, 15);
            this.tb_Trainer_ID.Name = "tb_Trainer_ID";
            this.tb_Trainer_ID.Size = new System.Drawing.Size(203, 31);
            this.tb_Trainer_ID.TabIndex = 0;
            this.tb_Trainer_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IS_Numeric);
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Century Schoolbook", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(473, 14);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(123, 33);
            this.lbl_Name.TabIndex = 66;
            this.lbl_Name.Text = "Name";
            // 
            // pnl_Bottam
            // 
            this.pnl_Bottam.BackColor = System.Drawing.Color.MediumPurple;
            this.pnl_Bottam.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_Bottam.Location = new System.Drawing.Point(0, 595);
            this.pnl_Bottam.Name = "pnl_Bottam";
            this.pnl_Bottam.Size = new System.Drawing.Size(1050, 25);
            this.pnl_Bottam.TabIndex = 77;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.dgv_All_Trainer, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 182);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1047, 407);
            this.tableLayoutPanel3.TabIndex = 76;
            // 
            // dgv_All_Trainer
            // 
            this.dgv_All_Trainer.AllowUserToAddRows = false;
            this.dgv_All_Trainer.AllowUserToDeleteRows = false;
            this.dgv_All_Trainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_All_Trainer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_All_Trainer.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_All_Trainer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_All_Trainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_All_Trainer.Enabled = false;
            this.dgv_All_Trainer.Location = new System.Drawing.Point(3, 3);
            this.dgv_All_Trainer.Name = "dgv_All_Trainer";
            this.dgv_All_Trainer.ReadOnly = true;
            this.dgv_All_Trainer.Size = new System.Drawing.Size(1041, 401);
            this.dgv_All_Trainer.TabIndex = 0;
            // 
            // pb_Trianer_ID_Search
            // 
            this.pb_Trianer_ID_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_Trianer_ID_Search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_Trianer_ID_Search.Image = global::S_R_Pawar_Driving_School.Properties.Resources.search_icon_transparent_19;
            this.pb_Trianer_ID_Search.Location = new System.Drawing.Point(400, 13);
            this.pb_Trianer_ID_Search.Name = "pb_Trianer_ID_Search";
            this.pb_Trianer_ID_Search.Size = new System.Drawing.Size(35, 35);
            this.pb_Trianer_ID_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Trianer_ID_Search.TabIndex = 73;
            this.pb_Trianer_ID_Search.TabStop = false;
            this.pb_Trianer_ID_Search.Click += new System.EventHandler(this.pb_Trianer_ID_Search_Click);
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.MediumPurple;
            this.pnl_top.Controls.Add(this.tableLayoutPanel1);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1050, 60);
            this.pnl_top.TabIndex = 74;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.64567F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.33071F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.10236F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_All_Trainers, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1050, 60);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lbl_All_Trainers
            // 
            this.lbl_All_Trainers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_All_Trainers.AutoSize = true;
            this.lbl_All_Trainers.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_All_Trainers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_All_Trainers.Location = new System.Drawing.Point(433, 11);
            this.lbl_All_Trainers.Name = "lbl_All_Trainers";
            this.lbl_All_Trainers.Size = new System.Drawing.Size(220, 38);
            this.lbl_All_Trainers.TabIndex = 0;
            this.lbl_All_Trainers.Text = "All Trainers";
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(602, 15);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(176, 31);
            this.tb_Name.TabIndex = 1;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Is_Letter);
            // 
            // pb_Name_Search
            // 
            this.pb_Name_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_Name_Search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_Name_Search.Image = global::S_R_Pawar_Driving_School.Properties.Resources.search_icon_transparent_19;
            this.pb_Name_Search.Location = new System.Drawing.Point(789, 13);
            this.pb_Name_Search.Name = "pb_Name_Search";
            this.pb_Name_Search.Size = new System.Drawing.Size(35, 35);
            this.pb_Name_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Name_Search.TabIndex = 74;
            this.pb_Name_Search.TabStop = false;
            this.pb_Name_Search.Click += new System.EventHandler(this.pb_Name_Search_Click);
            // 
            // gb_Search_Trainer
            // 
            this.gb_Search_Trainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Search_Trainer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gb_Search_Trainer.Controls.Add(this.tableLayoutPanel2);
            this.gb_Search_Trainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Search_Trainer.Location = new System.Drawing.Point(0, 66);
            this.gb_Search_Trainer.Name = "gb_Search_Trainer";
            this.gb_Search_Trainer.Size = new System.Drawing.Size(1050, 91);
            this.gb_Search_Trainer.TabIndex = 75;
            this.gb_Search_Trainer.TabStop = false;
            this.gb_Search_Trainer.Text = "Search Trainer";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 11;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.803476F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.61303F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.01916F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.363985F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.298851F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.35632F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.43295F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.980843F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.490422F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.42146F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.93412F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Clear, 9, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Trainer_ID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_Trainer_ID, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Name, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_Name, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.pb_Trianer_ID_Search, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.pb_Name_Search, 7, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1044, 62);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Clear.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Clear.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Clear.Location = new System.Drawing.Point(887, 13);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(104, 36);
            this.btn_Clear.TabIndex = 75;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.MediumPurple;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 163);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1050, 8);
            this.tableLayoutPanel6.TabIndex = 87;
            // 
            // frm_All_Trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1050, 620);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.pnl_Bottam);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.gb_Search_Trainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_All_Trainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Trainer";
            this.Load += new System.EventHandler(this.frm_All_Trainer_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_All_Trainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Trianer_ID_Search)).EndInit();
            this.pnl_top.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Name_Search)).EndInit();
            this.gb_Search_Trainer.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Trainer_ID;
        private System.Windows.Forms.TextBox tb_Trainer_ID;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Panel pnl_Bottam;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dgv_All_Trainer;
        private System.Windows.Forms.PictureBox pb_Trianer_ID_Search;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_All_Trainers;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.PictureBox pb_Name_Search;
        private System.Windows.Forms.GroupBox gb_Search_Trainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    }
}