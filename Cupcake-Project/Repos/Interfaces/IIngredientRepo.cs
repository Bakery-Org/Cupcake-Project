using Cupcake_Project.Models;

namespace Cupcake_Project
{
	public interface IIngredientRepo
	{
		public IEnumerable<Ingredient> GetAllIngredients();
        public Ingredient GetIngredient(int id);
        public void UpdateIngredient(Ingredient ingredient);
        public void InsertIngredient(Ingredient ingredient);
        public void DeleteIngredient(Ingredient ingredient);
    }


}
