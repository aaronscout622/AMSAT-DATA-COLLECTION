namespace CubesatProject
{
    partial class profilePage
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
            this.profileBackground = new System.Windows.Forms.Panel();
            this.profileLabel = new System.Windows.Forms.Label();
            this.profileBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // profileBackground
            // 
            this.profileBackground.Controls.Add(this.profileLabel);
            this.profileBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileBackground.Location = new System.Drawing.Point(0, 0);
            this.profileBackground.Name = "profileBackground";
            this.profileBackground.Size = new System.Drawing.Size(2328, 1377);
            this.profileBackground.TabIndex = 0;
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.Font = new System.Drawing.Font("Segoe UI", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.profileLabel.Location = new System.Drawing.Point(983, 30);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(252, 100);
            this.profileLabel.TabIndex = 0;
            this.profileLabel.Text = "Profile";
            // 
            // profilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.profileBackground);
            this.Name = "profilePage";
            this.Size = new System.Drawing.Size(2328, 1377);
            this.profileBackground.ResumeLayout(false);
            this.profileBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public Panel profileBackground;
        public Label profileLabel;
    }
}
