using System;

namespace day1
{
    class Program
    {
        static void Main(string[] args)
        {
			int numbera = 123;
			int numberb = 526;
			int numberc = 0;

			Console.WriteLine(numbera + " " + numberb);

			numberc = numbera;
			numbera = numberb;
			numberb = numberc;

			Console.WriteLine(numbera + " " + numberb);

        }
    }
}