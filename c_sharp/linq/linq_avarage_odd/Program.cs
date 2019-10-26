using System;
using System.Linq;

namespace linq_avarage_odd
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

			var result = n.Where(e => e % 2 == 1);

			int sum = 0;

			foreach (var item in result)
			{
				sum += item;
			}

			int avarage = sum / result.Count();

			Console.WriteLine(avarage);
		}
	}
}

//better solution

var avarage = n.Where(e => e % 2 != 0).Avarage();


