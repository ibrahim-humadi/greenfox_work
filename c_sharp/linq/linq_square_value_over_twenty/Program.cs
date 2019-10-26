using System;
using System.Linq;

namespace linq_square_value_over_twenty
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] n = new[] { 3, 9, 2, 8, 6, 5 };

			var result = n.Where(e => e*e > 20);

			foreach (var item in result)
			{
				Console.WriteLine(item);
			}
		}
	}
}