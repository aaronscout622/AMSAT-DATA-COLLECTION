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
        private string email;


        public mainPage()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        public mainPage(string currentemail)
        {
            InitializeComponent();
            this.email = currentemail;
            this.WindowState = FormWindowState.Maximized;
        }
        public void changeEmail(string newemail)
        {
            this.email = newemail;
        }
        private void mainPage_Load(object sender, EventArgs e)
        {
            
            
        }

       
        private void button4_Click(object sender, EventArgs e) //Settings Popup
        {
            Form settingspage = new settingsPage(this, email);
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
           
        }



        private void homeButton_Click(object sender, EventArgs e)
        {
            //Shows home page
            aboutUsPage1.Hide();
            mainUserControl1.Show();
        }


        private void aboutUsPage1_Load(object sender, EventArgs e)
        {

        }

        private void profilePage1_Load(object sender, EventArgs e)
        {

        }
    }
}
