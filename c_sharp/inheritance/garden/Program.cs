using System;

namespace garden
{
	class Program
	{
		static void Main(string[] args)
		{
			Flower yellowFlower = new Flower("yellow");
			Flower blueFlower = new Flower("blue");

			Tree purpleTree = new Tree("purple");
			Tree orangeTree = new Tree("orange");

			Garden garden = new Garden();
			garden.Add(yellowFlower);
			garden.Add(blueFlower);
			garden.Add(purpleTree);
			garden.Add(orangeTree);

			garden.Status();

			garden.Water(40);

			garden.Water(70);
		}
	}
}
