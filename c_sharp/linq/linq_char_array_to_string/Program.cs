using System;
using System.Linq;

namespace linq_char_array_to_string
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] letters = { 'H', 'e','l','l','o' };

			var result = String.Join("", letters.Select(e => e));

			Console.WriteLine(result);			
		}
	}
}
