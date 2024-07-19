using System;

namespace Testing.Models
{
	public class Product
	{
		public Product()
		{
		}


		public int ID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public int Quantity_In_Stock { get; set; }
	}
}