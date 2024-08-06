using Cupcake_Project;
using Cupcake_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cupcake_Project.Controllers
{
    public class RecipeController : Controller
    {
        private readonly IRecipeRepo repo;

        public RecipeController(IRecipeRepo repo)
        {
            this.repo = repo;
        }


        public IActionResult Index()
        {
            var recipe = repo.GetAllRecipes();
            return View(recipe);
        }
        public IActionResult ViewRecipe(int id)
        {
            var recipe = repo.GetRecipe(id);
            return View(recipe);
        }
        public IActionResult UpdateRecipe(int id)
        {
            Recipe recipe = repo.GetRecipe(id);
            if (recipe == null)
            {
                return View("RecipeNotFound");
            }
            return View(recipe);
        }
        public IActionResult UpdateRecipeToDatabase(Recipe recipe)
        {
            repo.UpdateRecipe(recipe);
            return RedirectToAction("ViewRecipe", new { id = recipe.ID });
        }
        public IActionResult InsertRecipe()
        {
            var recipe = new Recipe();
            return View(recipe);
        }
        public IActionResult InsertRecipeToDatabase(Recipe recipe)
        {
            repo.InsertRecipe(recipe);
            return RedirectToAction("Index");
        }
    }
}