using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using GreenFox;
using Avalonia.Controls;




using Avalonia.Media.Imaging;

namespace DrawingApplication
{
	class Player
	{
		public int Health { get; set; } 
		public Tile PlayerSprite { get; private set; }

		public Player( int health = 100)
		{
			this.Health = health;
		}

		public void DrawPlayer(FoxDraw foxDraw, Map map, Tile playerTile)
		{
			
			playerTile.Source = new Bitmap("./assets/hero-down.png");
			foxDraw.AddImage(playerTile, map.GetCor(1), map.GetCor(1));
		}

		
	}
}
