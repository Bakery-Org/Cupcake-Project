using Cupcake_Project.Models;

namespace Cupcake_Project
{
	public interface IProductRepo
	{
		public IEnumerable<Product> GetAllProducts();
	}


}
