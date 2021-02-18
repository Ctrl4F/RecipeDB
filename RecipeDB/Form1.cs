using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace RecipeDB
{
    public partial class Cookbook : Form
    {
        string connectionString;
        SqlConnection connection;
        public Cookbook()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["RecipeDB.Properties.Settings.ResipeDBmdfConnectionString"].ConnectionString;
        }

        private void Cookbook_Load(object sender, EventArgs e)
        {
            PopulateRecipes();
        }

        private void PopulateRecipes()
        {
            using (connection = new SqlConnection(connectionString)) 
            using(SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Recipe", connection))
            {
                DataTable recipeTable = new DataTable();
                adapter.Fill(recipeTable);

                listRecipe.DisplayMember = "Name";
                listRecipe.ValueMember = "Id";
                listRecipe.DataSource = recipeTable;
            }
        }

        private void PopulateIngredients()
        {
            string query = "SELECT Ingredient.Name FROM Ingredient INNER JOIN RecipeIngredient ON Ingredient.Id = RecipeIngredient.IngredientId WHERE RecipeIngredient.RecipeId = @RecipeId";
            using (connection = new SqlConnection(connectionString)) 
            using(SqlCommand command = new SqlCommand(query, connection))
            using(SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                //get recipe id from the listRecipe listbox
                command.Parameters.AddWithValue("@RecipeId", listRecipe.SelectedValue);
                DataTable ingredientTable = new DataTable();
                adapter.Fill(ingredientTable);

                listIngredent.DisplayMember = "Name";
                listIngredent.ValueMember = "Id";
                listIngredent.DataSource = ingredientTable;
            }
        }

        private void listRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateIngredients();
        }
    }
}
