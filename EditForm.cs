using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Farm_Management_System_UI
{
    public partial class EditForm : Form
    {
        private int recipeID;
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\db_users.accdb;";
        string imagePath = "";

        public EditForm(int recipeID)
        {
            InitializeComponent();
            this.recipeID = recipeID;
        }


        private void EditForm_Load(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Recipes WHERE RecipeID = @id", conn);
                cmd.Parameters.AddWithValue("@id", recipeID);
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtName.Text = reader["Recipe"].ToString();
                    txtIngredients.Text = reader["Ingredients"].ToString();
                    txtInstructions.Text = reader["Instructions"].ToString();
                    imagePath = reader["ImagePath"].ToString();

                    if (File.Exists(imagePath))
                        PictureBox.Image = Image.FromFile(imagePath);
                }
            }
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.png;*.jpeg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = dialog.FileName;
                PictureBox.Image = Image.FromFile(imagePath);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            string sql = @"UPDATE Recipes SET  Recipe = ?, ImagePath   = ?, Ingredients = ?, Instructions= ? WHERE RecipeID   = ?";      

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                // add parameters IN EXACTLY the same order as the ? marks
                cmd.Parameters.Add("Recipe", OleDbType.VarChar).Value = txtName.Text;
                cmd.Parameters.Add("ImagePath", OleDbType.VarChar).Value = imagePath;
                cmd.Parameters.Add("Ingredients", OleDbType.LongVarChar).Value = txtIngredients.Text;
                cmd.Parameters.Add("Instructions", OleDbType.LongVarChar).Value = txtInstructions.Text;
                cmd.Parameters.Add("ID", OleDbType.Integer).Value = recipeID;

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Recipe updated!");
            this.DialogResult = DialogResult.OK;
        }
    }
}

