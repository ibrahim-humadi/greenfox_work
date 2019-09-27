using System;

namespace sharpie
{
	class Program
	{
		static void Main(string[] args)
		{
			Sharpie myPen = new Sharpie("Blue", 5 );
			Console.WriteLine(myPen.InkAmount);
			myPen.Use();
			Console.WriteLine(myPen.InkAmount);
		}
	}
}
