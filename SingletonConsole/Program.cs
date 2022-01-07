using System;

namespace SingletonConsole
{

	class Rectangle
	{
		public int Length;
		public int Width;

	}

	class Square
	{
		public int Side;

		private Square(int Side)
		{
			this.Side = Side;
		}

		public int GetArea()
		{
			return Side * Side;
		}

		public static Square GetInstance() // Factory method
		{
			Square sq = new Square(10);
			return sq;
		}

	}

	class MyCar
	{
		// This is a singleton class! Only one instance shall exist

		public string Make;
		public string Model;

		private MyCar(string Make, string Model)
		{
			this.Make = Make;
			this.Model = Model;
		}

		private static MyCar _inst = null;
		public static MyCar GetInstance()
		{
			if (_inst == null)
			{
				_inst = new MyCar("Ford", "Pinto");
			}
			return _inst;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{

			Rectangle rect = new Rectangle();
			rect.Length = 10;
			rect.Width = 20;
			Console.WriteLine($"{rect.Length} {rect.Width}");

			Rectangle rect2 = new Rectangle();
			rect2.Length = 20;
			rect2.Width = 30;
			Console.WriteLine($"{rect2.Length} {rect2.Width}");

			// Square sq1 = new Square(10); Can't do this! The constructor is private!
			Square sq1 = Square.GetInstance();
			Console.WriteLine(sq1.GetArea());

			Square sq2 = Square.GetInstance();
			sq2.Side = 20;
			Console.WriteLine(sq2.GetArea());

			MyCar mine = MyCar.GetInstance();
			mine.Model = "Mustang";
			Console.WriteLine($"{mine.Make} {mine.Model}");

			MyCar mine2 = MyCar.GetInstance();
			Console.WriteLine($"{mine.Make} {mine.Model}");
		}
	}
}
