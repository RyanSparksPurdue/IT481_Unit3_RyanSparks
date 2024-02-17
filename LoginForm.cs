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

namespace IT481_Unit_2_Assign
{
    public partial class LoginForm : Form
    {

        private const string connectionString = (@"Data Source=(local)\SQLEXPRESS; Initial Catalog=Northwind; Integrated Security=True");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string[] userPermissions = GetUserPermissions(username, password);
            if (userPermissions != null)
            {
                MainForm mainForm = new MainForm(userPermissions);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }


        private bool IsValidUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND PasswordHash = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }





        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private string[] GetUserPermissions(string username, string password)
        {
            
            switch (username)
            {
                case "User_CEO":
                    return new string[] { "CanViewOrders", "CanViewEmployees", "CanViewCustomers" };
                case "User_HR":
                    return new string[] { "CanViewEmployees" };
                case "User_Sales":
                    return new string[] { "CanViewOrders", "CanViewCustomers" };
                default:
                    return null;
            }
        }



    }
}
