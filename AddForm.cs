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
    public partial class AddForm : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\db_users.accdb;";

        private int userID;
        private string selectedImagePath = " ";

        public AddForm(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {

                // Saving the image locally 
                string imagePathToStore = "";
                if (!string.IsNullOrEmpty(selectedImagePath))
                {
                    string imagesDir = Path.Combine(Application.StartupPath, "Images");
                    Directory.CreateDirectory(imagesDir);           // creates if missing

                    string newFileName = Guid.NewGuid() + Path.GetExtension(selectedImagePath);
                    string destPath = Path.Combine(imagesDir, newFileName);
                    File.Copy(selectedImagePath, destPath, true);

                    imagePathToStore = destPath;
                }

                conn.Open();
                string query = "INSERT INTO Recipes (UserID, Recipe, ImagePath, Ingredients, Instructions) VALUES (@userID, @name, @imagePath, @ingredients, @instructions)";
                OleDbCommand cmd = new OleDbCommand(query, conn);

                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@imagePath", imagePathToStore);
                cmd.Parameters.AddWithValue("@ingreidients", txtIngredients.Text);
                cmd.Parameters.AddWithValue("@instructions", txtInstructions.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Recipe added!");
                this.DialogResult = DialogResult.OK;
                conn.Close();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image Files (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = dlg.FileName;
                    pictureBoxPreview.Image = Image.FromFile(selectedImagePath);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
