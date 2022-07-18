namespace S_R_Pawar_Driving_School
{
    partial class frm_Splash_Form
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
            this.components = new System.ComponentModel.Container();
            this.pb_driving_Image = new System.Windows.Forms.PictureBox();
            this.lbl_Application = new System.Windows.Forms.Label();
            this.pb_Loading = new System.Windows.Forms.ProgressBar();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_driving_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_driving_Image
            // 
            this.pb_driving_Image.Image = global::S_R_Pawar_Driving_School.Properties.Resources.BMW;
            this.pb_driving_Image.Location = new System.Drawing.Point(0, 58);
            this.pb_driving_Image.Name = "pb_driving_Image";
            this.pb_driving_Image.Size = new System.Drawing.Size(782, 378);
            this.pb_driving_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_driving_Image.TabIndex = 1;
            this.pb_driving_Image.TabStop = false;
            // 
            // lbl_Application
            // 
            this.lbl_Application.AutoSize = true;
            this.lbl_Application.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Application.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbl_Application.Location = new System.Drawing.Point(136, 9);
            this.lbl_Application.Name = "lbl_Application";
            this.lbl_Application.Size = new System.Drawing.Size(467, 35);
            this.lbl_Application.TabIndex = 2;
            this.lbl_Application.Text = "Driving School Application";
            // 
            // pb_Loading
            // 
            this.pb_Loading.ForeColor = System.Drawing.Color.SpringGreen;
            this.pb_Loading.Location = new System.Drawing.Point(0, 484);
            this.pb_Loading.Name = "pb_Loading";
            this.pb_Loading.Size = new System.Drawing.Size(782, 34);
            this.pb_Loading.Step = 1;
            this.pb_Loading.TabIndex = 9;
            // 
            // lbl_Note
            // 
            this.lbl_Note.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note.ForeColor = System.Drawing.Color.Red;
            this.lbl_Note.Location = new System.Drawing.Point(148, 448);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(232, 24);
            this.lbl_Note.TabIndex = 10;
            this.lbl_Note.Text = "Application Is Loading...";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // frm_Splash_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 518);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.pb_Loading);
            this.Controls.Add(this.lbl_Application);
            this.Controls.Add(this.pb_driving_Image);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frm_Splash_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Splash_Form";
            this.Load += new System.EventHandler(this.frm_Splash_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_driving_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_driving_Image;
        private System.Windows.Forms.Label lbl_Application;
        private System.Windows.Forms.ProgressBar pb_Loading;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}