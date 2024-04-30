using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Xml.Linq;

namespace LoginTask

{

    public partial class Form1 : Form
    {
        string connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\AIUB\C#\LoginTask\Database\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Username = txtUserName.Text.ToString();
            String Password = txtpassword.Text.ToString();

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
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
                cmd.CommandText = "select * from ABC where Name = '" + Username + "' and password = '" + Password + "'";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    new Form2().Show();
                    this.Hide();
                    //MessageBox.Show("The email is already been used.\nEnter a different valid email");
                }
                else
                {
                    MessageBox.Show("Sorry. The User name or password is incorrect.");
                    txtUserName.Clear();
                    txtpassword.Clear();
                    txtUserName.Focus();
                }
                conn.Close();
            }

            /*if (txtUserName.Text == "Kazi Arafat" && txtpassword.Text == "123456")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sorry. The User name or password is incorrect.");
                txtUserName.Clear();
                txtpassword.Clear();
                txtUserName.Focus();
            }*/
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void New_Account_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }
    }
}