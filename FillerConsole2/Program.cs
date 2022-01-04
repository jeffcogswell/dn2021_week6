using System;

namespace FillerConsole2
{
	class Program
	{
		static void Main(string[] args)
		{
			string entry = Console.ReadLine();
			Console.WriteLine("------------------------------");
			Console.WriteLine(entry.PadLeft(30));
			Console.WriteLine(entry.Replace('h', '*'));
		}
	}
}
