namespace CubesatProject
{
    partial class passwordChange
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
            this.returnButton1 = new System.Windows.Forms.Button();
            this.unknownErrorLabel = new System.Windows.Forms.Label();
            this.nonMatchingPasswordsLabel = new System.Windows.Forms.Label();
            this.incorrectPassword = new System.Windows.Forms.Label();
            this.confirmPasswordButton = new System.Windows.Forms.Button();
            this.newPasswordBox = new System.Windows.Forms.TextBox();
            this.newpasswordLabel = new System.Windows.Forms.Label();
            this.currentPassword = new System.Windows.Forms.Label();
            this.currentPasswordBox = new System.Windows.Forms.TextBox();
            this.newPasswordBox2 = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.passwordFunctionsPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // returnButton1
            // 
            this.returnButton1.Location = new System.Drawing.Point(3, 3);
            this.returnButton1.Name = "returnButton1";
            this.returnButton1.Size = new System.Drawing.Size(150, 46);
            this.returnButton1.TabIndex = 18;
            this.returnButton1.Text = "Return";
            this.returnButton1.UseVisualStyleBackColor = true;
            this.returnButton1.Click += new System.EventHandler(this.returnButton1_Click);
            // 
            // unknownErrorLabel
            // 
            this.unknownErrorLabel.AutoSize = true;
            this.unknownErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.unknownErrorLabel.Location = new System.Drawing.Point(217, 636);
            this.unknownErrorLabel.Name = "unknownErrorLabel";
            this.unknownErrorLabel.Size = new System.Drawing.Size(304, 32);
            this.unknownErrorLabel.TabIndex = 17;
            this.unknownErrorLabel.Text = "*Uknown error has occured";
            this.unknownErrorLabel.Visible = false;
            // 
            // nonMatchingPasswordsLabel
            // 
            this.nonMatchingPasswordsLabel.AutoSize = true;
            this.nonMatchingPasswordsLabel.ForeColor = System.Drawing.Color.Red;
            this.nonMatchingPasswordsLabel.Location = new System.Drawing.Point(279, 452);
            this.nonMatchingPasswordsLabel.Name = "nonMatchingPasswordsLabel";
            this.nonMatchingPasswordsLabel.Size = new System.Drawing.Size(282, 32);
            this.nonMatchingPasswordsLabel.TabIndex = 16;
            this.nonMatchingPasswordsLabel.Text = "*Passwords do not match";
            this.nonMatchingPasswordsLabel.Visible = false;
            // 
            // incorrectPassword
            // 
            this.incorrectPassword.AutoSize = true;
            this.incorrectPassword.ForeColor = System.Drawing.Color.Red;
            this.incorrectPassword.Location = new System.Drawing.Point(279, 187);
            this.incorrectPassword.Name = "incorrectPassword";
            this.incorrectPassword.Size = new System.Drawing.Size(221, 32);
            this.incorrectPassword.TabIndex = 15;
            this.incorrectPassword.Text = "*Password incorrect";
            this.incorrectPassword.Visible = false;
            // 
            // confirmPasswordButton
            // 
            this.confirmPasswordButton.Location = new System.Drawing.Point(279, 566);
            this.confirmPasswordButton.Name = "confirmPasswordButton";
            this.confirmPasswordButton.Size = new System.Drawing.Size(150, 46);
            this.confirmPasswordButton.TabIndex = 14;
            this.confirmPasswordButton.Text = "Confirm";
            this.confirmPasswordButton.UseVisualStyleBackColor = true;
            this.confirmPasswordButton.Click += new System.EventHandler(this.confirmPasswordButton_Click);
            // 
            // newPasswordBox
            // 
            this.newPasswordBox.Location = new System.Drawing.Point(279, 267);
            this.newPasswordBox.Name = "newPasswordBox";
            this.newPasswordBox.PasswordChar = '*';
            this.newPasswordBox.Size = new System.Drawing.Size(411, 39);
            this.newPasswordBox.TabIndex = 13;
            this.newPasswordBox.UseSystemPasswordChar = true;
            // 
            // newpasswordLabel
            // 
            this.newpasswordLabel.AutoSize = true;
            this.newpasswordLabel.Location = new System.Drawing.Point(72, 267);
            this.newpasswordLabel.Name = "newpasswordLabel";
            this.newpasswordLabel.Size = new System.Drawing.Size(166, 32);
            this.newpasswordLabel.TabIndex = 12;
            this.newpasswordLabel.Text = "New Password";
            // 
            // currentPassword
            // 
            this.currentPassword.AutoSize = true;
            this.currentPassword.Location = new System.Drawing.Point(40, 145);
            this.currentPassword.Name = "currentPassword";
            this.currentPassword.Size = new System.Drawing.Size(198, 32);
            this.currentPassword.TabIndex = 11;
            this.currentPassword.Text = "Current Password";
            // 
            // currentPasswordBox
            // 
            this.currentPasswordBox.Location = new System.Drawing.Point(279, 145);
            this.currentPasswordBox.Name = "currentPasswordBox";
            this.currentPasswordBox.Size = new System.Drawing.Size(411, 39);
            this.currentPasswordBox.TabIndex = 10;
            // 
            // newPasswordBox2
            // 
            this.newPasswordBox2.Location = new System.Drawing.Point(279, 387);
            this.newPasswordBox2.Name = "newPasswordBox2";
            this.newPasswordBox2.PasswordChar = '*';
            this.newPasswordBox2.Size = new System.Drawing.Size(411, 39);
            this.newPasswordBox2.TabIndex = 20;
            this.newPasswordBox2.UseSystemPasswordChar = true;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(34, 387);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(204, 32);
            this.confirmPasswordLabel.TabIndex = 19;
            this.confirmPasswordLabel.Text = "Confirm Password";
            // 
            // passwordFunctionsPanel
            // 
            this.passwordFunctionsPanel.Location = new System.Drawing.Point(0, 0);
            this.passwordFunctionsPanel.Name = "passwordFunctionsPanel";
            this.passwordFunctionsPanel.Size = new System.Drawing.Size(747, 908);
            this.passwordFunctionsPanel.TabIndex = 21;
            // 
            // passwordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newPasswordBox2);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.returnButton1);
            this.Controls.Add(this.unknownErrorLabel);
            this.Controls.Add(this.nonMatchingPasswordsLabel);
            this.Controls.Add(this.incorrectPassword);
            this.Controls.Add(this.confirmPasswordButton);
            this.Controls.Add(this.newPasswordBox);
            this.Controls.Add(this.newpasswordLabel);
            this.Controls.Add(this.currentPassword);
            this.Controls.Add(this.currentPasswordBox);
            this.Controls.Add(this.passwordFunctionsPanel);
            this.Name = "passwordChange";
            this.Size = new System.Drawing.Size(747, 908);
            this.Load += new System.EventHandler(this.passwordChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button returnButton1;
        private Label unknownErrorLabel;
        private Label nonMatchingPasswordsLabel;
        private Label incorrectPassword;
        private Button confirmPasswordButton;
        private TextBox newPasswordBox;
        private Label newpasswordLabel;
        private Label currentPassword;
        private TextBox currentPasswordBox;
        private TextBox newPasswordBox2;
        private Label confirmPasswordLabel;
        private Panel passwordFunctionsPanel;
    }
}
