using Org.BouncyCastle.Asn1.Mozilla;
using System;


namespace Testing.Models
{
	public class Ingredient
	{
		public Ingredient()
		{
		}

		public int ID { get; set; }
		public int Product_ID { get; set; }
		public int Ingredient_ID { get; set; }
		public int Quantity_Required { get; set; }
	}
}