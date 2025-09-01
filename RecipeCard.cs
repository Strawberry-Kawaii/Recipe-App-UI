using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Xml.Linq;
using System.Runtime.CompilerServices;

namespace Farm_Management_System_UI
{
    public partial class RecipeCard : UserControl
    {
        public int recipeID { get; set; }
        private DashboardForm dashboardForm;
        public string RecipeName => lb1Name.Text;

        // view Recipe Form 
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
        public string ImagePath { get; set; }


        public RecipeCard(DashboardForm form)
        {
            InitializeComponent();
            this.dashboardForm = form;
        }
        public void SetRecipe(string name, string imagePath, string ingredients, string instructions)
        {
            lb1Name.Text = name;
            Ingredients = ingredients;
            Instructions = instructions;
            ImagePath = imagePath;

            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                pictureBox.Image = Image.FromFile(imagePath);
            }
            else
            {
                pictureBox.Image = null; // or a default placeholder
            }
        }

        private void RecipeCard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            ViewRecipeForm popup = new ViewRecipeForm(lb1Name.Text, ImagePath, Ingredients, Instructions);
            popup.ShowDialog();
            this.Hide();
        }
        
    }
}
   
