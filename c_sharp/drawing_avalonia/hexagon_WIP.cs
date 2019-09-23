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
			double posy = 40;
			double hexHeight = 7;
			double hexNum = 6;
			double multiplier = 1;


			//posx += 40;
			//posy += 20;
			//hexagon(posx, posy, foxDraw);

			for (int i = 0; i < hexHeight; i++)
			{
				hexagon(posx, posy, foxDraw);
				posy += 40;
			}

			posx = 400;
			posy = 40;

			for (int j = 0; j < hexHeight; j++)
			{


				for (int k = 0; k < hexNum; k++)
				{
					posx += 40;
					posy += 20;
					hexagon(posx, posy, foxDraw);
					posx -= 40;
					posy += 20;
				}

				hexHeight -= 2;
				hexNum -= 1;
				posx += 40;
				posy -= 40;

			}



		}

		public void hexagon(double posx, double posy, FoxDraw foxDraw)
		{
			Point pointA = new Point(posx, posy);
			Point pointB = new Point(posx + 20, posy + 20);
			Point pointC = new Point(posx + 40, posy + 20);
			Point pointD = new Point(posx + 60, posy);
			Point pointE = new Point(posx + 40, posy - 20);
			Point pointF = new Point(posx + 20, posy - 20);

			foxDraw.DrawLine(pointA, pointB); //Side AB
			foxDraw.DrawLine(pointB, pointC); //Side BC
			foxDraw.DrawLine(pointC, pointD); //Side CD
			foxDraw.DrawLine(pointD, pointE); //Side DE
			foxDraw.DrawLine(pointE, pointF); //Side EF
			foxDraw.DrawLine(pointF, pointA); //Side FA

		}

		private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}