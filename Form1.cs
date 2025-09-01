using System.Windows.Forms;
using System.Data.OleDb;

namespace Farm_Management_System_UI
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_users.accdb;";
        public Form1()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            txtConfirmPwd.PasswordChar = '*';
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPwd.Text;

            // Performing Error Validation 
            if (username.Equals("") || password.Equals(" ") || confirmPassword.Equals(" "))
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();

                // if the username already exists 
                string checkQuery = "Select COUNT(*) FROM td_users WHERE username = ?";
                OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("?", username);

                int userCount = (int)checkCmd.ExecuteScalar();
                if (userCount > 0)
                {
                    MessageBox.Show("Username alreay exists. Please pick another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Add new user 
                string insertQuery = "Insert Into td_users (username, [password]) VALUES (?,?)";
                OleDbCommand cmd = new OleDbCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("?", username);
                cmd.Parameters.AddWithValue("?", password);

                // display result 
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // clear fields
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtConfirmPwd.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Optionally clear fields
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPwd.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide(); // Optional: Hide the current login form
            Form2 loginForm = new Form2();
            loginForm.Show();
        }
    }
}
