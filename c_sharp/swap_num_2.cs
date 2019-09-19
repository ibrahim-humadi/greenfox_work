using System;

namespace day1
{
    class Program
    {
        static void Main(string[] args)
        {
			int numbera = 123;
			int numberb = 526;

			Console.WriteLine(numbera + " " + numberb);

			numbera *= numberb;
			numberb  = numbera / numberb;
			numbera /= numberb;

			Console.WriteLine(numbera + " " + numberb);
        }
    }
}