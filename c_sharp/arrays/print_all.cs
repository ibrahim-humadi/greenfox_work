using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = { 4 , 5 , 6 , 7 };

			foreach (var number in numbers)
			{
				Console.WriteLine(number);
			}
		}
	}
}