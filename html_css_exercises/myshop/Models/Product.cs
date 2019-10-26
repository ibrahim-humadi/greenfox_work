using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myshop.Models
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get ;set ; }
		public string Description { get; set; }
		public int Price { get; set; }
		public int Stock { get; set; }

		public Product(int id, string name, string description, int price, int stock)
		{
			Id = id;
			Name = name;
			Description = description;
			Price = price;
			Stock = stock;
		}
	}
}
