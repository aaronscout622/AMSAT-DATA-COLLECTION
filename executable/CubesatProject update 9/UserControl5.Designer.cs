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
            this.passwordDifferentLabel = new System.Windows.Forms.Label();
            this.passwordFunctionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // returnButton1
            // 
            this.returnButton1.Location = new System.Drawing.Point(2, 1);
            this.returnButton1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.returnButton1.Name = "returnButton1";
            this.returnButton1.Size = new System.Drawing.Size(81, 22);
            this.returnButton1.TabIndex = 18;
            this.returnButton1.Text = "Return";
            this.returnButton1.UseVisualStyleBackColor = true;
            this.returnButton1.Click += new System.EventHandler(this.returnButton1_Click);
            // 
            // unknownErrorLabel
            // 
            this.unknownErrorLabel.AutoSize = true;
            this.unknownErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.unknownErrorLabel.Location = new System.Drawing.Point(117, 298);
            this.unknownErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.unknownErrorLabel.Name = "unknownErrorLabel";
            this.unknownErrorLabel.Size = new System.Drawing.Size(151, 15);
            this.unknownErrorLabel.TabIndex = 17;
            this.unknownErrorLabel.Text = "*Uknown error has occured";
            this.unknownErrorLabel.Visible = false;
            // 
            // nonMatchingPasswordsLabel
            // 
            this.nonMatchingPasswordsLabel.AutoSize = true;
            this.nonMatchingPasswordsLabel.ForeColor = System.Drawing.Color.Red;
            this.nonMatchingPasswordsLabel.Location = new System.Drawing.Point(150, 212);
            this.nonMatchingPasswordsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nonMatchingPasswordsLabel.Name = "nonMatchingPasswordsLabel";
            this.nonMatchingPasswordsLabel.Size = new System.Drawing.Size(142, 15);
            this.nonMatchingPasswordsLabel.TabIndex = 16;
            this.nonMatchingPasswordsLabel.Text = "*Passwords do not match";
            this.nonMatchingPasswordsLabel.Visible = false;
            // 
            // incorrectPassword
            // 
            this.incorrectPassword.AutoSize = true;
            this.incorrectPassword.ForeColor = System.Drawing.Color.Red;
            this.incorrectPassword.Location = new System.Drawing.Point(150, 88);
            this.incorrectPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.incorrectPassword.Name = "incorrectPassword";
            this.incorrectPassword.Size = new System.Drawing.Size(112, 15);
            this.incorrectPassword.TabIndex = 15;
            this.incorrectPassword.Text = "*Password incorrect";
            this.incorrectPassword.Visible = false;
            // 
            // confirmPasswordButton
            // 
            this.confirmPasswordButton.Location = new System.Drawing.Point(150, 265);
            this.confirmPasswordButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.confirmPasswordButton.Name = "confirmPasswordButton";
            this.confirmPasswordButton.Size = new System.Drawing.Size(81, 22);
            this.confirmPasswordButton.TabIndex = 14;
            this.confirmPasswordButton.Text = "Confirm";
            this.confirmPasswordButton.UseVisualStyleBackColor = true;
            this.confirmPasswordButton.Click += new System.EventHandler(this.confirmPasswordButton_Click);
            // 
            // newPasswordBox
            // 
            this.newPasswordBox.Location = new System.Drawing.Point(150, 125);
            this.newPasswordBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.newPasswordBox.Name = "newPasswordBox";
            this.newPasswordBox.PasswordChar = '*';
            this.newPasswordBox.Size = new System.Drawing.Size(223, 23);
            this.newPasswordBox.TabIndex = 13;
            this.newPasswordBox.UseSystemPasswordChar = true;
            // 
            // newpasswordLabel
            // 
            this.newpasswordLabel.AutoSize = true;
            this.newpasswordLabel.Location = new System.Drawing.Point(39, 125);
            this.newpasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newpasswordLabel.Name = "newpasswordLabel";
            this.newpasswordLabel.Size = new System.Drawing.Size(84, 15);
            this.newpasswordLabel.TabIndex = 12;
            this.newpasswordLabel.Text = "New Password";
            // 
            // currentPassword
            // 
            this.currentPassword.AutoSize = true;
            this.currentPassword.Location = new System.Drawing.Point(22, 68);
            this.currentPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentPassword.Name = "currentPassword";
            this.currentPassword.Size = new System.Drawing.Size(100, 15);
            this.currentPassword.TabIndex = 11;
            this.currentPassword.Text = "Current Password";
            // 
            // currentPasswordBox
            // 
            this.currentPasswordBox.Location = new System.Drawing.Point(150, 68);
            this.currentPasswordBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.currentPasswordBox.Name = "currentPasswordBox";
            this.currentPasswordBox.PasswordChar = '*';
            this.currentPasswordBox.Size = new System.Drawing.Size(223, 23);
            this.currentPasswordBox.TabIndex = 10;
            this.currentPasswordBox.UseSystemPasswordChar = true;
            this.currentPasswordBox.TextChanged += new System.EventHandler(this.currentPasswordBox_TextChanged);
            // 
            // newPasswordBox2
            // 
            this.newPasswordBox2.Location = new System.Drawing.Point(150, 181);
            this.newPasswordBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.newPasswordBox2.Name = "newPasswordBox2";
            this.newPasswordBox2.PasswordChar = '*';
            this.newPasswordBox2.Size = new System.Drawing.Size(223, 23);
            this.newPasswordBox2.TabIndex = 20;
            this.newPasswordBox2.UseSystemPasswordChar = true;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(18, 181);
            this.confirmPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(104, 15);
            this.confirmPasswordLabel.TabIndex = 19;
            this.confirmPasswordLabel.Text = "Confirm Password";
            // 
            // passwordFunctionsPanel
            // 
            this.passwordFunctionsPanel.Controls.Add(this.passwordDifferentLabel);
            this.passwordFunctionsPanel.Location = new System.Drawing.Point(0, 0);
            this.passwordFunctionsPanel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.passwordFunctionsPanel.Name = "passwordFunctionsPanel";
            this.passwordFunctionsPanel.Size = new System.Drawing.Size(402, 426);
            this.passwordFunctionsPanel.TabIndex = 21;
            this.passwordFunctionsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.passwordFunctionsPanel_Paint);
            // 
            // passwordDifferentLabel
            // 
            this.passwordDifferentLabel.AutoSize = true;
            this.passwordDifferentLabel.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordDifferentLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordDifferentLabel.Location = new System.Drawing.Point(150, 145);
            this.passwordDifferentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordDifferentLabel.Name = "passwordDifferentLabel";
            this.passwordDifferentLabel.Size = new System.Drawing.Size(236, 13);
            this.passwordDifferentLabel.TabIndex = 22;
            this.passwordDifferentLabel.Text = "*Password must not be the same as previous";
            this.passwordDifferentLabel.Visible = false;
            // 
            // passwordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
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
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "passwordChange";
            this.Size = new System.Drawing.Size(402, 426);
            this.Load += new System.EventHandler(this.passwordChange_Load);
            this.passwordFunctionsPanel.ResumeLayout(false);
            this.passwordFunctionsPanel.PerformLayout();
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
        private Label passwordDifferentLabel;
    }
}
