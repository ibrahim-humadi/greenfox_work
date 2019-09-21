using System;

namespace day1
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] abc = { "first", "second", "third" };

			foreach (var letter in abc)
			{
				System.Console.Write(letter);
			}

			(abc[0],abc[2]) = (abc[2],abc[0]);
			Console.WriteLine();

			foreach (var letter in abc)
			{
				System.Console.Write(letter);
			}
		}
	}
}