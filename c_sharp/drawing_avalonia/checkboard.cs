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
			double size = 20;


			for (int row = 0; row < 20; row++)
			{
				for (int i = 0; i < 20; i++)
				{
					foxDraw.SetFillColor(Colors.Purple);
					createSquare(posx, posy, size, foxDraw);
					posx += 20;
					foxDraw.SetFillColor(Colors.Transparent);
					createSquare(posx, posy, size, foxDraw);
					posx += 20;
				}

				posy += 20;

				for (int j = 0; j < 20; j++)
				{
					posx -= 20;
					foxDraw.SetFillColor(Colors.Purple);
					createSquare(posx, posy, size, foxDraw);
					posx -= 20;
					foxDraw.SetFillColor(Colors.Transparent);
					createSquare(posx, posy, size, foxDraw);
				}

				posy += 20;
			}

		}

		public void createSquare(double posx, double posy, double size, FoxDraw foxdraw)
		{
				foxdraw.DrawRectangle(posx, posy, size, size);
		}

		private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}