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
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;



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
                if (emailValidation(email) && !AlreadyRegistered(email))
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO `logins`(`Email`, `Password`) " +
                    "VALUES ( @email, @pass)", data.getConnection());

                    cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                    cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;


                    try
                    {
                        data.openConnection();
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            
                            using(SmtpClient client = new SmtpClient("smtp.gmail.com", 587))//Creates smtp client to send confirmation email if successful.
                            {
                                client.EnableSsl = true;
                                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                                client.UseDefaultCredentials = false;
                                client.Credentials = new NetworkCredential("apucubesats2022@gmail.com", "iuyejoxjsueasima");
                                MailMessage msgObj = new MailMessage();
                                msgObj.To.Add(email);
                                msgObj.From = new MailAddress("apucubesats2022@gmail.com");
                                msgObj.Subject = "Registration Confirmation";
                                msgObj.Body = "Your account with the APU Cubesat program has been created! You now have authorized use under this email adress.";
                                client.Send(msgObj);

                            }
                            this.Close();
                        }

                        data.closeConnection();

                    }
                    catch (Exception ex)
                    {
                        UnknownError.Visible = true;
                    }
                }
                else
                {
                    ValidEmail.Visible = true;
                    if (AlreadyRegistered(email))
                    {
                        ValidEmail.Visible = false;
                        registeredEmail.Visible = true;
                    }
                }
            }
            else
            {
                notMatchPass.Visible = true;
            }

        }
        public static bool emailValidation(String email)
        {
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
            
            return emailRegex.IsMatch(email);
        }

        public static bool AlreadyRegistered(String email)
        {
            loginDatabase data = new loginDatabase(); //New login database class


            DataTable table = new DataTable(); //Table for updating database

            MySqlDataAdapter adapter = new MySqlDataAdapter(); //Sql adapter


            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `logins` WHERE `Email` = @email", data.getConnection());

            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;

            adapter.SelectCommand = cmd;

            adapter.Fill(table);




            if (table.Rows.Count != 0) //If email is already registered
            {
                return true;

            }
            else
            {
                return false;
            }
        }

    }
    
}
