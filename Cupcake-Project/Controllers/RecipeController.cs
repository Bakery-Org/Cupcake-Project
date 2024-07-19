﻿using Cupcake_Project;
using Microsoft.AspNetCore.Mvc;

namespace Testing.Controllers
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
    }
}