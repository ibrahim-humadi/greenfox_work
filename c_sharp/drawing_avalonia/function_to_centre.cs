//canvas size is 800 / 800

using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
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

			double posx = 0;
			double posy = 0;


			for (int i = 0; i <= 40; i++)
			{
				LineToCentre(posx, posy, foxDraw);
				posx += 20;
			}

			for (int i = 0; i <= 41; i++)
			{
				LineToCentre(posx, posy, foxDraw);
				posy += 20;
			}

			for (int i = 0; i <= 43; i++)
			{
				LineToCentre(posx, posy, foxDraw);
				posx -= 20;
			}

			for (int i = 0; i <= 44; i++)
			{
				LineToCentre(posx, posy, foxDraw);
				posy -= 20;
			}
		}

		public void LineToCentre(double posx, double posy, FoxDraw foxdraw)
		{ 
			foxdraw.DrawLine(posx, posy, 400, 400);
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}