using System;
using System.Collections.Generic;
using System.Text;

namespace post_it
{
	public class PostIt
	{
		public string BackgroundColor { get; set; }
		public string TextArea { get; set; }
		public string TextColor { get; set; }

		public PostIt(String backGroundColour, string textArea, string textColor)
		{
			this.BackgroundColor = backGroundColour;
			this.TextArea = textArea;
			this.TextColor = textColor;
		}
	}
}
