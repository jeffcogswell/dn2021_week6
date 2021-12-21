using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo2.Models
{
	public class Item
	{
		public static List<Item> Items = new List<Item>()
		{
			new Item() {id = 1, Name = "Mouse", Price = 12.00m },
			new Item() {id = 2, Name = "Keyboard", Price = 25.00m },
			new Item() {id = 3, Name = "Monitor", Price = 125.00m },
		};

		public int id { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }

		public override string ToString()
		{
			return $"Id {id} Name {Name} Price {Price}";
		}
	}
}
