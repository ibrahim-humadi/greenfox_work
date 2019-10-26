using System;
using System.Linq;

namespace linq_frequency_of_numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

			var frequency = from p in n
							group p by p;

			foreach (var item in frequency)
			{
				Console.WriteLine("number: " + item.Key + " frquency: " + item.Count());
			}
		}
	}
}
