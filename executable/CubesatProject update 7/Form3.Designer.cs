namespace CubesatProject
{
    partial class settingsPage
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
            this.ChangeEmail = new System.Windows.Forms.Label();
            this.darkModeLabel = new System.Windows.Forms.Label();
            this.ChangePassword = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.darkButton = new System.Windows.Forms.RadioButton();
            this.lightButton = new System.Windows.Forms.RadioButton();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.settingsBackgroundPanel = new System.Windows.Forms.Panel();
            this.passwordChange1 = new CubesatProject.passwordChange();
            this.emailChange1 = new CubesatProject.emailChange();
            this.settingsBackgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChangeEmail
            // 
            this.ChangeEmail.AutoSize = true;
            this.ChangeEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.ChangeEmail.Location = new System.Drawing.Point(61, 167);
            this.ChangeEmail.Name = "ChangeEmail";
            this.ChangeEmail.Size = new System.Drawing.Size(160, 32);
            this.ChangeEmail.TabIndex = 0;
            this.ChangeEmail.Text = "Change Email";
            this.ChangeEmail.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // darkModeLabel
            // 
            this.darkModeLabel.AutoSize = true;
            this.darkModeLabel.Location = new System.Drawing.Point(61, 73);
            this.darkModeLabel.Name = "darkModeLabel";
            this.darkModeLabel.Size = new System.Drawing.Size(183, 32);
            this.darkModeLabel.TabIndex = 1;
            this.darkModeLabel.Text = "Dark/Light View";
            this.darkModeLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ChangePassword
            // 
            this.ChangePassword.AutoSize = true;
            this.ChangePassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.ChangePassword.Location = new System.Drawing.Point(61, 232);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(200, 32);
            this.ChangePassword.TabIndex = 1;
            this.ChangePassword.Text = "Change Password";
            this.ChangePassword.Click += new System.EventHandler(this.ChangePassword_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.emailLabel.Location = new System.Drawing.Point(370, 167);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(118, 32);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "UserEmail";
            this.emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // darkButton
            // 
            this.darkButton.AutoSize = true;
            this.darkButton.Location = new System.Drawing.Point(250, 73);
            this.darkButton.Name = "darkButton";
            this.darkButton.Size = new System.Drawing.Size(94, 36);
            this.darkButton.TabIndex = 3;
            this.darkButton.Text = "Dark";
            this.darkButton.UseVisualStyleBackColor = true;
            this.darkButton.CheckedChanged += new System.EventHandler(this.darkButton_CheckedChanged);
            // 
            // lightButton
            // 
            this.lightButton.AutoSize = true;
            this.lightButton.Checked = true;
            this.lightButton.Location = new System.Drawing.Point(390, 73);
            this.lightButton.Name = "lightButton";
            this.lightButton.Size = new System.Drawing.Size(98, 36);
            this.lightButton.TabIndex = 2;
            this.lightButton.TabStop = true;
            this.lightButton.Text = "Light";
            this.lightButton.UseVisualStyleBackColor = true;
            this.lightButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Location = new System.Drawing.Point(299, 25);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(100, 32);
            this.settingsLabel.TabIndex = 0;
            this.settingsLabel.Text = "Settings";
            this.settingsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // settingsBackgroundPanel
            // 
            this.settingsBackgroundPanel.Controls.Add(this.passwordChange1);
            this.settingsBackgroundPanel.Controls.Add(this.emailChange1);
            this.settingsBackgroundPanel.Controls.Add(this.settingsLabel);
            this.settingsBackgroundPanel.Controls.Add(this.lightButton);
            this.settingsBackgroundPanel.Controls.Add(this.darkButton);
            this.settingsBackgroundPanel.Controls.Add(this.emailLabel);
            this.settingsBackgroundPanel.Controls.Add(this.ChangePassword);
            this.settingsBackgroundPanel.Controls.Add(this.darkModeLabel);
            this.settingsBackgroundPanel.Controls.Add(this.ChangeEmail);
            this.settingsBackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsBackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsBackgroundPanel.Name = "settingsBackgroundPanel";
            this.settingsBackgroundPanel.Size = new System.Drawing.Size(744, 817);
            this.settingsBackgroundPanel.TabIndex = 4;
            this.settingsBackgroundPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.settingsBackgroundPanel_Paint);
            // 
            // passwordChange1
            // 
            this.passwordChange1.Location = new System.Drawing.Point(-6, 0);
            this.passwordChange1.Name = "passwordChange1";
            this.passwordChange1.Size = new System.Drawing.Size(744, 817);
            this.passwordChange1.TabIndex = 5;
            this.passwordChange1.Visible = false;
            this.passwordChange1.Load += new System.EventHandler(this.passwordChange1_Load);
            // 
            // emailChange1
            // 
            this.emailChange1.AutoSize = true;
            this.emailChange1.Location = new System.Drawing.Point(-6, 3);
            this.emailChange1.Name = "emailChange1";
            this.emailChange1.Size = new System.Drawing.Size(747, 908);
            this.emailChange1.TabIndex = 4;
            this.emailChange1.Visible = false;
            // 
            // settingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 817);
            this.Controls.Add(this.settingsBackgroundPanel);
            this.Name = "settingsPage";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.settingsPage_Load);
            this.settingsBackgroundPanel.ResumeLayout(false);
            this.settingsBackgroundPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label ChangeEmail;
        private Label darkModeLabel;
        private Label ChangePassword;
        private Label emailLabel;
        private RadioButton darkButton;
        private RadioButton lightButton;
        private Label settingsLabel;
        public Panel settingsBackgroundPanel;
        private emailChange emailChange1;
        private passwordChange passwordChange1;
    }
}