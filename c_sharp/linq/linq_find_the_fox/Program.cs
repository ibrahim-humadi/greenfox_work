using System;
using System.Collections.Generic;

namespace linq_find_the_fox
{
	class Program
	{
		static void Main(string[] args)
		{
			Fox myFox = new Fox();
			Fox myFox1 = new Fox("James", "Nine Tail", "Black");
			Fox myFox2 = new Fox("Samer", "Pallida", "Red");
			Fox myFox3 = new Fox("Nancy", "Pallida", "Green");
			Fox myFox4 = new Fox("Lucy", "Nine Tails", "Green");


			Console.WriteLine(myFox.Name);
		}
	}
}
