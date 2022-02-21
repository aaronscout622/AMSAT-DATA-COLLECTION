namespace CubesatProject
{
    partial class faqsPage
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
            this.faqsBackground = new System.Windows.Forms.Panel();
            this.faqsLabel = new System.Windows.Forms.Label();
            this.faqsBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // faqsBackground
            // 
            this.faqsBackground.Controls.Add(this.faqsLabel);
            this.faqsBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.faqsBackground.Location = new System.Drawing.Point(0, 0);
            this.faqsBackground.Name = "faqsBackground";
            this.faqsBackground.Size = new System.Drawing.Size(2327, 1376);
            this.faqsBackground.TabIndex = 0;
            // 
            // faqsLabel
            // 
            this.faqsLabel.AutoSize = true;
            this.faqsLabel.Font = new System.Drawing.Font("Segoe UI", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.faqsLabel.Location = new System.Drawing.Point(990, 70);
            this.faqsLabel.Name = "faqsLabel";
            this.faqsLabel.Size = new System.Drawing.Size(220, 100);
            this.faqsLabel.TabIndex = 0;
            this.faqsLabel.Text = "FAQS";
            // 
            // faqsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.faqsBackground);
            this.Name = "faqsPage";
            this.Size = new System.Drawing.Size(2327, 1376);
            this.faqsBackground.ResumeLayout(false);
            this.faqsBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public Panel faqsBackground;
        public Label faqsLabel;
    }
}
