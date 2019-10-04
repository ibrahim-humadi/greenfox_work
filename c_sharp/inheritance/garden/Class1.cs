using System;
using System.Collections.Generic;
using System.Text;

namespace garden
{
	class Flower
	{
		public string Colour { get; set; }
		public bool NeedsWater { get; set; }
		public double WaterLvl { get; set; }

		public Flower(string colour = "Blue", bool needsWater = true, double waterLvl = 0)
		{
			this.Colour = colour;
			this.NeedsWater = needsWater;
		}
	}

	class Tree : Flower
	{
		public Tree(string colour = "Blue", bool needsWater = true)
		{

		}
	}

	class Garden
	{
		public List<Flower> flowers { get; set; }
		public List<Tree> trees { get; set; }

		public Garden()
		{
			flowers = new List<Flower>();
			trees = new List<Tree>();
		}

		public void Add(Flower flower)
		{
			flowers.Add(flower);
		}

		public void Add(Tree tree)
		{
			trees.Add(tree);
		}

		public void Status()
		{
			foreach (var flower in flowers)
			{
				if (flower.NeedsWater == true)
				{
					Console.WriteLine("The " + flower.Colour + " flower needs water");
				}
				else
				{
					Console.WriteLine("The " + flower.Colour + " flower doesnt need water");
				}
			}

			foreach (var tree in trees)
			{
				if (tree.NeedsWater == true)
				{
					Console.WriteLine("The " + tree.Colour + " tree needs water");
				}
				else
				{
					Console.WriteLine("The " + tree.Colour + " tree doesnt need water");
				}
			}
			Console.WriteLine();
		}

		public void Water(double wateringAmount)
		{
			double sumOfgarden = trees.Count + flowers.Count;
			double dontFeedMe = 0;

			foreach (var flower in flowers)
			{
				if (flower.NeedsWater == false)
				{
					dontFeedMe += 1;
				}
			}

			foreach (var tree in trees)
			{
				if (tree.NeedsWater == false)
				{
					dontFeedMe += 1;
				}
			}

			sumOfgarden -= dontFeedMe;

			double individualWater = wateringAmount / sumOfgarden;

			foreach (var flower in flowers)
			{
				flower.WaterLvl += individualWater * 0.75;
				if (flower.WaterLvl >= 5)
				{
					flower.NeedsWater = false;
				}
			}

			foreach (var tree in trees)
			{
				tree.WaterLvl += individualWater * 0.4;
				if (tree.WaterLvl >= 10)
				{
					tree.NeedsWater = false;
				}
			}
			Status();
		}
	}
}