using Dapper;
using System.Data;
using Cupcake_Project.Models;

namespace Cupcake_Project.Repos
{
	public class IngredientRepo : IIngredientRepo
	{
		private readonly IDbConnection _connection;

		public IngredientRepo(IDbConnection connection)
		{
			_connection = connection;
		}

        public void DeleteIngredient(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ingredient> GetAllIngredients()
		{
			return _connection.Query<Ingredient>("SELECT * FROM Ingredients;");
		}

        public Ingredient GetIngredient(int id)
        {
            return _connection.QuerySingle<Ingredient>("SELECT * FROM Ingredients WHERE id = @id", new { id = id });
        }

        public void InsertIngredient(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        public void UpdateIngredient(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }
    }
}
