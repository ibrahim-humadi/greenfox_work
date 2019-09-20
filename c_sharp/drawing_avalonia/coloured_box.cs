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

			var startPointTop = new Point(200, 200);
			var endPointTop = new Point(600, 200);

			var startPointLeft = new Point(200, 200);
			var endPointLeft = new Point(200, 600);

			var startPointRight = new Point(600, 200);
			var endPointRight = new Point(600, 600);

			var startPointBottom = new Point(200, 600);
			var endPointBottom = new Point(600, 600);

			foxDraw.SetStrokeColor(Colors.Red);
			foxDraw.DrawLine(startPointTop, endPointTop);

			foxDraw.SetStrokeColor(Colors.Blue);
			foxDraw.DrawLine(startPointLeft, endPointLeft);

			foxDraw.SetStrokeColor(Colors.Yellow);
			foxDraw.DrawLine(startPointRight, endPointRight);

			foxDraw.SetStrokeColor(Colors.Green);
			foxDraw.DrawLine(startPointBottom, endPointBottom);


		}

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}