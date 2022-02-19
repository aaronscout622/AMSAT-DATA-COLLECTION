namespace CubesatProject
{
    partial class aboutUsPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.aboutUsBackground = new System.Windows.Forms.Panel();
            this.aboutUsLabel = new System.Windows.Forms.Label();
            this.aboutUsBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // aboutUsBackground
            // 
            this.aboutUsBackground.Controls.Add(this.aboutUsLabel);
            this.aboutUsBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutUsBackground.Location = new System.Drawing.Point(0, 0);
            this.aboutUsBackground.Name = "aboutUsBackground";
            this.aboutUsBackground.Size = new System.Drawing.Size(2325, 1384);
            this.aboutUsBackground.TabIndex = 0;
            // 
            // aboutUsLabel
            // 
            this.aboutUsLabel.AutoSize = true;
            this.aboutUsLabel.Font = new System.Drawing.Font("Segoe UI", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aboutUsLabel.Location = new System.Drawing.Point(935, 50);
            this.aboutUsLabel.Name = "aboutUsLabel";
            this.aboutUsLabel.Size = new System.Drawing.Size(350, 100);
            this.aboutUsLabel.TabIndex = 0;
            this.aboutUsLabel.Text = "About Us";
            // 
            // aboutUsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.aboutUsBackground);
            this.Name = "aboutUsPage";
            this.Size = new System.Drawing.Size(2325, 1384);
            this.aboutUsBackground.ResumeLayout(false);
            this.aboutUsBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel aboutUsBackground;
        private Label aboutUsLabel;
    }
}
