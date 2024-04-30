using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LoginTask
{
    public partial class Form3 : Form
    {
        string connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\AIUB\C#\LoginTask\Database\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        public Form3()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameTB.Text.ToString();
            string id = idTB.Text.ToString();
            string password = passwordTB.Text.ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(password) )
            {
                DialogResult dialogResult = MessageBox.Show("No empty fields allowed, \nPlease fill up all the fields", "Can't Register", MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = connection_string;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from ABC where name = '" + name + "' or id= '" + id + "'";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("The Name or ID is already been used.\nEnter a different valid Name or ID");
                }
                else
                {
                    reader.Close();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.Connection = conn;
                    cmd1.CommandText = "insert into ABC (Name, ID, password) values ('" + name + "', '" + id + "', '" + password + "')";
                    cmd1.ExecuteNonQuery();

                    MessageBox.Show("New Account is created");
                    new Form1().Show();
                    this.Hide();
                }
                conn.Close();
            }
        }
    }
}
