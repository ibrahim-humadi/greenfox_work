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

			double x = 100;
			double y = 100;
			int col = 1;

			for (int i = 0; i <= 3; i++)
			{

				if (col == 1)
				{
					foxDraw.SetFillColor(Colors.Green);
				}
				else if (col == 2)
				{
					foxDraw.SetFillColor(Colors.Blue);
				}
				else if (col == 3)
				{
					foxDraw.SetFillColor(Colors.Yellow);
				}
				else
				{
					foxDraw.SetFillColor(Colors.Red);
				}

				foxDraw.DrawRectangle(x, y, 40, 40);
				x += 100;
				y += 100;
				col += 1;
			}
		}


		private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}