using Testing.Models;

namespace Cupcake_Project
{
	public interface IIngredientRepo
	{
		public IEnumerable<Ingredient> GetAllIngredients();
	}


}
