using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMvc1.Models
{
	public class Animal
	{
		public string name { get; set; }
		public string animal_type { get; set; }
		public string habitat { get; set; }
		public string image_link { get; set; }
		public override string ToString()
		{
			return $"{name} {animal_type} {habitat} {image_link}";
		}
	}
}
