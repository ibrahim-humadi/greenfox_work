using System;

namespace project_1
{
	class Program
	{
		public class PostIt
		{
			public string BackgroundColor { get; set; }
			public string TextArea {get; set;}
			public string TextColor { get; set; }

			public PostIt(String backGroundColour, string textArea, string textColor)
			{
				this.BackgroundColor = backGroundColour;
				this.TextArea = textArea;
				this.TextColor = textColor;
			}
		}

		static void Main(string[] args)
		{
			PostIt postit1 = new PostIt("orange", "Idea 1", "blue");
			PostIt postit2 = new PostIt("pink", "Awesome", "black");
			PostIt postit3 = new PostIt("yellow", "Superb!", "green");

			Console.WriteLine("An " + postit1.BackgroundColor + " post-it note with " + postit1.TextArea + " written on it in " + postit1.TextColor + " ink.");
			Console.WriteLine("An " + postit2.BackgroundColor + " post-it note with " + postit2.TextArea + " written on it in " + postit2.TextColor + " ink.");
			Console.WriteLine("An " + postit3.BackgroundColor + " post-it note with " + postit3.TextArea + " written on it in " + postit3.TextColor + " ink.");
		}
	}
}