using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockAssess5a.Models
{
	public class Calculator
	{
		public int num1 { get; set; }
		public int num2 { get; set; }
		public string operation { get; set; }

		public int Calculate()
		{
            int result;
            if (operation == "Plus")
            {
                result = num1 + num2;
            }
            else if (operation == "Minus")
            {
                result = num1 - num2;
            }
            else if (operation == "Multiply")
            {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            }
            return result;
        } 
	}
}
