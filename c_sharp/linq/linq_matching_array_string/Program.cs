using System;
using System.Linq;

namespace linq_matching_array_string
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
			var result = cities.Where(e => e.StartsWith("A") && e.EndsWith("I"));

			foreach (var item in result)
			{
				Console.WriteLine(item);
			}
		}
	}
}
