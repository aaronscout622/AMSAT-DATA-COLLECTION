using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CubesatProject
{
    public partial class settingsPage : Form
    {

        mainPage mainForm = null;
        private String currentEmail;
        //Dictionaries holding color values
        IDictionary<string, Color> lightColorScheme = new Dictionary<string, Color>();
        IDictionary<string, Color> darkColorScheme = new Dictionary<string, Color>();

        public settingsPage()
        {

            InitializeComponent();


        }
        public settingsPage(Form callingForm, string email)
        {

            InitializeComponent();
            mainForm = callingForm as mainPage;  //allows settings page to access main page
            this.currentEmail = email;
            emailLabel.Text = currentEmail; 
            darkColorScheme.Add("Control", SystemColors.Desktop);
            lightColorScheme.Add("Desktop", SystemColors.Control);
            darkColorScheme.Add("ButtonFace", SystemColors.ButtonShadow);
            lightColorScheme.Add("ButtonShadow", SystemColors.ButtonFace);
            darkColorScheme.Add("ScrollBar", SystemColors.MenuText);
            lightColorScheme.Add("MenuText", SystemColors.ScrollBar);
            darkColorScheme.Add("ControlText", SystemColors.HighlightText);
            lightColorScheme.Add("HighlightText", SystemColors.ControlText);
            darkColorScheme.Add("WindowFrame", SystemColors.WindowFrame);
            lightColorScheme.Add("WindowFrame", SystemColors.WindowFrame);
            darkColorScheme.Add("Transparent", SystemColors.Desktop);

            //remove once exception handling is added
            lightColorScheme.Add("Control", SystemColors.Control);
            lightColorScheme.Add("ButtonFace", SystemColors.ButtonFace);
            lightColorScheme.Add("ScrollBar", SystemColors.ScrollBar);
            lightColorScheme.Add("ControlText", SystemColors.ControlText);
            darkColorScheme.Add("Desktop", SystemColors.Desktop);
            darkColorScheme.Add("ButtonShadow", SystemColors.ButtonShadow);
            darkColorScheme.Add("MenuText", SystemColors.MenuText);
            darkColorScheme.Add("HighlightText", SystemColors.HighlightText);
            //remove once exception handling is added

            //Portion not really effective at proper control
            if (mainForm.BackColor != SystemColors.Control)
            {
                lightButton.Checked = false;
                darkButton.Checked = true;
            }
            else
            {
                darkButton.Checked = false;
                lightButton.Checked = true;
            }
            //
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void settingsPage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (lightButton.Checked == true)
            {


                foreach (Control cont in this.Controls) //Loop through settings
                {
                    colorSchemeChanger(cont, "Back", 'L');
                    if (cont is Button || cont is RadioButton || cont is Label)
                    {
                        colorSchemeChanger(cont, "Fore", 'L');
                    }
                }
                foreach (Control cont in mainForm.Controls) //Loop through mainpage
                {

                    colorSchemeChanger(cont, "Back", 'L');
                    if (cont is Button || cont is RadioButton || cont is Label || cont is CheckBox)
                    {
                        colorSchemeChanger(cont, "Fore", 'L');
                    }



                }
                foreach (Control cont in mainForm.mainUserControl1.Controls) //Loop through mainpage for embedded elements
                {
                    string color = "" + cont.ForeColor;
                    color = color.Substring(7, color.Length - 8);

                    colorSchemeChanger(cont, "Back", 'L');
                    if (cont is Button || cont is RadioButton || cont is Label || cont is CheckBox)
                    {
                        colorSchemeChanger(cont, "Fore", 'L');

                    }




                }
                foreach (Control cont in mainForm.aboutUsPage1.Controls) //Loop through about us page
                {
                    colorSchemeChanger(cont, "Back", 'L');
                    if (cont is Button || cont is RadioButton || cont is Label || cont is CheckBox)
                    {
                        colorSchemeChanger(cont, "Fore", 'L');
                    }
                }
                foreach (Control cont in mainForm.faqsPage1.Controls) //Loop through faqs page
                {
                    colorSchemeChanger(cont, "Back", 'L');
                    if (cont is Button || cont is RadioButton || cont is Label || cont is CheckBox)
                    {
                        colorSchemeChanger(cont, "Fore", 'L');
                    }
                }
                foreach (TabPage cont in mainForm.mainUserControl1.dataDisplay.TabPages) //Loop through mainpage tab container
                {


                    colorSchemeChanger(cont, "Back", 'L');
                    colorSchemeChanger(cont, "Fore", 'L');






                }
                foreach (TabPage cont in mainForm.aboutUsPage1.tabControl1.TabPages) //Loop through about us tabs 
                {


                    colorSchemeChanger(cont, "Back", 'L');
                    colorSchemeChanger(cont, "Fore", 'L');






                }
            }
        }

        private void darkButton_CheckedChanged(object sender, EventArgs e) //Changes color scheme to dark version when checked
        {
            if (darkButton.Checked == true)
            {
                foreach (Control cont in mainForm.Controls) //Loop through main page
                {

                    colorSchemeChanger(cont, "Back", 'D');
                    if (cont is Button || cont is RadioButton || cont is Label || cont is CheckBox)
                    {
                        colorSchemeChanger(cont, "Fore", 'D');

                    }


                }

                foreach (Control cont in mainForm.mainUserControl1.Controls) //Loop through embedded elements in main page
                {


                    colorSchemeChanger(cont, "Back", 'D');
                    if (cont is Button || cont is RadioButton || cont is Label || cont is CheckBox)
                    {
                        colorSchemeChanger(cont, "Fore", 'D');

                    }




                }
                foreach (Control cont in mainForm.aboutUsPage1.Controls) //Loop through about us page
                {
                    colorSchemeChanger(cont, "Back", 'D');
                    if (cont is Button || cont is RadioButton || cont is Label || cont is CheckBox)
                    {
                        colorSchemeChanger(cont, "Fore", 'D');
                    }
                }
                foreach (Control cont in mainForm.faqsPage1.Controls) //Loop through faqs page
                {
                    colorSchemeChanger(cont, "Back", 'D');
                    if (cont is Button || cont is RadioButton || cont is Label || cont is CheckBox)
                    {
                        colorSchemeChanger(cont, "Fore", 'D');
                    }
                }

                foreach (Control cont in this.Controls) //Loop through settings
                {
                    colorSchemeChanger(cont, "Back", 'D');
                    if (cont is Button || cont is RadioButton || cont is Label || cont is CheckBox)
                    {
                        colorSchemeChanger(cont, "Fore", 'D');
                    }
                }
                foreach (TabPage cont in mainForm.mainUserControl1.dataDisplay.TabPages) //Loop through mainpage tab container
                {


                    colorSchemeChanger(cont, "Back", 'D');
                    colorSchemeChanger(cont, "Fore", 'D');






                }
                foreach (TabPage cont in mainForm.aboutUsPage1.tabControl1.TabPages) //Loop through about us tabs 
                {


                    colorSchemeChanger(cont, "Back", 'D');
                    colorSchemeChanger(cont, "Fore", 'D');
                }
            }

        }
        public String getCurrentEmail()
        {
            return currentEmail;
        }
        public void emailChanger(String email)
        {
            mainForm.changeEmail(email);
            this.currentEmail = email;
            emailLabel.Text = email;

        }
        private void colorSchemeChanger(Control item, string groundIdentifier, char scheme)
        {
            switch (scheme) //Changes color scheme of program based on the type specified
            {
                case 'L':
                    if (groundIdentifier == "Fore")
                    {
                        string color = "" + item.ForeColor;//Parses current string of color to create a key for the retreieved value
                        color = color.Substring(7, color.Length - 8);
                        item.ForeColor = lightColorScheme[color];




                    }
                    else
                    {
                        string color = "" + item.BackColor;
                        color = color.Substring(7, color.Length - 8);
                        item.BackColor = lightColorScheme[color];


                    }
                    break;
                case 'D':
                    if (groundIdentifier == "Fore")
                    {
                        string color = "" + item.ForeColor;
                        color = color.Substring(7, color.Length - 8);
                        item.ForeColor = darkColorScheme[color];




                    }
                    else
                    {
                        string color = "" + item.BackColor;
                        color = color.Substring(7, color.Length - 8);
                        item.BackColor = darkColorScheme[color];


                    }
                    break;
                default:
                    break;


            }
        }

        private void settingsBackgroundPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {
          
            this.settingsBackgroundPanel.Visible = false;
            emailChange1.Parent = this;
            emailChange1.Visible = true;
        }
        private void passwordLabel_Click(object sender, EventArgs e)
        {
           
        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            this.settingsBackgroundPanel.Visible = false;
            passwordChange1.Parent = this;
            passwordChange1.Visible = true;
        }

        private void passwordChange1_Load(object sender, EventArgs e)
        {

        }
    }
}





