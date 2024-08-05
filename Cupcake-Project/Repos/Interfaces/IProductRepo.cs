﻿using Cupcake_Project.Models;

namespace Cupcake_Project
{
	public interface IProductRepo
	{
		public IEnumerable<Product> GetAllProducts();
		public Product GetProduct(int id);

		public void UpdateProduct(Product Product);

		public void InsertProduct(Product ProductToInsert);
	}


}
