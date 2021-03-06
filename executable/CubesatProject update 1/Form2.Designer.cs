namespace CubesatProject
{
    partial class mainPage
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
            this.faqsButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.aboutUsButton = new System.Windows.Forms.Button();
            this.mainUserControl1 = new CubesatProject.mainUserControl();
            this.aboutUsPage1 = new CubesatProject.aboutUsPage();
            this.faqsPage1 = new CubesatProject.faqsPage();
            this.profilePage1 = new CubesatProject.profilePage();
            this.SuspendLayout();
            // 
            // faqsButton
            // 
            this.faqsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.faqsButton.Location = new System.Drawing.Point(1764, 28);
            this.faqsButton.Name = "faqsButton";
            this.faqsButton.Size = new System.Drawing.Size(130, 152);
            this.faqsButton.TabIndex = 11;
            this.faqsButton.Text = "FAQs";
            this.faqsButton.UseVisualStyleBackColor = false;
            this.faqsButton.Click += new System.EventHandler(this.faqsButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.homeButton.Location = new System.Drawing.Point(1900, 28);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(130, 152);
            this.homeButton.TabIndex = 12;
            this.homeButton.Text = "HOME";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.profileButton.Location = new System.Drawing.Point(2036, 28);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(130, 152);
            this.profileButton.TabIndex = 13;
            this.profileButton.Text = "PROFILE";
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.settingsButton.Location = new System.Drawing.Point(2172, 28);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(130, 152);
            this.settingsButton.TabIndex = 14;
            this.settingsButton.Text = "SETTINGS";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // aboutUsButton
            // 
            this.aboutUsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.aboutUsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.aboutUsButton.Location = new System.Drawing.Point(1764, 199);
            this.aboutUsButton.Name = "aboutUsButton";
            this.aboutUsButton.Size = new System.Drawing.Size(130, 152);
            this.aboutUsButton.TabIndex = 15;
            this.aboutUsButton.Text = "ABOUT US";
            this.aboutUsButton.UseVisualStyleBackColor = false;
            this.aboutUsButton.Click += new System.EventHandler(this.aboutUsButton_Click);
            // 
            // mainUserControl1
            // 
            this.mainUserControl1.AutoScroll = true;
            this.mainUserControl1.AutoSize = true;
            this.mainUserControl1.BackColor = System.Drawing.SystemColors.Control;
            this.mainUserControl1.Location = new System.Drawing.Point(0, 0);
            this.mainUserControl1.Name = "mainUserControl1";
            this.mainUserControl1.Size = new System.Drawing.Size(2325, 1386);
            this.mainUserControl1.TabIndex = 16;
            this.mainUserControl1.Load += new System.EventHandler(this.mainUserControl1_Load);
            // 
            // aboutUsPage1
            // 
            this.aboutUsPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutUsPage1.Location = new System.Drawing.Point(0, 0);
            this.aboutUsPage1.Name = "aboutUsPage1";
            this.aboutUsPage1.Size = new System.Drawing.Size(2325, 1316);
            this.aboutUsPage1.TabIndex = 17;
            this.aboutUsPage1.Load += new System.EventHandler(this.aboutUsPage1_Load);
            // 
            // faqsPage1
            // 
            this.faqsPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.faqsPage1.Location = new System.Drawing.Point(0, 0);
            this.faqsPage1.Name = "faqsPage1";
            this.faqsPage1.Size = new System.Drawing.Size(2325, 1316);
            this.faqsPage1.TabIndex = 18;
            this.faqsPage1.Load += new System.EventHandler(this.faqsPage1_Load);
            // 
            // profilePage1
            // 
            this.profilePage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilePage1.Location = new System.Drawing.Point(0, 0);
            this.profilePage1.Name = "profilePage1";
            this.profilePage1.Size = new System.Drawing.Size(2325, 1316);
            this.profilePage1.TabIndex = 19;
            this.profilePage1.Load += new System.EventHandler(this.profilePage1_Load);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2325, 1316);
            this.Controls.Add(this.aboutUsButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.faqsButton);
            this.Controls.Add(this.mainUserControl1);
            this.Controls.Add(this.profilePage1);
            this.Controls.Add(this.faqsPage1);
            this.Controls.Add(this.aboutUsPage1);
            this.Name = "mainPage";
            this.Text = "CubeSat Project";
            this.Load += new System.EventHandler(this.mainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button faqsButton;
        private Button homeButton;
        private Button profileButton;
        private Button settingsButton;
        private Button aboutUsButton;
        public mainUserControl mainUserControl1;
        public aboutUsPage aboutUsPage1;
        public faqsPage faqsPage1;
        public profilePage profilePage1;
    }
}