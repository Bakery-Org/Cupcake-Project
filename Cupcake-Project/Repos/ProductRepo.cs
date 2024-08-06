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

		public void UpdateProduct(Product product)
		{
			_connection.Execute("UPDATE Products SET Name =@name, Description = @description, Price =@price, Quantity_In_Stock = @quantity_in_stock WHERE ID= @id", 
				new {name = product.Name, description = product.Description, price = product.Price, quantity_in_stock = product.Quantity_In_Stock, id = product.ID});
		}

		public void InsertProduct(Product product)
		{
			_connection.Execute("INSERT INTO Products (Name, Description, Price, Quantity_In_Stock) VALUES (@name, @description, @price, @quantity_in_stock);", 
				new { name = product.Name, description = product.Description, price = product.Price, quantity_in_stock = product.Quantity_In_Stock });
		}

		public void DeleteProduct(Product product)
		{
			_connection.Execute("DELETE FROM Products WHERE ID = @id;", new { id = product.ID });
		}
	}
}
