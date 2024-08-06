using Cupcake_Project.Models;

namespace Cupcake_Project
{
	public interface IRecipeRepo
	{
		public IEnumerable<Recipe> GetAllRecipes();
		public Recipe GetRecipe(int id);
	}


}
