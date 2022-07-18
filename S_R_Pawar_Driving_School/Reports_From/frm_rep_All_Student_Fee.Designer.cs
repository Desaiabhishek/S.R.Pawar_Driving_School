namespace S_R_Pawar_Driving_School.Reports_From
{
    partial class frm_rep_All_Student_Fee
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crv_All_Student_Fee = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(803, 461);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // crv_All_Student_Fee
            // 
            this.crv_All_Student_Fee.ActiveViewIndex = -1;
            this.crv_All_Student_Fee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_All_Student_Fee.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_All_Student_Fee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_All_Student_Fee.Location = new System.Drawing.Point(0, 0);
            this.crv_All_Student_Fee.Name = "crv_All_Student_Fee";
            this.crv_All_Student_Fee.Size = new System.Drawing.Size(803, 461);
            this.crv_All_Student_Fee.TabIndex = 1;
            this.crv_All_Student_Fee.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_rep_All_Student_Fee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 461);
            this.Controls.Add(this.crv_All_Student_Fee);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frm_rep_All_Student_Fee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_rep_All_Student_Fee";
            this.Load += new System.EventHandler(this.frm_rep_All_Student_Fee_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_All_Student_Fee;
    }
}