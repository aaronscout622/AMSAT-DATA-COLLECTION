using MySql.Data.MySqlClient;
using System.Data;

namespace CubesatProject
{
    public partial class LoginPage : Form
    {

        MySqlConnection connection = new MySqlConnection("server=68.119.147.156;port=330;username=root;password=;database=cubesat_login");//Connection for the database
        public LoginPage()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//Temporary bypass
        {

            this.Hide();
            Form mainpage = new mainPage();
            mainpage.Show();

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            loginDatabase data = new loginDatabase(); //New login database class

            String email = emailTextBox.Text;
            String password = passwordTextBox.Text;

            DataTable table = new DataTable(); //Table for updating database

            MySqlDataAdapter adapter = new MySqlDataAdapter(); //Sql adapter
           

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `logins` WHERE `Email` = @email and `Password` = @pass", data.getConnection());

            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            

            adapter.SelectCommand = cmd;

            adapter.Fill(table);

       


            if (table.Rows.Count > 0) //If login information is correct
            {

                Form mainpage = new mainPage(email);//Constructs Main page
                mainpage.Show();
                this.Hide();

            }
            else
            {
                wrongLogin.Visible = true;//Shows error message
            }


        }

         
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form registerPage = new registrationForm();
            registerPage.Show();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}