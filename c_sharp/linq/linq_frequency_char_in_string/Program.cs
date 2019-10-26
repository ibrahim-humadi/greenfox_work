using System;
using System.Linq;

namespace linq_sqaured_positive_numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

			var result = n.Where(e => e >= 0).Select(e => e * e);

			foreach (var item in result)
			{
				Console.WriteLine(item);
			}
		}
	}
}
