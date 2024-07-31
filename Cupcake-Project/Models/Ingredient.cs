using Org.BouncyCastle.Asn1.Mozilla;
using System;

namespace Cupcake_Project.Models
{

	public class Ingredient
	{
		public Ingredient()
		{
		}

		public int ID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Unit_of_Measurement { get; set; }
		public int Quantity_in_stock { get; set; }
	}

}