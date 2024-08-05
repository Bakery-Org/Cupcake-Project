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

		public Product GetProduct(int id)
		{
			return _connection.QuerySingle<Product>("SELECT * FROM Products WHERE id = @id", new { id });
		}

		public void UpdateProduct(Product Product)
		{
			_connection.Execute("UPDATE Products SET Name =@name, Description = @description, Price =@price, Quantity_In_Stock = @quantity_in_stock WHERE ID= @id", new {name = Product.Name, description = Product.Description, price = Product.Price, quantity_in_stock = Product.Quantity_In_Stock, id = Product.ID});
		}
	}
}
