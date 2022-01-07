using System;

namespace SingletonBroken
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
		public static Square MySquare = new Square(10);
	}


	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(MyShapes.MySquare.GetArea());
			MyShapes.MySquare.Name = "Fred";
			MyShapes.MySquare.Name = "Julia";
			MyShapes.MySquare.Side = 20;
			Console.WriteLine(MyShapes.MySquare.GetArea());
			MyShapes.MySquare.Name = "Sally";
		}
	}
}
