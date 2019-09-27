using System;

namespace animal
{
	class Program
	{
		static void Main(string[] args)
		{
			Animal zebra = new Animal("Zebra", 50 , 50);
			Console.WriteLine("Your " + zebra.AnimalName + "'s Thirst level is: " + zebra.Thirst + " and Hunger level is at: " + zebra.Hunger);

			for (int i = 0; i < 50; i++)
			{
				zebra.Drink();
				Console.WriteLine(zebra.Thirst);
			}

			if (zebra.Thirst <= 0)
			{
				Console.WriteLine("Your " + zebra.AnimalName + " died. Sorry guy.");
			}
		}
	}
}
