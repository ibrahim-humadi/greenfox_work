using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
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

			double posx = 400;
			double posy = 10;
			double pyrmaidHeight = 20;
			double triangleNum = 1;
			double multiplier = 1;

			for (int i = 0; i < pyrmaidHeight; i++)
			{
				posx -= 20;
				posy += 30;

				for (int j = 0; j < triangleNum; j++)
				{
					upTriangle(posx, posy, foxDraw);
					posx += 40;
				}
				posx -= 40 * multiplier;
				multiplier += 1;
				triangleNum += 1;
			}
		}

		public void upTriangle(double posx, double posy, FoxDraw foxDraw)
		{
			Point pointA = new Point(posx, posy);
			Point pointB = new Point(posx + 40, posy);
			Point pointC = new Point(posx + 20, posy - 30);

			foxDraw.DrawLine(pointA, pointB);
			foxDraw.DrawLine(pointA, pointC);
			foxDraw.DrawLine(pointB, pointC);
		}

		private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}