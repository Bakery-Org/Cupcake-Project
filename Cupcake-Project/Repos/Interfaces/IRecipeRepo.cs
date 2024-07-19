using Testing.Models;

namespace Cupcake_Project
{
	public interface IRecipeRepo
	{
		public IEnumerable<Recipe> GetAllRecipes();
	}


}
