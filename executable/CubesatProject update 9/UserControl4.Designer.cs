namespace CubesatProject
{
    partial class emailChange
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.newEmailLabel = new System.Windows.Forms.Label();
            this.passwordEmailBox = new System.Windows.Forms.TextBox();
            this.confirmEmailButton = new System.Windows.Forms.Button();
            this.passwordEmailLabel = new System.Windows.Forms.Label();
            this.incorrectEmailLabel = new System.Windows.Forms.Label();
            this.incorrectPasswordLabel = new System.Windows.Forms.Label();
            this.unknownErrorLabel = new System.Windows.Forms.Label();
            this.returnButton1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.emailDifferentLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 92);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // newEmailLabel
            // 
            this.newEmailLabel.AutoSize = true;
            this.newEmailLabel.Location = new System.Drawing.Point(60, 92);
            this.newEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newEmailLabel.Name = "newEmailLabel";
            this.newEmailLabel.Size = new System.Drawing.Size(66, 15);
            this.newEmailLabel.TabIndex = 1;
            this.newEmailLabel.Text = "New Email ";
            // 
            // passwordEmailBox
            // 
            this.passwordEmailBox.Location = new System.Drawing.Point(149, 172);
            this.passwordEmailBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.passwordEmailBox.Name = "passwordEmailBox";
            this.passwordEmailBox.PasswordChar = '*';
            this.passwordEmailBox.Size = new System.Drawing.Size(223, 23);
            this.passwordEmailBox.TabIndex = 3;
            this.passwordEmailBox.UseSystemPasswordChar = true;
            // 
            // confirmEmailButton
            // 
            this.confirmEmailButton.Location = new System.Drawing.Point(149, 265);
            this.confirmEmailButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.confirmEmailButton.Name = "confirmEmailButton";
            this.confirmEmailButton.Size = new System.Drawing.Size(81, 22);
            this.confirmEmailButton.TabIndex = 4;
            this.confirmEmailButton.Text = "Confirm";
            this.confirmEmailButton.UseVisualStyleBackColor = true;
            this.confirmEmailButton.Click += new System.EventHandler(this.confirmEmailButton_Click);
            // 
            // passwordEmailLabel
            // 
            this.passwordEmailLabel.AutoSize = true;
            this.passwordEmailLabel.Location = new System.Drawing.Point(60, 172);
            this.passwordEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordEmailLabel.Name = "passwordEmailLabel";
            this.passwordEmailLabel.Size = new System.Drawing.Size(57, 15);
            this.passwordEmailLabel.TabIndex = 2;
            this.passwordEmailLabel.Text = "Password";
            // 
            // incorrectEmailLabel
            // 
            this.incorrectEmailLabel.AutoSize = true;
            this.incorrectEmailLabel.ForeColor = System.Drawing.Color.Red;
            this.incorrectEmailLabel.Location = new System.Drawing.Point(149, 116);
            this.incorrectEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.incorrectEmailLabel.Name = "incorrectEmailLabel";
            this.incorrectEmailLabel.Size = new System.Drawing.Size(136, 15);
            this.incorrectEmailLabel.TabIndex = 6;
            this.incorrectEmailLabel.Text = "*Use a valid email adress";
            this.incorrectEmailLabel.Visible = false;
            // 
            // incorrectPasswordLabel
            // 
            this.incorrectPasswordLabel.AutoSize = true;
            this.incorrectPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.incorrectPasswordLabel.Location = new System.Drawing.Point(149, 200);
            this.incorrectPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.incorrectPasswordLabel.Name = "incorrectPasswordLabel";
            this.incorrectPasswordLabel.Size = new System.Drawing.Size(112, 15);
            this.incorrectPasswordLabel.TabIndex = 7;
            this.incorrectPasswordLabel.Text = "*Password incorrect";
            this.incorrectPasswordLabel.Visible = false;
            // 
            // unknownErrorLabel
            // 
            this.unknownErrorLabel.AutoSize = true;
            this.unknownErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.unknownErrorLabel.Location = new System.Drawing.Point(115, 298);
            this.unknownErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.unknownErrorLabel.Name = "unknownErrorLabel";
            this.unknownErrorLabel.Size = new System.Drawing.Size(151, 15);
            this.unknownErrorLabel.TabIndex = 8;
            this.unknownErrorLabel.Text = "*Uknown error has occured";
            this.unknownErrorLabel.Visible = false;
            // 
            // returnButton1
            // 
            this.returnButton1.Location = new System.Drawing.Point(0, 1);
            this.returnButton1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.returnButton1.Name = "returnButton1";
            this.returnButton1.Size = new System.Drawing.Size(81, 22);
            this.returnButton1.TabIndex = 9;
            this.returnButton1.Text = "Return";
            this.returnButton1.UseVisualStyleBackColor = true;
            this.returnButton1.Click += new System.EventHandler(this.returnButton1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.emailDifferentLabel);
            this.panel1.Controls.Add(this.returnButton1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 424);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // emailDifferentLabel
            // 
            this.emailDifferentLabel.AutoSize = true;
            this.emailDifferentLabel.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailDifferentLabel.ForeColor = System.Drawing.Color.Red;
            this.emailDifferentLabel.Location = new System.Drawing.Point(147, 116);
            this.emailDifferentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailDifferentLabel.Name = "emailDifferentLabel";
            this.emailDifferentLabel.Size = new System.Drawing.Size(241, 13);
            this.emailDifferentLabel.TabIndex = 11;
            this.emailDifferentLabel.Text = "*Email adress must be different than previous";
            this.emailDifferentLabel.Visible = false;
            // 
            // emailChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.unknownErrorLabel);
            this.Controls.Add(this.incorrectPasswordLabel);
            this.Controls.Add(this.incorrectEmailLabel);
            this.Controls.Add(this.confirmEmailButton);
            this.Controls.Add(this.passwordEmailBox);
            this.Controls.Add(this.passwordEmailLabel);
            this.Controls.Add(this.newEmailLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "emailChange";
            this.Size = new System.Drawing.Size(403, 426);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label newEmailLabel;
        private TextBox passwordEmailBox;
        private Button confirmEmailButton;
        private Label passwordEmailLabel;
        private Label incorrectEmailLabel;
        private Label incorrectPasswordLabel;
        private Label unknownErrorLabel;
        private Button returnButton1;
        private Panel panel1;
        private Label emailDifferentLabel;
    }
}
