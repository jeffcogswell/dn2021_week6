using System;

namespace Conditional
{
	class Program
	{
		static void Main(string[] args)
		{
			string entry = Console.ReadLine();
			int num = int.Parse(entry);

			//if (num < 0)
			//{
			//	num = 0;
			//}

			Console.WriteLine(num < 0 ? 0 : num);
			// If num is < 0, then return 0 else return num

			Console.WriteLine(num < 0 ? "Less than zero" : (num == 0 ? "Equals zero" : "Greater than zero"));
		}
	}
}
