using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Input;
using Avalonia.Media.Imaging;
using GreenFox;
using System;

namespace DrawingApplication
{
	public class MainWindow : Window
	{
		Player mainPlayer = new Player();
		Tile playerTile = new Tile();
		int playerPosX = 72;
		int playerPosY = 72;
		int playerIndexHor = 1;
		int playerIndexVert = 1;
		Map newMap = new Map();
		FoxDraw foxDraw;


		public MainWindow()
		{
			InitializeComponent();
#if DEBUG
			this.AttachDevTools();
#endif
			var canvas = this.Get<Canvas>("canvas");
			var foxDraw = new FoxDraw(canvas);

			Tile[] tiles = new Tile[100];

			for (int i = 0; i < tiles.Length; i++)
			{
				tiles[i] = new Tile();
			}

			foreach (var item in tiles)
			{
				newMap.Add(item);
			}

			DrawMap(foxDraw, newMap, newMap.ReadMapFile(foxDraw));

			mainPlayer.DrawPlayer(foxDraw, newMap, playerTile);

			this.KeyUp += MainWindow_KeyUp;

		}

		public void MoveRight(Tile playerTile)
		{
			if (CollisionRight(foxDraw, newMap, playerIndexHor, playerIndexVert) == false)
			{
				playerPosX += 72;
				Canvas.SetLeft(playerTile, playerPosX);
				playerIndexHor += 1;
			}
			else
			{

			}

		}

		public bool CollisionRight(FoxDraw foxDraw, Map map,int playerIndexHor, int playerIndexY)
		{
			bool collision = true;
			int[,] layoutMap = map.ReadMapFile(foxDraw);
			int indexHor = playerIndexHor + 1;
			int indexVert = playerIndexVert;

			if (layoutMap[indexVert,indexHor] == 0)
			{
				collision = false;
			}
			else
			{
				collision = true;
			}
			return collision;
		}

		public void MoveLeft(Tile playerTile)
		{
			if (CollisionLeft(foxDraw, newMap, playerIndexHor, playerIndexVert) == false)
			{
				playerPosX -= 72;
				Canvas.SetLeft(playerTile, playerPosX);
				playerIndexHor -= 1;
				
			}
			else
			{

			}
		}

		public bool CollisionLeft(FoxDraw foxDraw, Map map, int playerIndexHor, int playerIndexY)
		{
			bool collision = true;
			int[,] layoutMap = map.ReadMapFile(foxDraw);
			int indexHor = playerIndexHor - 1;
			int indexVert = playerIndexVert;

			if (layoutMap[indexVert, indexHor] == 0)
			{
				collision = false;
			}
			else
			{
				collision = true;
			}
			return collision;
		}

		public void MoveUp(Tile playerTile)
		{
			if (CollisionUp(foxDraw, newMap, playerIndexHor, playerIndexVert) == false)
			{
				playerPosY -= 72;
				Canvas.SetTop(playerTile, playerPosY);
				playerIndexVert -= 1;

			}
			else
			{

			}
		}

		public bool CollisionUp(FoxDraw foxDraw, Map map, int playerIndexHor, int playerIndexY)
		{
			bool collision = true;
			int[,] layoutMap = map.ReadMapFile(foxDraw);
			int indexHor = playerIndexHor;
			int indexVert = playerIndexVert - 1;

			if (layoutMap[indexVert, indexHor] == 0)
			{
				collision = false;
			}
			else
			{
				collision = true;
			}
			return collision;
		}

		public void MoveDown(Tile playerTile)
		{
			if (CollisionDown(foxDraw, newMap, playerIndexHor, playerIndexVert) == false)
			{
				playerPosY += 72;
				Canvas.SetTop(playerTile, playerPosY);
				playerIndexVert += 1;
			}
			else
			{
				
			}
		}

		public bool CollisionDown(FoxDraw foxDraw, Map map, int playerIndexHor, int playerIndexY)
		{
			bool collision = true;
			int[,] layoutMap = map.ReadMapFile(foxDraw);
			int indexHor = playerIndexHor;
			int indexVert = playerIndexVert + 1;

			if (layoutMap[indexVert, indexHor] == 0)
			{
				collision = false;
			}
			else
			{
				collision = true;
			}
			return collision;
		}

		private void MainWindow_KeyUp(object sender, Avalonia.Input.KeyEventArgs e)
		{
			
			switch (e.Key)
			{
				case Key.D:
					MoveRight(playerTile);

					break;
				case Key.A:
					MoveLeft(playerTile);

					break;
				case Key.W:
					MoveUp(playerTile);

					break;
				case Key.S:
					MoveDown(playerTile);

					break;
			}
		}

		public void DrawMap(FoxDraw foxDraw, Map map, int[,] result)
		{
			int x = 0;
			int y = 0;
			int k = 0;

			for (int i = 0; i < 10; i++)
			{
				x = 0;
				for (int j = 0; j < 10; j++)
				{
					if (result[i, j] == 0)
					{
						map.tiles[k].Source = new Bitmap("./assets/floor.png");
					}
					else
					{
						map.tiles[k].Source = new Bitmap("./assets/wall.png");
					}

					map.AddFloorImage(foxDraw, map.tiles[k], map.GetCor(x), map.GetCor(y));
					x += 1;

					if (k < map.tiles.Count - 1)
					{
						k += 1;
					}
				}
				y += 1;
			}
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
