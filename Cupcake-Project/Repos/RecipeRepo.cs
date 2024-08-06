using Dapper;
using System.Data;
using Cupcake_Project.Models;

namespace Cupcake_Project.Repos
{
	public class RecipeRepo : IRecipeRepo
	{
		private readonly IDbConnection _connection;

		public RecipeRepo(IDbConnection connection)
		{
			_connection = connection;
		}
		public IEnumerable<Recipe> GetAllRecipes()
		{
			return _connection.Query<Recipe>("SELECT * FROM Recipes;");
		}

        public Recipe GetRecipe(int id)
        {
            return _connection.QuerySingle<Recipe>("SELECT * FROM Recipes WHERE id = @id", new { id });
        }
		public void UpdateRecipe (Recipe recipe)
		{
			_connection.Execute("UPDATE Recipes SET product_id = @product_id, ingredient_id = @ingredient_id, quantity_required = @quantity_required WHERE id = @id",
				new {product_id = recipe.Product_ID, ingredient_id = recipe.Ingredient_ID, quantity_required = recipe.Quantity_Required, id = recipe.ID });
		}
    }
}
