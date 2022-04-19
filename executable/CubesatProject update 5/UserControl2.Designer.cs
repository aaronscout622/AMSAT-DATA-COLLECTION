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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutUsPage));
            this.aboutUsBackground = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.clickPicture = new System.Windows.Forms.PictureBox();
            this.learnMoreLabel = new System.Windows.Forms.Label();
            this.aboutUsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aboutUsBackground.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clickPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tabControl1.Location = new System.Drawing.Point(552, 153);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1113, 997);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.descriptionLabel);
            this.tabPage1.Controls.Add(this.clickPicture);
            this.tabPage1.Controls.Add(this.learnMoreLabel);
            this.tabPage1.Location = new System.Drawing.Point(8, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1097, 943);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Description";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.Location = new System.Drawing.Point(25, 43);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(988, 320);
            this.descriptionLabel.TabIndex = 22;
            this.descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            this.descriptionLabel.Click += new System.EventHandler(this.descriptionLabel_Click);
            // 
            // clickPicture
            // 
            this.clickPicture.Image = global::CubesatProject.Properties.Resources.click200;
            this.clickPicture.Location = new System.Drawing.Point(438, 514);
            this.clickPicture.Name = "clickPicture";
            this.clickPicture.Size = new System.Drawing.Size(235, 202);
            this.clickPicture.TabIndex = 21;
            this.clickPicture.TabStop = false;
            this.clickPicture.Click += new System.EventHandler(this.clickPicture_Click);
            // 
            // learnMoreLabel
            // 
            this.learnMoreLabel.AutoSize = true;
            this.learnMoreLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.learnMoreLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.learnMoreLabel.Location = new System.Drawing.Point(141, 435);
            this.learnMoreLabel.Name = "learnMoreLabel";
            this.learnMoreLabel.Size = new System.Drawing.Size(841, 65);
            this.learnMoreLabel.TabIndex = 20;
            this.learnMoreLabel.Text = "Want to learn more about our project?";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(719, 584);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 37);
            this.label1.TabIndex = 23;
            this.label1.Text = "Click Here";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::CubesatProject.Properties.Resources.icons8_left_arrow_641;
            this.pictureBox1.Location = new System.Drawing.Point(719, 616);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 100);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clickPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TabPage tabPage1;
        public Panel aboutUsBackground;
        public Label aboutUsLabel;
        public TabControl tabControl1;
        private PictureBox clickPicture;
        private Label learnMoreLabel;
        private Label descriptionLabel;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
