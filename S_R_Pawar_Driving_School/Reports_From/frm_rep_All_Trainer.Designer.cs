namespace S_R_Pawar_Driving_School.Reports_From
{
    partial class frm_rep_All_Trainer
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
            this.crv_All_trainer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_All_trainer
            // 
            this.crv_All_trainer.ActiveViewIndex = -1;
            this.crv_All_trainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_All_trainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_All_trainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_All_trainer.Location = new System.Drawing.Point(0, 0);
            this.crv_All_trainer.Name = "crv_All_trainer";
            this.crv_All_trainer.Size = new System.Drawing.Size(799, 521);
            this.crv_All_trainer.TabIndex = 0;
            this.crv_All_trainer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_rep_All_Trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 521);
            this.Controls.Add(this.crv_All_trainer);
            this.Name = "frm_rep_All_Trainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_rep_All_Trainer";
            this.Load += new System.EventHandler(this.frm_rep_All_Trainer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_All_trainer;
    }
}