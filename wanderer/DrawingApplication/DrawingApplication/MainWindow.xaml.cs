using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;
using GreenFox;

namespace DrawingApplication
{
	public class MainWindow : Window
	{
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

			Map newMap = new Map();

			foreach (var item in tiles)
			{
				newMap.Add(item);
			}

			

			DrawMap(foxDraw, newMap, newMap.ReadMapFile(foxDraw));
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
						map.tiles[k].Source = new Bitmap("./assets/wall.png");
					}
					else
					{
						map.tiles[k].Source = new Bitmap("./assets/floor.png");
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
