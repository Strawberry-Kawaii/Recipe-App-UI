using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Farm_Management_System_UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide(); // Optional: Hide the current login form
            Form1 registrationForm = new Form1();
            registrationForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            int loggedInUserID = -1;

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_users.accdb;";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string query = "SELECT ID FROM td_users WHERE username = ? AND password = ?";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", username);
                cmd.Parameters.AddWithValue("?", password);

                conn.Open();
                var result = cmd.ExecuteScalar();

                if(result != null)
                {
                    loggedInUserID = Convert.ToInt32(result);

                    // Opens form of the user 
                    DashboardForm dashboard = new DashboardForm(loggedInUserID);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
        }
    }
}
