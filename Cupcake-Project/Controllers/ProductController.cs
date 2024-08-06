using Cupcake_Project;
using Cupcake_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cupcake_Project.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepo repo;

        public ProductController(IProductRepo repo)
        {
            this.repo = repo;
        }


        public IActionResult Index()
        {
            var products = repo.GetAllProducts();
            return View(products);
        }

        public IActionResult ViewProduct(int id)
        {
            var product = repo.GetProduct(id);
            return View(product);
        }

        public IActionResult UpdateProduct(int id)
        {
            var product = repo.GetProduct(id);

            if (product == null)
            {
                return View("ProductNotFound");
            }

            return View(product);
        }
        
        public IActionResult UpdateProductToDatabase(Product product)
        {
            repo.UpdateProduct(product);
            return RedirectToAction("ViewProduct", new { id = product.ID });
        }

        public IActionResult InsertProduct(Product product)
        {

            return View(product);
        }
        public IActionResult InsertProductToDatabase(Product product)
        {
            repo.InsertProduct(product);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(Product product)
        {
            repo.DeleteProduct(product);
            return RedirectToAction("Index");
          
        }
       
    }
    
}