using System;
using System.Collections.Generic;
using System.Text;

namespace sharpie
{
	class Sharpie
	{
		public string Color { get; set; }
		public float SharpWidth { get; set; }
		public float InkAmount { get; set; }

		public Sharpie(String sharpColor, float sharpWidth, float inkAmount = 100)
		{
			this.Color = sharpColor;
			this.SharpWidth = sharpWidth;
			this.InkAmount = inkAmount;
		}

		public void Use()
		{
			InkAmount -= 1;
		}
	}
}
