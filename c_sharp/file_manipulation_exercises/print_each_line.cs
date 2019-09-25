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
				string fileContent = File.ReadAllText("./my_file.txt");
				Console.WriteLine(fileContent);
			}
			catch (Exception)
			{
				Console.WriteLine("Unable to read file: my_file.txt");
			}
		}
	}
}