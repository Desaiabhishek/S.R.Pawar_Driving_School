namespace S_R_Pawar_Driving_School.Reports_From
{
    partial class frm_rep_Single_Student_Details
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
            this.crv_singal_Student_Fee = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_singal_Student_Fee
            // 
            this.crv_singal_Student_Fee.ActiveViewIndex = -1;
            this.crv_singal_Student_Fee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_singal_Student_Fee.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_singal_Student_Fee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_singal_Student_Fee.Location = new System.Drawing.Point(0, 0);
            this.crv_singal_Student_Fee.Name = "crv_singal_Student_Fee";
            this.crv_singal_Student_Fee.Size = new System.Drawing.Size(778, 653);
            this.crv_singal_Student_Fee.TabIndex = 0;
            this.crv_singal_Student_Fee.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_rep_Single_Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 653);
            this.Controls.Add(this.crv_singal_Student_Fee);
            this.Name = "frm_rep_Single_Student_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_rep_Single_Student_Details";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crv_singal_Student_Fee;
    }
}