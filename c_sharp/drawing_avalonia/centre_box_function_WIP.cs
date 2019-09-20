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

			foxDraw.DrawLine(400, 0, 400, 800);
			foxDraw.DrawLine(0, 400, 800, 400);


			double size = 50;

			for (int i = 0; i < 2; i++)
			{
				createSquare(size, foxDraw);
				size += 100;
			}
		}

		public void createSquare(double size, FoxDraw foxdraw)
		{
			double posx = 375;
			double posy = 375;

			for (int i = 0; i < 1; i++)
			{
				foxdraw.SetFillColor(Colors.Transparent);
				foxdraw.DrawRectangle(posx, posy, size, size);
				posx += 200;
				posy += 200;
				
			}
			
		}

		private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}