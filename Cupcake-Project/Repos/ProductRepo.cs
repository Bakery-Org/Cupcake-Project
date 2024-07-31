using Dapper;
using System.Data;
using Cupcake_Project.Models;

namespace Cupcake_Project.Repos
{
	public class ProductRepo : IProductRepo
	{
		private readonly IDbConnection _connection;

		public ProductRepo(IDbConnection connection)
		{
			_connection = connection;
		}
		public IEnumerable<Product> GetAllProducts()
		{
			return _connection.Query<Product>("SELECT * FROM Products;");
		}
	}
}
