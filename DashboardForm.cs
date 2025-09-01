using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Runtime.InteropServices;

namespace Farm_Management_System_UI
{
    public partial class DashboardForm : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\db_users.accdb;";
        private int userID;
        public DashboardForm(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadRecipes();

        }
        public void LoadRecipes()
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                flowLayoutPanel1.Controls.Clear(); // clear existing cards

                conn.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Recipes WHERE UserID = @id", conn);
                cmd.Parameters.AddWithValue("@id", userID);

                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    int recipeID = Convert.ToInt32(row["RecipeID"]);
                    string recipeName = row["Recipe"].ToString();
                    string imagePath = row["ImagePath"].ToString();
                    string ingredients = row["Ingredients"].ToString();
                    string instructions = row["Instructions"].ToString();

                    RecipeCard card = new RecipeCard(this);
                    card.recipeID = Convert.ToInt32(row["RecipeID"]);
                    card.SetRecipe(recipeName, imagePath, ingredients, instructions);
                    flowLayoutPanel1.Controls.Add(card);
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 login = new Form2();
            login.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm addform = new AddForm(userID);
            if (addform.ShowDialog() == DialogResult.OK)
            {
                LoadRecipes();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // search users 
            string searchText = txtSearch.Text.Trim().ToLower();

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is RecipeCard card)
                {
                    bool isMatch = card.RecipeName.ToLower().Contains(searchText);
                    card.Visible = isMatch;
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
