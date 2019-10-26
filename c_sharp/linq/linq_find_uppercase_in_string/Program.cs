using System;
using System.Linq;

namespace linq_find_uppercase_in_string
{
	class Program
	{
		static void Main(string[] args)
		{
			string mystring = "HelLo WoRld";

			var result = mystring.Where(e => e.ToString().Any(char.IsUpper));

			foreach (var item in result)
			{
				Console.WriteLine(item);
			}
		}
	}
}
