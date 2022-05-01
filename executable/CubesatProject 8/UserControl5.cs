using MySql.Data.MySqlClient;
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
    public partial class passwordChange : UserControl
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=cubesat_login");//Connection for the database
        public string Email;
        settingsPage myParent = null;
        
        public passwordChange()
        {
            InitializeComponent();
        }

        private void passwordChange_Load(object sender, EventArgs e)
        {

        }

        private void confirmPasswordButton_Click(object sender, EventArgs e)
        {
            //Hides any previous error messages
            this.unknownErrorLabel.Visible = false;
            this.nonMatchingPasswordsLabel.Visible = false;
            this.incorrectPassword.Visible = false;
            this.passwordDifferentLabel.Visible = false;
            //Sets parent to current form 
            myParent = (settingsPage)this.Parent;
            Email = myParent.getCurrentEmail();
           
            try
            {
                bool valid = ValidateEmailandPass(Email, this.currentPasswordBox.Text);//Checks if credentials are correct
                if (valid)
                {
                    if (this.newPasswordBox.Text.Equals(this.newPasswordBox2.Text))//Checks if passwords match
                    {
                        if ((this.newPasswordBox.Text.Equals(this.currentPasswordBox.Text)) != true) //checks if password is different from previous
                        {
                            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=cubesat_login");
                            connection.Open();
                            MySqlCommand cmd = connection.CreateCommand();
                            cmd.Parameters.AddWithValue("@pass", this.newPasswordBox.Text);
                            cmd.Parameters.AddWithValue("@email", Email);
                            cmd.CommandText = "UPDATE logins SET Password = @pass WHERE Email = @email";
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Email has been updated!");
                            }
                            else
                            {
                                MessageBox.Show("Password was not updated...");
                            }
                        }
                        else
                        {
                            this.passwordDifferentLabel.Visible = true;
                        }
                        
                    }
                    else
                    {
                        nonMatchingPasswordsLabel.Visible = true;
                    }
                }
                else
                {
                    incorrectPassword.Visible = true;
                }
                    
            }
            catch (Exception ex)
            {
                this.unknownErrorLabel.Visible = true;
            }
    }

        private void returnButton1_Click(object sender, EventArgs e)
        {
            myParent = (settingsPage)this.Parent;
            this.Visible = false;
            myParent.settingsBackgroundPanel.Visible = true;
            this.unknownErrorLabel.Visible = false;
            this.nonMatchingPasswordsLabel.Visible = false;
            this.incorrectPassword.Visible = false;
            this.passwordDifferentLabel.Visible = false;
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

        private void passwordFunctionsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
