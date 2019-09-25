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
				File.AppendAllText("output.txt", "\nIbrahim Humadi");
			}
			catch (Exception)
			{
				Console.WriteLine("Unable to write file: output.txt");
			}

		}
	}
}