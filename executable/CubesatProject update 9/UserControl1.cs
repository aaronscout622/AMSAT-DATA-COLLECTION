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
  
    public partial class mainUserControl : UserControl
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=53DRP5rMjUp0;SslMode=None");
        MySqlDataAdapter adapter;
        DataTable table = new DataTable();
       
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
                GolfTData.TabPages.Add(ao85Tab);
                int tabCount = GolfTData.TabCount;
                TabPage ao85 = GolfTData.TabPages[tabCount - 1];  //Uses number of tabs currently in the container to find index of ao85
                ao85.Text = "AO85";

            }
            else
            {
                GolfTData.TabPages.Remove(ao85Tab);
            }
        }



        private void ao91Check_CheckedChanged(object sender, EventArgs e)
        {
           
            //Adds/Removes AO91 tab based on whether the box is adding a check or removing one
            if (ao91Check.Checked)
            {
                GolfTData.TabPages.Add(ao91Tab);
                int tabCount = GolfTData.TabCount;
                TabPage ao91 = GolfTData.TabPages[tabCount - 1]; //Uses number of tabs currently in the container to find index of ao91
                ao91.Text = "AO91";

            }
            else
            {
                GolfTData.TabPages.Remove(ao91Tab);
            }
        }

        private void ao95Check_CheckedChanged(object sender, EventArgs e)
        {
           
            
            //Adds/Removes AO95 tab based on whether the box is adding a check or removing one
            if (ao95Check.Checked)
            {
                try
                {
                    GolfTData.TabPages.Add(ao95Tab);
                    int tabCount = GolfTData.TabCount;
                    TabPage ao95 = GolfTData.TabPages[tabCount - 1]; //Uses number of tabs currently in the container to find index of ao95
                    ao95.Text = "AO95";
                }catch (Exception ex)
                { MessageBox.Show(ex.Message);
                }
            }
            else
            {
                GolfTData.TabPages.Remove(ao95Tab);
            }
        }

        private void ao92Check_CheckedChanged(object sender, EventArgs e)
        {
            
            //Adds/Removes AO92 tab based on whether the box is adding a check or removing one
            if (ao92Check.Checked)
            {
                GolfTData.TabPages.Add(ao92Tab);
                int tabCount = GolfTData.TabCount;
                TabPage ao92 = GolfTData.TabPages[tabCount - 1]; //Uses number of tabs currently in the container to find index of ao92
                ao92.Text = "AO92";

            }
            else
            {
                GolfTData.TabPages.Remove(ao92Tab);
            }
        }

        private void fox1eCheck_CheckedChanged(object sender, EventArgs e)
        {
            
            //Adds/Removes Fox1E tab based on whether the box is adding a check or removing one
            if (fox1eCheck.Checked)
            {
                GolfTData.TabPages.Add(fox1eTab);
                int tabCount = GolfTData.TabCount;
                TabPage fox1e = GolfTData.TabPages[tabCount - 1]; //Uses number of tabs currently in the container to find index of Fox1E
                fox1e.Text = "Fox1E";

            }
            else
            {
                GolfTData.TabPages.Remove(fox1eTab);
            }
        }

        private void ho107Check_CheckedChanged(object sender, EventArgs e)
        {
           
            //Adds/Removes HO107 tab based on whether the box is adding a check or removing one
            if (ho107Check.Checked)
            {
                GolfTData.TabPages.Add(ho107Tab);
                int tabCount = GolfTData.TabCount;
                TabPage ho107 = GolfTData.TabPages[tabCount - 1]; //Uses number of tabs currently in the container to find index of HO107
                ho107.Text = "HO107";

            }
            else
            {
                GolfTData.TabPages.Remove(ho107Tab);
            }
        }

        private void golftCheck_CheckedChanged(object sender, EventArgs e)
        {
            
            //Adds/Removes GolfT tab based on whether the box is adding a check or removing one
            if (golftCheck.Checked)
            {
                GolfTData.TabPages.Add(golftTab);
                int tabCount = GolfTData.TabCount;
                TabPage golft = GolfTData.TabPages[tabCount - 1]; //Uses number of tabs currently in the container to find index of GolfT
                golft.Text = "GolfT";

            }
            else
            {
                GolfTData.TabPages.Remove(golftTab);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Radio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }

        private void chartControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void Radio_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
          
private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                GolfTData.TabPages.Add(ao95Tab);
                int tabCount = GolfTData.TabCount;
                TabPage ao95 = GolfTData.TabPages[tabCount - 1]; //Uses number of tabs currently in the container to find index of ao95
                ao95.Text = "AO95";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void CheckConnection()
        {
            if (!connection.Ping())
            {
                connection.Open();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CheckConnection();
            var cmd = new MySqlCommand("select 1", connection);
            cmd.ExecuteNonQuery();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM foxdb.fox3rttelemetry", connection);
                connection.Open();
                DataSet ds = new DataSet();

                adapter.Fill(ds, "Pad");
                AO95Data.DataSource = ds.Tables["Pad"];
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AO95Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
                    //A085
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT* FROM foxdb.fox1rttelemetry", connection);
                connection.Open();
                DataSet ds = new DataSet();

                adapter.Fill(ds, "Pad");
                AO85Data.DataSource = ds.Tables["Pad"];
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
// Ao91
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM foxdb.fox2rttelemetry", connection);
                connection.Open();
                DataSet ds = new DataSet();

                adapter.Fill(ds, "Pad");
                AO91Data.DataSource = ds.Tables["Pad"];
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
                   // #AO92

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM foxdb.fox4rttelemetry", connection);
                connection.Open();
                DataSet ds = new DataSet();

                adapter.Fill(ds, "Pad");
                AO92Data.DataSource = ds.Tables["Pad"];
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //ho107
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM foxdb.fox6rttelemetry", connection);
                connection.Open();
                DataSet ds = new DataSet();

                adapter.Fill(ds, "Pad");
                HO107Data.DataSource = ds.Tables["Pad"];
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //golft
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM foxdb.fox6rttelemetry", connection);
                connection.Open();
                DataSet ds = new DataSet();

                adapter.Fill(ds, "Pad");
                dataGridView6.DataSource = ds.Tables["Pad"];
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
    
