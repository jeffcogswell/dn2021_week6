using System;

namespace SingletonConsole3
{
	class Square
	{
		// This is NOT a singleton class
		public int Side;
		public string Name;
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
		private static Square _square = null;
		public static Square MySquare
		{
			get
			{
				if (_square == null)
				{
					_square = new Square(10);
					_square.Name = "Fred";
				}
				return _square;
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			//Square sq1 = MyShapes.MySquare;
			//Console.WriteLine(sq1.GetArea());

			//sq1.Side = 20;

			//Square sq2 = MyShapes.MySquare;
			//Console.WriteLine(sq2.GetArea());

			Console.WriteLine(MyShapes.MySquare.GetArea());
			MyShapes.MySquare.Side = 20;
			Console.WriteLine(MyShapes.MySquare.GetArea());
		}
	}
}
