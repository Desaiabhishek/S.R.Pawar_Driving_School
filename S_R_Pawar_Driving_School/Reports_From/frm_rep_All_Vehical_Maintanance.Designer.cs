namespace S_R_Pawar_Driving_School.Reports_From
{
    partial class frm_rep_All_Vehical_Maintanance
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
            this.crv_all_v_maintanance = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_all_v_maintanance
            // 
            this.crv_all_v_maintanance.ActiveViewIndex = -1;
            this.crv_all_v_maintanance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_all_v_maintanance.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_all_v_maintanance.DisplayStatusBar = false;
            this.crv_all_v_maintanance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_all_v_maintanance.Location = new System.Drawing.Point(0, 0);
            this.crv_all_v_maintanance.Name = "crv_all_v_maintanance";
            this.crv_all_v_maintanance.Size = new System.Drawing.Size(803, 461);
            this.crv_all_v_maintanance.TabIndex = 0;
            this.crv_all_v_maintanance.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_rep_All_Vehical_Maintanance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 461);
            this.Controls.Add(this.crv_all_v_maintanance);
            this.Name = "frm_rep_All_Vehical_Maintanance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_All_Vehical_Maintanance";
            this.Load += new System.EventHandler(this.frm_rep_All_Vehical_Maintanance_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_all_v_maintanance;
    }
}