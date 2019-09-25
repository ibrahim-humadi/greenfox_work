using System;
using System.IO;

namespace drawing_application
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				string[] fileContent = File.ReadAllLines("./my_file.txt");
				int numOfLines = fileContent.Length;
				Console.WriteLine(numOfLines);
			}
			catch (Exception)
			{
				Console.WriteLine(0);
			}
		}
	}
}