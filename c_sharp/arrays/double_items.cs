using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numList = { 3 , 4 , 5 , 6 , 7 };

			for (int i = 0; i < numList.Length; i++)
			{
				numList[i] *= 2;
			}

			foreach (var number in numList)
			{
				Console.Write(number + " ");
			}
		}
	}
}