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

			double posx = 25;
			double posy = 25;
			double size = 25;
			double multiplier = 1;

			foxDraw.SetFillColor(Colors.Purple);
			for (int i = 0; i <= 3; i++)
			{
				CreateSquare(posx, posy, size, foxDraw);
				posx += 25*multiplier;
				posy += 25*multiplier;
				size *= 2;
				multiplier *= 2;
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