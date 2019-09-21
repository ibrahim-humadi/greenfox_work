using System;

namespace ConsoleApp1
{
	class Program
	{

		static int Sum(int[] array)
		{ 
			System.Console.WriteLine("Please select array index");

			int userinpt = int.Parse(Console.ReadLine());
			int sum = 0;
			for (int i = 0; i<userinpt; i++)
			{
				sum += array[i];
				
			}
			return sum;
		}


		static void Main(string[] args)
		{
			int[] ai = { 3, 4, 5, 6, 7 };
			Console.WriteLine(Sum(ai));

		}


	}
}
