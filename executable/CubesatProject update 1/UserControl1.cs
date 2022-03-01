using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubesatProject
{
    public partial class mainUserControl : UserControl
    {
        public mainUserControl()
        {
            InitializeComponent();
        }

        private void controlPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ao85Check_CheckedChanged(object sender, EventArgs e)
        {
            //Adds/Removes AO85 tab based on whether the box is adding a check or removing one
            if (ao85Check.Checked)
            {
                dataDisplay.TabPages.Add(ao85Tab);
                int tabCount = dataDisplay.TabCount;
                TabPage ao85 = dataDisplay.TabPages[tabCount - 1];  //Uses number of tabs currently in the container to find index of ao85
                ao85.Text = "AO85";

            }
            else
            {
                dataDisplay.TabPages.Remove(ao85Tab);
            }
        }



        private void ao91Check_CheckedChanged(object sender, EventArgs e)
        {
            //Adds/Removes AO91 tab based on whether the box is adding a check or removing one
            if (ao91Check.Checked)
            {
                dataDisplay.TabPages.Add(ao91Tab);
                int tabCount = dataDisplay.TabCount;
                TabPage ao91 = dataDisplay.TabPages[tabCount - 1]; //Uses number of tabs currently in the container to find index of ao91
                ao91.Text = "AO91";

            }
            else
            {
                dataDisplay.TabPages.Remove(ao91Tab);
            }
        }

        private void ao95Check_CheckedChanged(object sender, EventArgs e)
        {
            //Adds/Removes AO95 tab based on whether the box is adding a check or removing one
            if (ao95Check.Checked)
            {
                dataDisplay.TabPages.Add(ao95Tab);
                int tabCount = dataDisplay.TabCount;
                TabPage ao95 = dataDisplay.TabPages[tabCount - 1]; //Uses number of tabs currently in the container to find index of ao95
                ao95.Text = "AO95";

            }
            else
            {
                dataDisplay.TabPages.Remove(ao95Tab);
            }
        }

        private void ao92Check_CheckedChanged(object sender, EventArgs e)
        {
            //Adds/Removes AO92 tab based on whether the box is adding a check or removing one
            if (ao92Check.Checked)
            {
                dataDisplay.TabPages.Add(ao92Tab);
                int tabCount = dataDisplay.TabCount;
                TabPage ao92 = dataDisplay.TabPages[tabCount - 1]; //Uses number of tabs currently in the container to find index of ao92
                ao92.Text = "AO92";

            }
            else
            {
                dataDisplay.TabPages.Remove(ao92Tab);
            }
        }

        private void fox1eCheck_CheckedChanged(object sender, EventArgs e)
        {
            //Adds/Removes Fox1E tab based on whether the box is adding a check or removing one
            if (fox1eCheck.Checked)
            {
                dataDisplay.TabPages.Add(fox1eTab);
                int tabCount = dataDisplay.TabCount;
                TabPage fox1e = dataDisplay.TabPages[tabCount - 1]; //Uses number of tabs currently in the container to find index of Fox1E
                fox1e.Text = "Fox1E";

            }
            else
            {
                dataDisplay.TabPages.Remove(fox1eTab);
            }
        }

        private void ho107Check_CheckedChanged(object sender, EventArgs e)
        {
            //Adds/Removes HO107 tab based on whether the box is adding a check or removing one
            if (ho107Check.Checked)
            {
                dataDisplay.TabPages.Add(ho107Tab);
                int tabCount = dataDisplay.TabCount;
                TabPage ho107 = dataDisplay.TabPages[tabCount - 1]; //Uses number of tabs currently in the container to find index of HO107
                ho107.Text = "HO107";

            }
            else
            {
                dataDisplay.TabPages.Remove(ho107Tab);
            }
        }

        private void golftCheck_CheckedChanged(object sender, EventArgs e)
        {
            //Adds/Removes GolfT tab based on whether the box is adding a check or removing one
            if (golftCheck.Checked)
            {
                dataDisplay.TabPages.Add(golftTab);
                int tabCount = dataDisplay.TabCount;
                TabPage golft = dataDisplay.TabPages[tabCount - 1]; //Uses number of tabs currently in the container to find index of GolfT
                golft.Text = "GolfT";

            }
            else
            {
                dataDisplay.TabPages.Remove(golftTab);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Radio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
