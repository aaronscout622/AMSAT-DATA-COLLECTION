namespace CubesatProject
{
    partial class registrationForm
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
            this.registrationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passBox1 = new System.Windows.Forms.TextBox();
            this.passBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ValidEmail = new System.Windows.Forms.Label();
            this.notMatchPass = new System.Windows.Forms.Label();
            this.UnknownError = new System.Windows.Forms.Label();
            this.registeredEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registrationButton
            // 
            this.registrationButton.Location = new System.Drawing.Point(174, 299);
            this.registrationButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(81, 22);
            this.registrationButton.TabIndex = 0;
            this.registrationButton.Text = "Register";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(111, 65);
            this.emailBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(263, 23);
            this.emailBox.TabIndex = 3;
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            // 
            // passBox1
            // 
            this.passBox1.Location = new System.Drawing.Point(111, 143);
            this.passBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.passBox1.Name = "passBox1";
            this.passBox1.PasswordChar = '*';
            this.passBox1.Size = new System.Drawing.Size(263, 23);
            this.passBox1.TabIndex = 4;
            this.passBox1.UseSystemPasswordChar = true;
            // 
            // passBox2
            // 
            this.passBox2.Location = new System.Drawing.Point(111, 213);
            this.passBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.passBox2.Name = "passBox2";
            this.passBox2.PasswordChar = '*';
            this.passBox2.Size = new System.Drawing.Size(263, 23);
            this.passBox2.TabIndex = 6;
            this.passBox2.UseSystemPasswordChar = true;
            this.passBox2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password:";
            // 
            // ValidEmail
            // 
            this.ValidEmail.AutoSize = true;
            this.ValidEmail.ForeColor = System.Drawing.Color.IndianRed;
            this.ValidEmail.Location = new System.Drawing.Point(111, 90);
            this.ValidEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ValidEmail.Name = "ValidEmail";
            this.ValidEmail.Size = new System.Drawing.Size(180, 15);
            this.ValidEmail.TabIndex = 8;
            this.ValidEmail.Text = "*Please enter a valid email adress";
            this.ValidEmail.Visible = false;
            // 
            // notMatchPass
            // 
            this.notMatchPass.AutoSize = true;
            this.notMatchPass.ForeColor = System.Drawing.Color.IndianRed;
            this.notMatchPass.Location = new System.Drawing.Point(111, 243);
            this.notMatchPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.notMatchPass.Name = "notMatchPass";
            this.notMatchPass.Size = new System.Drawing.Size(148, 15);
            this.notMatchPass.TabIndex = 9;
            this.notMatchPass.Text = "*Password does not match";
            this.notMatchPass.Visible = false;
            // 
            // UnknownError
            // 
            this.UnknownError.AutoSize = true;
            this.UnknownError.ForeColor = System.Drawing.Color.IndianRed;
            this.UnknownError.Location = new System.Drawing.Point(131, 332);
            this.UnknownError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UnknownError.Name = "UnknownError";
            this.UnknownError.Size = new System.Drawing.Size(175, 15);
            this.UnknownError.TabIndex = 10;
            this.UnknownError.Text = "*An unknown error has occured";
            this.UnknownError.Visible = false;
            // 
            // registeredEmail
            // 
            this.registeredEmail.AutoSize = true;
            this.registeredEmail.ForeColor = System.Drawing.Color.IndianRed;
            this.registeredEmail.Location = new System.Drawing.Point(111, 90);
            this.registeredEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registeredEmail.Name = "registeredEmail";
            this.registeredEmail.Size = new System.Drawing.Size(228, 15);
            this.registeredEmail.TabIndex = 11;
            this.registeredEmail.Text = "*Email already associated with an account";
            this.registeredEmail.Visible = false;
            // 
            // registrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 272);
            this.Controls.Add(this.registeredEmail);
            this.Controls.Add(this.UnknownError);
            this.Controls.Add(this.notMatchPass);
            this.Controls.Add(this.ValidEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passBox1);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registrationButton);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "registrationForm";
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.registrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button registrationButton;
        private Label label1;
        private Label label2;
        private TextBox emailBox;
        private TextBox passBox1;
        private TextBox passBox2;
        private Label label3;
        private Label label4;
        private Label ValidEmail;
        private Label notMatchPass;
        private Label UnknownError;
        private Label registeredEmail;
    }
}