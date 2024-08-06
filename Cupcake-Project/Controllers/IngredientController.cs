using Cupcake_Project;
using Cupcake_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cupcake_Project.Controllers
{
    public class IngredientController : Controller
    {
        private readonly IIngredientRepo repo;

        public IngredientController(IIngredientRepo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var ingredients = repo.GetAllIngredients();
            return View(ingredients);
        }

        public IActionResult ViewIngredient(int id)
        {
            var ingredient = repo.GetIngredient(id);
            return View(ingredient);
        }

        public IActionResult UpdateIngredient(int id)
        {
            Ingredient ingredient = repo.GetIngredient(id);
            if (ingredient == null)
            {
                return View("IngredientNotFound");
            }
            return View(ingredient);
        }

        public IActionResult UpdateIngredientToDatabase(Ingredient ingredient)
        {
            repo.UpdateIngredient(ingredient);

            return RedirectToAction("ViewIngredient", new { id = ingredient.ID });
        }

        public IActionResult InsertIngredient(Ingredient ingredient)
        {

            return View(ingredient);
        }

        public IActionResult InsertIngredientToDatabase(Ingredient ingredient)
        {
            repo.InsertIngredient(ingredient);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteIngredient(Ingredient ingredient)
        {
            repo.DeleteIngredient(ingredient);
            return RedirectToAction("Index");
        }
    }
}