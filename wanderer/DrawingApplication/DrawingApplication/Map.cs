using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Media;
using System;
using System.Collections.Generic;
using System.IO;
using Avalonia.Media.Imaging;
using GreenFox;

namespace DrawingApplication
{
	public class Tile : Image
	{

	}

	public class Map
	{
		public List<Tile> tiles { get; set; }
		public Map()
		{
			tiles = new List<Tile>();
		}

		public void Add(Tile tile)
		{
			tiles.Add(tile);
		}

		public int GetCor(int input)
		{
			int[] cord = new int[10];

			for (int l = 0; l < 10; l++)
			{
				cord[l] = l * 72;
			}
			return cord[input];
		}

		public int[,] ReadMapFile(FoxDraw foxDraw)
		{
			string input = File.ReadAllText(@"C:\Users\tiglath\projects\wanderer\DrawingApplication\DrawingApplication\bin\Debug\netcoreapp2.1\assets\map.txt");
			int i = 0;
			int j = 0;
			int[,] result = new int[10, 10];

			Tile[] tiles = new Tile[100];

			foreach (var row in input.Split('\n'))
			{
				j = 0;
				foreach (var col in row.Trim().Split(' '))
				{
					result[i, j] = int.Parse(col.Trim());
					j++;
				}
				i++;
			}

			return result;
		}

		public void AddFloorImage(FoxDraw foxDraw, Tile myImage, int xCord, int yCord)
		{
			foxDraw.AddImage(myImage, xCord, yCord);
		}
	}
}
