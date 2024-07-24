using Cupcake_Project.Models;

namespace Cupcake_Project
{
	public interface IIngredientRepo
	{
		public IEnumerable<Ingredient> GetAllIngredients();
	}


}
