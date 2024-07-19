using Dapper;
using System.Data;
using Testing.Models;

namespace Cupcake_Project.Repos
{
	public class IngredientRepo : IIngredientRepo
	{
		private readonly IDbConnection _connection;

		public IngredientRepo(IDbConnection connection)
		{
			_connection = connection;
		}
		public IEnumerable<Ingredient> GetAllIngredients()
		{
			return _connection.Query<Ingredient>("SELECT * FROM INGREDIENTS;");
		}
	}
}
