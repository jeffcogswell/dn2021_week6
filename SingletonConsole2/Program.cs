using System;

namespace SingletonConsole2
{

	class Square
	{
		// This is NOT a singleton class
		public int Side;
		public Square(int _Side)
		{
			Side = _Side;
		}
		public int GetArea()
		{
			return Side * Side;
		}
	}

	class MyShapes
	{
		// Even though Square is not a singleton, here inside MyShapes I'm maintaining a single instance.
		private static Square MySquare = null;
		public static Square GetSquare() // Getter function
		{
			if (MySquare == null)
			{
				MySquare = new Square(10);
			}
			return MySquare;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{

			Square sq1 = MyShapes.GetSquare();
			Console.WriteLine(sq1.GetArea());

			sq1.Side = 20;

			Square sq2 = MyShapes.GetSquare();
			Console.WriteLine(sq2.GetArea());

		}
	}
}
