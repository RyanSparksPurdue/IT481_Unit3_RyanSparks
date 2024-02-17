using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT481_Unit_2_Assign
{
    public partial class MainForm : Form
    {
        private const string connectionString = (@"Data Source=(local)\SQLEXPRESS; Initial Catalog=Northwind; Integrated Security=True");
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;
        private string selectedTable;

        private string[] userPermissions;

        public MainForm(string[] userPermissions)
        {
            InitializeComponent();
            this.userPermissions = userPermissions;
            ApplyUserPermissions();

            connection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter();
            dataSet = new DataSet();
            

        }

        


        private void MainForm_Load(object sender, EventArgs e)
        {
            {
                this.Text = "Welcome to Northwind Database";
                
                txtRecordCount.Visible = true;
                LoadAccessibleTables();
                
            }

        }

        private void LoadAccessibleTables() 
        { 
        
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGetEntryCount_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedTable))
            {
                int entryCount = GetEntryCount(selectedTable);
                txtRecordCount.Text = $"The number of entries in {selectedTable} is {entryCount}";
                txtRecordCount.Visible = true;
            }
            else
            {
                MessageBox.Show("Please select a table first.");
            }
        }

        private void btnShowCustomerTable_Click(object sender, EventArgs e)
        {
            if (radioOrders.Checked)
            {
                selectedTable = "dbo.Orders";
            }
            else if (radioEmployees.Checked)
            {
                selectedTable = "dbo.Employees";
            }
            else if (radioCustomers.Checked)
            {
                selectedTable = "dbo.Customers";
            }

            if (!string.IsNullOrEmpty(selectedTable))
            {
                PopulateDataGridView(selectedTable);
            }
            else
            {
                MessageBox.Show("Please select a table first.");
            }
        }



        private void PopulateDataGridView(string tableName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT * FROM {tableName}";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private int GetEntryCount(string tableName)
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT COUNT(*) FROM {tableName}";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                count = (int)command.ExecuteScalar();
            }
            return count;
        }

        private void radioCustomers_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioOrders_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioEmployees_CheckedChanged(object sender, EventArgs e)
        {

        }
       

        private void ApplyUserPermissions()
        {

            radioCustomers.Visible = false;
            radioOrders.Visible = false;
            radioEmployees.Visible = false;
            
            foreach (string permission in userPermissions)
            {
                switch (permission)
                {
                    case "CanViewCustomers":
                        radioCustomers.Visible = true;
                        break;
                    case "CanViewOrders":
                        radioOrders.Visible = true;
                        break;
                    case "CanViewEmployees":
                        radioEmployees.Visible = true;
                        break;
                    
                        
                }
            }
        }
    }
}