using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockAssess5b.Models
{
	public class Person
	{
		public int Age { get; set; }
		public string UserName { get; set; }
		public bool CanDrink {
			get
			{
				return Age >= 21;
			}
		}
		public bool CanDrive
		{
			get
			{
				return Age >= 16;
			}
		}
	}
}
