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

			double posx = 230;
			double posy = 230;

			foxDraw.DrawLine(400, 0, 400, 800);
			foxDraw.DrawLine(0, 400, 800, 400);

			double size = 350;
			Avalonia.Media.Color[] colour_palette = { Colors.Green, Colors.Blue, Colors.Yellow };
			for (int i = 0; i < 3; i++)
			{
				foxDraw.SetFillColor(colour_palette[0+i]);
				CreateSquare(posx, posy, size, foxDraw);
				size -= 100;
				posx += 50;
				posy += 50;
			}
		}

		public void CreateSquare(double posx, double posy, double size, FoxDraw foxdraw)
		{
				foxdraw.DrawRectangle(posx, posy, size, size);
		}

		private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}