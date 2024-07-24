using System;


namespace Cupcake_Project.Models
{
	public class Recipe
	{
		public Recipe()
		{
		}

		public int ID { get; set; }
		public int Product_ID { get; set; }
		public int Ingredient_ID { get; set; }
		public int Quantity_Required { get; set; }
	}
}