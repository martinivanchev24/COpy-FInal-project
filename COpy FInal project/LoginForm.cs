using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class LoginForm : Form
    {
        string username;
        public LoginForm()
        {
         
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-201A2LL;Initial Catalog=finalproject;Integrated Security=True";
            string query1 = "INSERT INTO Orders (username) VALUES (@username)";
            int OrderID = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query1, connection);
                command.Parameters.AddWithValue("@username", txtUsername2.Text);


                connection.Open();
                command.ExecuteNonQuery();
                SqlCommand command2 = new SqlCommand("SELECT TOP 1 * FROM Orders ORDER BY OrderID DESC", connection);
                OrderID = (int)command2.ExecuteScalar();

            }

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-201A2LL;Initial Catalog=finalproject;Integrated Security=True");
            con.Open();
            string query = "SELECT Count(*) FROM Users WHERE username=@username";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", txtUsername2.Text);
            cmd.ExecuteNonQuery();
            username = txtUsername2.Text;
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count == 1)
            {
                MainForm mainForm = new MainForm(username,OrderID);
                mainForm.Show();
                return;
            }
            else
            {
                MessageBox.Show("Indvalid username or password");
            }
          
        }

        private void label2_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.ShowDialog();
            this.Close();
        }
    }
}
