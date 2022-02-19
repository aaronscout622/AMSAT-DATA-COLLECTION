namespace CubesatProject
{
    partial class mainUserControl
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
            this.listview = new System.Windows.Forms.ListBox();
            this.dataDisplay = new System.Windows.Forms.TabControl();
            this.ao85Tab = new System.Windows.Forms.TabPage();
            this.ao91Tab = new System.Windows.Forms.TabPage();
            this.ao95Tab = new System.Windows.Forms.TabPage();
            this.ao92Tab = new System.Windows.Forms.TabPage();
            this.fox1eTab = new System.Windows.Forms.TabPage();
            this.ho107Tab = new System.Windows.Forms.TabPage();
            this.golftTab = new System.Windows.Forms.TabPage();
            this.golftCheck = new System.Windows.Forms.CheckBox();
            this.ho107Check = new System.Windows.Forms.CheckBox();
            this.fox1eCheck = new System.Windows.Forms.CheckBox();
            this.ao92Check = new System.Windows.Forms.CheckBox();
            this.ao95Check = new System.Windows.Forms.CheckBox();
            this.ao91Check = new System.Windows.Forms.CheckBox();
            this.ao85Check = new System.Windows.Forms.CheckBox();
            this.mainPageBackground = new System.Windows.Forms.Panel();
            this.controlPanel1 = new System.Windows.Forms.Panel();
            this.dataDisplay.SuspendLayout();
            this.mainPageBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // listview
            // 
            this.listview.AllowDrop = true;
            this.listview.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listview.FormattingEnabled = true;
            this.listview.ItemHeight = 32;
            this.listview.Location = new System.Drawing.Point(3, 3);
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(245, 1380);
            this.listview.TabIndex = 1;
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
            this.dataDisplay.Location = new System.Drawing.Point(584, 71);
            this.dataDisplay.Name = "dataDisplay";
            this.dataDisplay.SelectedIndex = 0;
            this.dataDisplay.Size = new System.Drawing.Size(1160, 1230);
            this.dataDisplay.TabIndex = 8;
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
            // golftCheck
            // 
            this.golftCheck.AutoSize = true;
            this.golftCheck.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.golftCheck.Checked = true;
            this.golftCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.golftCheck.Location = new System.Drawing.Point(27, 399);
            this.golftCheck.Name = "golftCheck";
            this.golftCheck.Size = new System.Drawing.Size(103, 36);
            this.golftCheck.TabIndex = 13;
            this.golftCheck.Text = "GolfT";
            this.golftCheck.UseVisualStyleBackColor = false;
            this.golftCheck.CheckedChanged += new System.EventHandler(this.golftCheck_CheckedChanged);
            // 
            // ho107Check
            // 
            this.ho107Check.AutoSize = true;
            this.ho107Check.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ho107Check.Checked = true;
            this.ho107Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ho107Check.Location = new System.Drawing.Point(27, 344);
            this.ho107Check.Name = "ho107Check";
            this.ho107Check.Size = new System.Drawing.Size(120, 36);
            this.ho107Check.TabIndex = 17;
            this.ho107Check.Text = "HO107";
            this.ho107Check.UseVisualStyleBackColor = false;
            this.ho107Check.CheckedChanged += new System.EventHandler(this.ho107Check_CheckedChanged);
            // 
            // fox1eCheck
            // 
            this.fox1eCheck.AutoSize = true;
            this.fox1eCheck.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.fox1eCheck.Checked = true;
            this.fox1eCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fox1eCheck.Location = new System.Drawing.Point(27, 286);
            this.fox1eCheck.Name = "fox1eCheck";
            this.fox1eCheck.Size = new System.Drawing.Size(108, 36);
            this.fox1eCheck.TabIndex = 16;
            this.fox1eCheck.Text = "Fox1E";
            this.fox1eCheck.UseVisualStyleBackColor = false;
            this.fox1eCheck.CheckedChanged += new System.EventHandler(this.fox1eCheck_CheckedChanged);
            // 
            // ao92Check
            // 
            this.ao92Check.AutoSize = true;
            this.ao92Check.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ao92Check.Checked = true;
            this.ao92Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ao92Check.Location = new System.Drawing.Point(27, 228);
            this.ao92Check.Name = "ao92Check";
            this.ao92Check.Size = new System.Drawing.Size(105, 36);
            this.ao92Check.TabIndex = 15;
            this.ao92Check.Text = "AO92";
            this.ao92Check.UseVisualStyleBackColor = false;
            this.ao92Check.CheckedChanged += new System.EventHandler(this.ao92Check_CheckedChanged);
            // 
            // ao95Check
            // 
            this.ao95Check.AutoSize = true;
            this.ao95Check.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ao95Check.Checked = true;
            this.ao95Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ao95Check.Location = new System.Drawing.Point(27, 173);
            this.ao95Check.Name = "ao95Check";
            this.ao95Check.Size = new System.Drawing.Size(105, 36);
            this.ao95Check.TabIndex = 14;
            this.ao95Check.Text = "AO95";
            this.ao95Check.UseVisualStyleBackColor = false;
            this.ao95Check.CheckedChanged += new System.EventHandler(this.ao95Check_CheckedChanged);
            // 
            // ao91Check
            // 
            this.ao91Check.AutoSize = true;
            this.ao91Check.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ao91Check.Checked = true;
            this.ao91Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ao91Check.Location = new System.Drawing.Point(27, 117);
            this.ao91Check.Name = "ao91Check";
            this.ao91Check.Size = new System.Drawing.Size(105, 36);
            this.ao91Check.TabIndex = 12;
            this.ao91Check.Text = "AO91";
            this.ao91Check.UseVisualStyleBackColor = false;
            this.ao91Check.CheckedChanged += new System.EventHandler(this.ao91Check_CheckedChanged);
            // 
            // ao85Check
            // 
            this.ao85Check.AutoSize = true;
            this.ao85Check.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ao85Check.Checked = true;
            this.ao85Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ao85Check.Location = new System.Drawing.Point(27, 57);
            this.ao85Check.Name = "ao85Check";
            this.ao85Check.Size = new System.Drawing.Size(105, 36);
            this.ao85Check.TabIndex = 11;
            this.ao85Check.Text = "AO85";
            this.ao85Check.UseVisualStyleBackColor = false;
            this.ao85Check.CheckedChanged += new System.EventHandler(this.ao85Check_CheckedChanged);
            // 
            // mainPageBackground
            // 
            this.mainPageBackground.Controls.Add(this.controlPanel1);
            this.mainPageBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPageBackground.Location = new System.Drawing.Point(0, 0);
            this.mainPageBackground.Name = "mainPageBackground";
            this.mainPageBackground.Size = new System.Drawing.Size(2328, 1386);
            this.mainPageBackground.TabIndex = 18;
            // 
            // controlPanel1
            // 
            this.controlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel1.Location = new System.Drawing.Point(0, 0);
            this.controlPanel1.Name = "controlPanel1";
            this.controlPanel1.Size = new System.Drawing.Size(2328, 1386);
            this.controlPanel1.TabIndex = 0;
            this.controlPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.controlPanel1_Paint);
            // 
            // mainUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.golftCheck);
            this.Controls.Add(this.ho107Check);
            this.Controls.Add(this.fox1eCheck);
            this.Controls.Add(this.ao92Check);
            this.Controls.Add(this.ao95Check);
            this.Controls.Add(this.ao91Check);
            this.Controls.Add(this.ao85Check);
            this.Controls.Add(this.dataDisplay);
            this.Controls.Add(this.listview);
            this.Controls.Add(this.mainPageBackground);
            this.Name = "mainUserControl";
            this.Size = new System.Drawing.Size(2328, 1386);
            this.dataDisplay.ResumeLayout(false);
            this.mainPageBackground.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listview;
        public TabControl dataDisplay;
        private TabPage ao85Tab;
        private TabPage ao91Tab;
        private TabPage ao95Tab;
        private TabPage ao92Tab;
        private TabPage fox1eTab;
        private TabPage ho107Tab;
        private TabPage golftTab;
        private CheckBox golftCheck;
        private CheckBox ho107Check;
        private CheckBox fox1eCheck;
        private CheckBox ao92Check;
        private CheckBox ao95Check;
        private CheckBox ao91Check;
        private CheckBox ao85Check;
        private Panel mainPageBackground;
        private Panel controlPanel1;
    }
}
