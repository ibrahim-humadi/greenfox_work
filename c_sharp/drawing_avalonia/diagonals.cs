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

			var startPointLine1 = new Point(0, 0);
			var endPointLine1 = new Point(800, 800);

			var startPointLine2 = new Point(0, 800);
			var endPointLine2 = new Point(800, 0);

			foxDraw.SetStrokeColor(Colors.Green);
			foxDraw.DrawLine(startPointLine1, endPointLine1);

			foxDraw.SetStrokeColor(Colors.Red);
			foxDraw.DrawLine(startPointLine2, endPointLine2);

		}

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}