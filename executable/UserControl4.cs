using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubesatProject
{
    public partial class emailChange : UserControl
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=cubesat_login");//Connection for the database
        public string oldEmail;
        settingsPage myParent = null;

        
        public emailChange()
        {
            InitializeComponent();
        }
      
        private void confirmEmailButton_Click(object sender, EventArgs e)
        {
            //Hides previous error messages
            this.incorrectEmailLabel.Visible = false;
            this.incorrectPasswordLabel.Visible = false;
            this.unknownErrorLabel.Visible = false;
            //Sets parent to form
            myParent = (settingsPage)this.Parent;
            oldEmail = myParent.getCurrentEmail();
            Boolean valid;
            try
            {

                Boolean acceptable = emailValidation(this.textBox1.Text);
                if (acceptable)
                {

                    valid = ValidateEmailandPass(oldEmail, this.passwordEmailBox.Text);
                    if (!valid)
                        this.incorrectPasswordLabel.Visible = true;
                    else
                    {
                        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=cubesat_login");
                        connection.Open();
                        MySqlCommand cmd = connection.CreateCommand();
                        cmd.Parameters.AddWithValue("@email", this.textBox1.Text);
                        cmd.Parameters.AddWithValue("@old", this.oldEmail);
                        cmd.CommandText = "UPDATE logins SET Email = @email WHERE Email = @old";
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            myParent.emailChanger(this.textBox1.Text);
                            MessageBox.Show("Email has been updated!");
                        }
                        else
                        {
                            MessageBox.Show("How'd I get here?");
                        }
                    }

                }
                else
                {
                    incorrectEmailLabel.Visible = true;
                }
             




            }
            catch (Exception ex)
            {
                unknownErrorLabel.Visible = true;
            }
            
            
          

        }

     
        private Boolean ValidateEmailandPass(String someEmail, String passwordVerif)
        {
            loginDatabase data = new loginDatabase(); //New login database class

            String email = someEmail;
            String password = passwordVerif;

            DataTable table = new DataTable(); //Table for updating database

            MySqlDataAdapter adapter = new MySqlDataAdapter(); //Sql adapter


            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `logins` WHERE `Email` = @email and `Password` = @pass", data.getConnection());

            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;


            adapter.SelectCommand = cmd;

            adapter.Fill(table);
            



            if (table.Rows.Count > 0) //If login information is correct
            {
                data.closeConnection();
                return true;

            }
            else
            {   data.closeConnection();
               return false;
            }

        }


        private void returnButton1_Click_1(object sender, EventArgs e)
        {
            myParent = (settingsPage)this.Parent;
            this.Visible = false;
            this.incorrectEmailLabel.Visible = false;
            this.incorrectPasswordLabel.Visible = false;
            this.unknownErrorLabel.Visible = false;
            myParent.settingsBackgroundPanel.Visible = true;
        }

        public static bool emailValidation(String email)
        {
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);

            return emailRegex.IsMatch(email);
        }
    }
}
