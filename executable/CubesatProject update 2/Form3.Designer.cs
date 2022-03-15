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
            this.settingsLabel = new System.Windows.Forms.Label();
            this.darkModeLabel = new System.Windows.Forms.Label();
            this.lightButton = new System.Windows.Forms.RadioButton();
            this.darkButton = new System.Windows.Forms.RadioButton();
            this.settingsBackgroundPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Location = new System.Drawing.Point(301, 25);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(100, 32);
            this.settingsLabel.TabIndex = 0;
            this.settingsLabel.Text = "Settings";
            this.settingsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // darkModeLabel
            // 
            this.darkModeLabel.AutoSize = true;
            this.darkModeLabel.Location = new System.Drawing.Point(45, 75);
            this.darkModeLabel.Name = "darkModeLabel";
            this.darkModeLabel.Size = new System.Drawing.Size(183, 32);
            this.darkModeLabel.TabIndex = 1;
            this.darkModeLabel.Text = "Dark/Light View";
            this.darkModeLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lightButton
            // 
            this.lightButton.AutoSize = true;
            this.lightButton.Checked = true;
            this.lightButton.Location = new System.Drawing.Point(398, 71);
            this.lightButton.Name = "lightButton";
            this.lightButton.Size = new System.Drawing.Size(98, 36);
            this.lightButton.TabIndex = 2;
            this.lightButton.TabStop = true;
            this.lightButton.Text = "Light";
            this.lightButton.UseVisualStyleBackColor = true;
            this.lightButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // darkButton
            // 
            this.darkButton.AutoSize = true;
            this.darkButton.Location = new System.Drawing.Point(257, 73);
            this.darkButton.Name = "darkButton";
            this.darkButton.Size = new System.Drawing.Size(94, 36);
            this.darkButton.TabIndex = 3;
            this.darkButton.Text = "Dark";
            this.darkButton.UseVisualStyleBackColor = true;
            this.darkButton.CheckedChanged += new System.EventHandler(this.darkButton_CheckedChanged);
            // 
            // settingsBackgroundPanel
            // 
            this.settingsBackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsBackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsBackgroundPanel.Name = "settingsBackgroundPanel";
            this.settingsBackgroundPanel.Size = new System.Drawing.Size(800, 450);
            this.settingsBackgroundPanel.TabIndex = 4;
            // 
            // settingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.darkButton);
            this.Controls.Add(this.lightButton);
            this.Controls.Add(this.darkModeLabel);
            this.Controls.Add(this.settingsLabel);
            this.Controls.Add(this.settingsBackgroundPanel);
            this.Name = "settingsPage";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.settingsPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label settingsLabel;
        private Label darkModeLabel;
        private RadioButton lightButton;
        private RadioButton darkButton;
        private Panel settingsBackgroundPanel;
    }
}