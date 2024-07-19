using Cupcake_Project;
using Microsoft.AspNetCore.Mvc;

namespace Testing.Controllers
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
    }
}