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

			var centrepoint = new Point(400, 400);
			double firstPointX = 100;
			double firstPointY = 140;

			for (int i = 0; i < 3; i++)
			{
				
				LineToCentre(firstPointX, firstPointY, centrepoint);
				firstPointX += 100;
				firstPointY += 100;

				
			}
			
		}

		public void LineToCentre(double x , double y , Point centre)
		{
			var canvas = this.Get<Canvas>("canvas");
			var foxDraw = new FoxDraw(canvas);

			var startPoint = new Point(x, y);
			Point centrePoint = centre;

			foxDraw.DrawLine(startPoint, centrePoint);
		}

		private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}