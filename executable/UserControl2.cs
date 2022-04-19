using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CubesatProject
{
    public partial class aboutUsPage : UserControl
    {
        public aboutUsPage()
        {
            InitializeComponent();
        }

        private void aboutUsLabel_Click(object sender, EventArgs e)
        {

        }

        private void aboutUsBackground_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void clickPicture_Click(object sender, EventArgs e)
        {
            var uri = "https://github.com/aaronscout622/AMSAT-DATA-COLLECTION";
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = uri
            };
            System.Diagnostics.Process.Start(psi);
        
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
    }
}
