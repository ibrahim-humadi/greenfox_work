using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] numbers = new int [4,4];

			for (int lineNum = 0; lineNum < 4; lineNum++)
			{
				for (int i = 0; i < 4; i++)
				{
					numbers[0 + i, 0 + i] = 1;
					Console.Write(numbers[i, lineNum] + " ");
				}
				Console.WriteLine();
			}
		}
	}
}