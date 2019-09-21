using System;

namespace day1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] ai = { 3 , 4 , 5 , 6 , 7 };
			int sum = ai[0];

			for (int i = 0; i < ai.Length - 1; i++)
			{
				sum += ai[i + 1];
				Console.WriteLine(sum);
			}
		}
	}
}