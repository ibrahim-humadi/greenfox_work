using System;

namespace ConsoleApp1
{
	class Program
	{
		public static string[] removeFirstandLast(string[] array)
			{
			string[] newarray = new string[array.Length];
			int arraystart = array.Length - 1;
			newarray[0] = array[array.Length - arraystart];
			newarray[array.Length] = array[array.Length - 1];
			return newarray;
			}


		static void Main(string[] args)
		{
			string[] abc = {"first", "second", "third", "fourth", "fifth"};

			Console.WriteLine(removeFirstandLast(abc));

			
		}


	}
}
