//canvas size is 800 / 800

using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System.Collections.Generic;

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

			int starnum = 100;

			foxDraw.SetBackgroundColor(Colors.Black);

			for (int i = 0; i < starnum; i++)
			{
				CreateSquare(starnum, GetRandomNumber(0,800), GetRandomNumber(0,800), foxDraw);
			}
		}

		public double GetRandomNumber(double randomMin, double randomMax)
		{
			System.Random randomNum = new System.Random();
			return randomNum.NextDouble() * (randomMax - randomMin) + randomMin;
		}

		public void CreateSquare(int starnum, double x, double y, FoxDraw foxdraw)
		{
			Avalonia.Media.Color[] coloursList = { Colors.Gray, Colors.LightSlateGray, Colors.SlateGray, Colors.DarkSlateGray };

			for (int i = 0; i < starnum; i++)
			{
				for (int colorNum = 0; colorNum < coloursList.Length; colorNum++)
				{
					foxdraw.SetFillColor(coloursList[colorNum]);
				}
				foxdraw.DrawRectangle(x, y, 5, 5);
			}
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}