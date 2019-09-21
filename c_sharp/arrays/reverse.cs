using System;

namespace day1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] aj = { 3 , 4 , 5 , 6 , 7 };
			int order = 1;

			for (int i = 0; i < aj.Length; i++)
			{
				while (aj.Length - order > 0)
				{
					aj[i] = aj[aj.Length - order];
					Console.WriteLine(aj[i]);
					order += 1;
				}
			}
			Console.WriteLine(aj[4] -= aj[1]);
		}
	}
}