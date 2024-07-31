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
	}
}
