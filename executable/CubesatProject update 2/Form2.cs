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
    public partial class mainPage : Form
    {
  
        public mainPage()
        {
            InitializeComponent();
        
        }

        private void mainPage_Load(object sender, EventArgs e)
        {
            
            
        }

       
        private void button4_Click(object sender, EventArgs e) //Settings Popup
        {
            Form settingspage = new settingsPage(this);
            settingspage.Show();
        }

        private void mainUserControl1_Load(object sender, EventArgs e)
        {
            


        }

        private void aboutUsButton_Click(object sender, EventArgs e)
        {
            //Shows about us page
            aboutUsPage1.Show();
            mainUserControl1.Hide();
            profilePage1.Hide();
            faqsPage1.Hide();
        }

        private void faqsButton_Click(object sender, EventArgs e)
        {
            //Shows faqs page
            aboutUsPage1.Hide();
            mainUserControl1.Hide();
            profilePage1.Hide();
            faqsPage1.Show();

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            //Shows home page
            aboutUsPage1.Hide();
            mainUserControl1.Show();
            profilePage1.Hide();
            faqsPage1.Hide();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            //Shows profile page
            aboutUsPage1.Hide();
            mainUserControl1.Hide();
            profilePage1.Show();
            faqsPage1.Hide();
        }

        private void faqsPage1_Load(object sender, EventArgs e)
        {

        }

        private void aboutUsPage1_Load(object sender, EventArgs e)
        {

        }

        private void profilePage1_Load(object sender, EventArgs e)
        {

        }
    }
}
