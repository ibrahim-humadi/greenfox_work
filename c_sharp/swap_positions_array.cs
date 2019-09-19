using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] abc = {"first", "second", "third"};

			(abc[0], abc[2]) = (abc[2], abc[0]);

			foreach (var position in abc)
			{
				Console.WriteLine(position);
			}
		}


	}
}
