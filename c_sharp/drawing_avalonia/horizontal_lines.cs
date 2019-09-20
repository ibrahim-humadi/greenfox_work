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

			var startPoint = new Point(200, 200);

			double pos1 = startPoint.X;
			double pos2 = startPoint.Y;

			HorizontalLine(pos1,pos2,foxDraw);

			HorizontalLine(pos1+ 100, pos2 + 100, foxDraw);

			HorizontalLine(pos1 + 200, pos2 + 200, foxDraw);
		}

		public void HorizontalLine(double x, double y, FoxDraw foxdraw)

		{
			foxdraw.DrawLine(x, y, x + 50, y);
		}


		private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}