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

			List <string> dotsSquare = new List<string>();
			dotsSquare.Add("9,10");
			dotsSquare.Add("290,10");
			dotsSquare.Add("290,290");
			dotsSquare.Add("10,290");
			dotsSquare.Add("9,10");

			ConnectDotsSquare(dotsSquare, foxDraw);

			List<string> dotsPolygon = new List<string>();
			dotsPolygon.Add("50,100");
			dotsPolygon.Add("70,70");
			dotsPolygon.Add("80,90");
			dotsPolygon.Add("90,90");
			dotsPolygon.Add("100,70");
			dotsPolygon.Add("120,100");
			dotsPolygon.Add("85,130");
			dotsPolygon.Add("50,100");

			ConnectDotsPolygon(dotsPolygon, foxDraw);
		}

		public void ConnectDotsSquare(List <string> dots, FoxDraw foxDraw)
		{
			for (int i = 0; i < dots.Count - 1; i++)
			{
				char[] dot1seperator = { ',' };
				string[] dot1list = dots[0+i].Split(dot1seperator);

				double dot1posx = double.Parse(dot1list[0]);
				double dot1posy = double.Parse(dot1list[1]);

				char[] dot2seperator = { ',' };
				string[] dot2list = dots[1+i].Split(dot2seperator);

				double dot2posx = double.Parse(dot2list[0]);
				double dot2posy = double.Parse(dot2list[1]);

				foxDraw.DrawLine(dot1posx, dot1posy, dot2posx, dot2posy);
			}
		}

		public void ConnectDotsPolygon(List<string> dots, FoxDraw foxDraw)
		{
			for (int i = 0; i < dots.Count - 1; i++)
			{
				char[] dot1seperator = { ',' };
				string[] dot1list = dots[0 + i].Split(dot1seperator);

				double dot1posx = double.Parse(dot1list[0]);
				double dot1posy = double.Parse(dot1list[1]);

				char[] dot2seperator = { ',' };
				string[] dot2list = dots[1 + i].Split(dot2seperator);

				double dot2posx = double.Parse(dot2list[0]);
				double dot2posy = double.Parse(dot2list[1]);

				foxDraw.DrawLine(dot1posx, dot1posy, dot2posx, dot2posy);
			}
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}