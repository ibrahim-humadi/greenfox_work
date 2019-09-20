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

			double startX = 100;
			double startY = 100;

			for (int i = 0; i < 3; i++)
			{
				createSquare(startX, startY, foxDraw);
				startX += 150;
				startY += 150;
			}
		}

		public void createSquare(double x, double y, FoxDraw foxdraw)
		{
			foxdraw.DrawLine(x, y, x + 50, y);
			foxdraw.DrawLine(x, y, x, y + 50);
			foxdraw.DrawLine(x, y + 50, x + 50, y + 50);
			foxdraw.DrawLine(x + 50, y, x + 50, y + 50);
		}

		private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}