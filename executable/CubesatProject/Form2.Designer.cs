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
            this.listview = new System.Windows.Forms.ListBox();
            this.dataDisplay = new System.Windows.Forms.TabControl();
            this.ao85Tab = new System.Windows.Forms.TabPage();
            this.ao91Tab = new System.Windows.Forms.TabPage();
            this.ao95Tab = new System.Windows.Forms.TabPage();
            this.ao92Tab = new System.Windows.Forms.TabPage();
            this.fox1eTab = new System.Windows.Forms.TabPage();
            this.ho107Tab = new System.Windows.Forms.TabPage();
            this.golftTab = new System.Windows.Forms.TabPage();
            this.ao85Check = new System.Windows.Forms.CheckBox();
            this.ao91Check = new System.Windows.Forms.CheckBox();
            this.ao95Check = new System.Windows.Forms.CheckBox();
            this.ao92Check = new System.Windows.Forms.CheckBox();
            this.fox1eCheck = new System.Windows.Forms.CheckBox();
            this.ho107Check = new System.Windows.Forms.CheckBox();
            this.golftCheck = new System.Windows.Forms.CheckBox();
            this.faqsButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.dataDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // listview
            // 
            this.listview.AllowDrop = true;
            this.listview.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listview.FormattingEnabled = true;
            this.listview.ItemHeight = 32;
            this.listview.Location = new System.Drawing.Point(0, 0);
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(245, 1316);
            this.listview.TabIndex = 0;
            // 
            // dataDisplay
            // 
            this.dataDisplay.Controls.Add(this.ao85Tab);
            this.dataDisplay.Controls.Add(this.ao91Tab);
            this.dataDisplay.Controls.Add(this.ao95Tab);
            this.dataDisplay.Controls.Add(this.ao92Tab);
            this.dataDisplay.Controls.Add(this.fox1eTab);
            this.dataDisplay.Controls.Add(this.ho107Tab);
            this.dataDisplay.Controls.Add(this.golftTab);
            this.dataDisplay.Location = new System.Drawing.Point(566, 42);
            this.dataDisplay.Name = "dataDisplay";
            this.dataDisplay.SelectedIndex = 0;
            this.dataDisplay.Size = new System.Drawing.Size(1160, 1230);
            this.dataDisplay.TabIndex = 7;
            // 
            // ao85Tab
            // 
            this.ao85Tab.Location = new System.Drawing.Point(8, 46);
            this.ao85Tab.Name = "ao85Tab";
            this.ao85Tab.Padding = new System.Windows.Forms.Padding(3);
            this.ao85Tab.Size = new System.Drawing.Size(1144, 1176);
            this.ao85Tab.TabIndex = 0;
            this.ao85Tab.Text = "AO85";
            this.ao85Tab.UseVisualStyleBackColor = true;
            // 
            // ao91Tab
            // 
            this.ao91Tab.Location = new System.Drawing.Point(8, 46);
            this.ao91Tab.Name = "ao91Tab";
            this.ao91Tab.Padding = new System.Windows.Forms.Padding(3);
            this.ao91Tab.Size = new System.Drawing.Size(1144, 1176);
            this.ao91Tab.TabIndex = 1;
            this.ao91Tab.Text = "AO91";
            this.ao91Tab.UseVisualStyleBackColor = true;
            // 
            // ao95Tab
            // 
            this.ao95Tab.Location = new System.Drawing.Point(8, 46);
            this.ao95Tab.Name = "ao95Tab";
            this.ao95Tab.Size = new System.Drawing.Size(1144, 1176);
            this.ao95Tab.TabIndex = 2;
            this.ao95Tab.Text = "AO95";
            this.ao95Tab.UseVisualStyleBackColor = true;
            // 
            // ao92Tab
            // 
            this.ao92Tab.Location = new System.Drawing.Point(8, 46);
            this.ao92Tab.Name = "ao92Tab";
            this.ao92Tab.Size = new System.Drawing.Size(1144, 1176);
            this.ao92Tab.TabIndex = 3;
            this.ao92Tab.Text = "AO92";
            this.ao92Tab.UseVisualStyleBackColor = true;
            // 
            // fox1eTab
            // 
            this.fox1eTab.Location = new System.Drawing.Point(8, 46);
            this.fox1eTab.Name = "fox1eTab";
            this.fox1eTab.Size = new System.Drawing.Size(1144, 1176);
            this.fox1eTab.TabIndex = 4;
            this.fox1eTab.Text = "Fox1E";
            this.fox1eTab.UseVisualStyleBackColor = true;
            // 
            // ho107Tab
            // 
            this.ho107Tab.Location = new System.Drawing.Point(8, 46);
            this.ho107Tab.Name = "ho107Tab";
            this.ho107Tab.Size = new System.Drawing.Size(1144, 1176);
            this.ho107Tab.TabIndex = 5;
            this.ho107Tab.Text = "HO107";
            this.ho107Tab.UseVisualStyleBackColor = true;
            // 
            // golftTab
            // 
            this.golftTab.Location = new System.Drawing.Point(8, 46);
            this.golftTab.Name = "golftTab";
            this.golftTab.Size = new System.Drawing.Size(1144, 1176);
            this.golftTab.TabIndex = 6;
            this.golftTab.Text = "GolfT";
            this.golftTab.UseVisualStyleBackColor = true;
            // 
            // ao85Check
            // 
            this.ao85Check.AutoSize = true;
            this.ao85Check.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ao85Check.Checked = true;
            this.ao85Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ao85Check.Location = new System.Drawing.Point(22, 28);
            this.ao85Check.Name = "ao85Check";
            this.ao85Check.Size = new System.Drawing.Size(105, 36);
            this.ao85Check.TabIndex = 5;
            this.ao85Check.Text = "AO85";
            this.ao85Check.UseVisualStyleBackColor = false;
            this.ao85Check.CheckedChanged += new System.EventHandler(this.ao85Check_CheckedChanged);
            // 
            // ao91Check
            // 
            this.ao91Check.AutoSize = true;
            this.ao91Check.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ao91Check.Checked = true;
            this.ao91Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ao91Check.Location = new System.Drawing.Point(22, 88);
            this.ao91Check.Name = "ao91Check";
            this.ao91Check.Size = new System.Drawing.Size(105, 36);
            this.ao91Check.TabIndex = 6;
            this.ao91Check.Text = "AO91";
            this.ao91Check.UseVisualStyleBackColor = false;
            this.ao91Check.CheckedChanged += new System.EventHandler(this.ao91Check_CheckedChanged);
            // 
            // ao95Check
            // 
            this.ao95Check.AutoSize = true;
            this.ao95Check.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ao95Check.Checked = true;
            this.ao95Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ao95Check.Location = new System.Drawing.Point(22, 144);
            this.ao95Check.Name = "ao95Check";
            this.ao95Check.Size = new System.Drawing.Size(105, 36);
            this.ao95Check.TabIndex = 7;
            this.ao95Check.Text = "AO95";
            this.ao95Check.UseVisualStyleBackColor = false;
            this.ao95Check.CheckedChanged += new System.EventHandler(this.ao95Check_CheckedChanged);
            // 
            // ao92Check
            // 
            this.ao92Check.AutoSize = true;
            this.ao92Check.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ao92Check.Checked = true;
            this.ao92Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ao92Check.Location = new System.Drawing.Point(22, 199);
            this.ao92Check.Name = "ao92Check";
            this.ao92Check.Size = new System.Drawing.Size(105, 36);
            this.ao92Check.TabIndex = 8;
            this.ao92Check.Text = "AO92";
            this.ao92Check.UseVisualStyleBackColor = false;
            this.ao92Check.CheckedChanged += new System.EventHandler(this.ao92Check_CheckedChanged);
            // 
            // fox1eCheck
            // 
            this.fox1eCheck.AutoSize = true;
            this.fox1eCheck.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.fox1eCheck.Checked = true;
            this.fox1eCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fox1eCheck.Location = new System.Drawing.Point(22, 257);
            this.fox1eCheck.Name = "fox1eCheck";
            this.fox1eCheck.Size = new System.Drawing.Size(108, 36);
            this.fox1eCheck.TabIndex = 9;
            this.fox1eCheck.Text = "Fox1E";
            this.fox1eCheck.UseVisualStyleBackColor = false;
            this.fox1eCheck.CheckedChanged += new System.EventHandler(this.fox1eCheck_CheckedChanged);
            // 
            // ho107Check
            // 
            this.ho107Check.AutoSize = true;
            this.ho107Check.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ho107Check.Checked = true;
            this.ho107Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ho107Check.Location = new System.Drawing.Point(22, 315);
            this.ho107Check.Name = "ho107Check";
            this.ho107Check.Size = new System.Drawing.Size(120, 36);
            this.ho107Check.TabIndex = 10;
            this.ho107Check.Text = "HO107";
            this.ho107Check.UseVisualStyleBackColor = false;
            this.ho107Check.CheckedChanged += new System.EventHandler(this.ho107Check_CheckedChanged);
            // 
            // golftCheck
            // 
            this.golftCheck.AutoSize = true;
            this.golftCheck.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.golftCheck.Checked = true;
            this.golftCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.golftCheck.Location = new System.Drawing.Point(22, 370);
            this.golftCheck.Name = "golftCheck";
            this.golftCheck.Size = new System.Drawing.Size(103, 36);
            this.golftCheck.TabIndex = 7;
            this.golftCheck.Text = "GolfT";
            this.golftCheck.UseVisualStyleBackColor = false;
            this.golftCheck.CheckedChanged += new System.EventHandler(this.golftCheck_CheckedChanged);
            // 
            // faqsButton
            // 
            this.faqsButton.Location = new System.Drawing.Point(1764, 28);
            this.faqsButton.Name = "faqsButton";
            this.faqsButton.Size = new System.Drawing.Size(130, 152);
            this.faqsButton.TabIndex = 11;
            this.faqsButton.Text = "FAQs";
            this.faqsButton.UseVisualStyleBackColor = true;
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(1900, 28);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(130, 152);
            this.homeButton.TabIndex = 12;
            this.homeButton.Text = "HOME";
            this.homeButton.UseVisualStyleBackColor = true;
            // 
            // profileButton
            // 
            this.profileButton.Location = new System.Drawing.Point(2036, 28);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(130, 152);
            this.profileButton.TabIndex = 13;
            this.profileButton.Text = "PROFILE";
            this.profileButton.UseVisualStyleBackColor = true;
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(2172, 28);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(130, 152);
            this.settingsButton.TabIndex = 14;
            this.settingsButton.Text = "SETTINGS";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2325, 1316);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.faqsButton);
            this.Controls.Add(this.golftCheck);
            this.Controls.Add(this.ho107Check);
            this.Controls.Add(this.fox1eCheck);
            this.Controls.Add(this.ao92Check);
            this.Controls.Add(this.ao95Check);
            this.Controls.Add(this.ao91Check);
            this.Controls.Add(this.ao85Check);
            this.Controls.Add(this.listview);
            this.Controls.Add(this.dataDisplay);
            this.Name = "mainPage";
            this.Text = "CubeSat Project";
            this.Load += new System.EventHandler(this.mainPage_Load);
            this.dataDisplay.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listview;
        private TabPage ao91Tab;
        private CheckBox ao85Check;
        private CheckBox ao91Check;
        private CheckBox ao95Check;
        private CheckBox ao92Check;
        private CheckBox fox1eCheck;
        private CheckBox ho107Check;
        private CheckBox golftCheck;
        private TabPage ao95Tab;
        private TabPage ao92Tab;
        private TabPage fox1eTab;
        private TabPage ho107Tab;
        private TabPage golftTab;
        private TabPage ao85Tab;
        public TabControl dataDisplay;
        private Button faqsButton;
        private Button homeButton;
        private Button profileButton;
        private Button settingsButton;
    }
}