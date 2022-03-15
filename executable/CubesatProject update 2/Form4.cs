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
    public partial class registrationForm : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=cubesat_login");
        public registrationForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            loginDatabase data = new loginDatabase();

            String email = emailBox.Text;
            String password = passBox1.Text;
            String passwordcon = passBox2.Text;

            if (passwordcon.Equals(password))
            {
                


                MySqlCommand cmd = new MySqlCommand("INSERT INTO `logins`(`Email`, `Password`) " +
                    "VALUES ( @email, @pass)", data.getConnection());

                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

              

                data.openConnection();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    this.Close();
                }
                   
                data.closeConnection();

            }
            else
            {
                notMatchPass.Visible = true;
            }

           
        }
    }
    
}
