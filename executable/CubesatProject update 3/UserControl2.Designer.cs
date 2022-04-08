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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.aboutUsLabel = new System.Windows.Forms.Label();
            this.aboutUsBackground.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aboutUsBackground
            // 
            this.aboutUsBackground.Controls.Add(this.tabControl1);
            this.aboutUsBackground.Controls.Add(this.aboutUsLabel);
            this.aboutUsBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutUsBackground.Location = new System.Drawing.Point(0, 0);
            this.aboutUsBackground.Name = "aboutUsBackground";
            this.aboutUsBackground.Size = new System.Drawing.Size(2325, 1384);
            this.aboutUsBackground.TabIndex = 0;
            this.aboutUsBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.aboutUsBackground_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(552, 153);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1113, 997);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(8, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1097, 943);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Description";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(8, 46);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1097, 943);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Credits";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.aboutUsLabel.Click += new System.EventHandler(this.aboutUsLabel_Click);
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
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TabPage tabPage1;
        private TabPage tabPage2;
        public Panel aboutUsBackground;
        public Label aboutUsLabel;
        public TabControl tabControl1;
    }
}
