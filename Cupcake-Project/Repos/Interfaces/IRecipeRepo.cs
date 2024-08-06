using Cupcake_Project.Models;

namespace Cupcake_Project
{
	public interface IRecipeRepo
	{
		public IEnumerable<Recipe> GetAllRecipes();
		public Recipe GetRecipe(int id);
		public void UpdateRecipe(Recipe recipe);
		public void InsertRecipe (Recipe recipe);
		public void DeleteRecipe (Recipe recipe);
	}


}
