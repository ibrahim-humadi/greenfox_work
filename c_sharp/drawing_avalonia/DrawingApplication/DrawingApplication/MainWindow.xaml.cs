using System;
using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Threading;
using Avalonia.Input;
using GreenFox;


namespace DrawingApplication
{
	public class MainWindow : Window
	{
		public int i = 0;
		public int x = 0;
		public int y = 0;

		Image myFox = new Image();
		FoxDraw foxDraw;
		Canvas canvas;
		DispatcherTimer gameClock;

		public MainWindow()
		{
			InitializeComponent();
#if DEBUG
			this.AttachDevTools();
#endif
			canvas = this.Get<Canvas>("canvas");
			foxDraw = new FoxDraw(canvas);

			DispatcherTimer gameClock = new DispatcherTimer();
			gameClock.Interval = new System.TimeSpan(0, 0, 0, 0, 500);
			
			gameClock.Tick += delegate
			{
			};

			gameClock.Start();

			foxDraw.SetBackgroundColor(Colors.Black);

			myFox.Source = new Bitmap("image.png");


			foxDraw.AddImage(myFox, 0, 0);
			
			foxDraw.SetStrokeColor(Colors.White);
			foxDraw.DrawLine(100, 100, 400, 400);
			
		}

		public class LoadStuff
		{
			public List<Image> loadImages { get; set; }
			public double corX { get; set; }
			public double corY { get; set; }

			public LoadStuff()
			{
				this.loadImages = new List<Image>();
				this.corX = corX;
				this.corY = corY;
			}

			public void Add(Image image)
			{
				loadImages.Add(image);
			}
		}

		public void MoveRight()
		{

			
		}




		public class UnLoadStuff
		{
			public List<Image> unloadImages { get; set; }
			public double corX { get; set; }
			public double corY { get; set; }

			public UnLoadStuff()
			{
				this.unloadImages = new List<Image>();
				this.corX = corX;
				this.corY = corY;
			}

			public void Add(Image image)
			{
				unloadImages.Add(image);
			}
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			switch (e.Key)
			{
				case Key.D:
					x += 10;
					Canvas.SetLeft(myFox, x);
					break;
				case Key.A:
					x -= 10;
					Canvas.SetLeft(myFox, x);
					break;
				case Key.W:
					y -= 10;
					Canvas.SetTop(myFox, y);
						break;
				case Key.S:
					y += 10;
					Canvas.SetTop(myFox, y);
					break;
			}
		}

		public void OnTick()
		{
			i++;
			if (i % 2==0)
			{
				//foxDraw.RemoveImage(myFox);
				//foxDraw.AddImage(myFox, 0 + i * 5, 0 + i * 5);
				for (int i = 0; i < 8; i++)
				{
					myFox.Source = new Bitmap("fox_walk_right_4.png");
				}


			}
			else
			{
			}
		}
		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}