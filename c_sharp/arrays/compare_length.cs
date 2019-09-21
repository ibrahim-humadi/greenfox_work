using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] p1 = { 1, 2, 3 };
			int[] p2 = { 4, 5, 6, 7 };

			if (p2.Length > p1.Length)
			{
				System.Console.WriteLine("p2 is longer");
			}
		}
	}
}