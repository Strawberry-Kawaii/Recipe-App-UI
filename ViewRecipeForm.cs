using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm_Management_System_UI
{
    public partial class ViewRecipeForm : Form
    {
        public int recipeID { get; set; }
        private DashboardForm dashboardForm;
        public ViewRecipeForm(string name, string imagePath, string ingredients, string instructions)
        {
            InitializeComponent();
            lb1Name.Text = name;
            txtIngredients.Text = ingredients;
            txtInstructions.Text = instructions;

            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                pictureBox.Image = Image.FromFile(imagePath);
            }
        }

        private void ViewRecipeForm_Load(object sender, EventArgs e)
        {

        }

        private void DeleteRecipeFromDatabase()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\db_users.accdb;";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("DELETE FROM Recipes WHERE RecipeID = @id", conn);
                cmd.Parameters.AddWithValue("@id", recipeID);
                cmd.ExecuteNonQuery();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete this recipe?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DeleteRecipeFromDatabase();
                this.Dispose(); // remove card from the panel
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(recipeID);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                this.Hide();
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)

        {
            this.Close();
        }
    }
}
