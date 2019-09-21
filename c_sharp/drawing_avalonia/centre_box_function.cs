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

			double posx = 375;
			double posy = 375;

			foxDraw.DrawLine(400, 0, 400, 800);
			foxDraw.DrawLine(0, 400, 800, 400);


			double size = 50;

			for (int i = 0; i < 3; i++)
			{
				CreateSquare(posx, posy, size, foxDraw);
				size += 100;
				posx -= 50;
				posy -= 50;
			}
		}

		public void CreateSquare(double posx, double posy, double size, FoxDraw foxdraw)
		{
				foxdraw.SetFillColor(Colors.Transparent);
				foxdraw.DrawRectangle(posx, posy, size, size);

		}

		private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}