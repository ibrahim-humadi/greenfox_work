using System;
using System.Collections.Generic;
using System.Text;

namespace linq_find_the_fox
{
	class Fox
	{
		public string Name { get; set; }
		public string Type { get; set; }
		public string Colour { get; set; }


		public Fox(string name = "Fantastic Mr", string type = "Pallida", string colour = "Brown")
		{
			this.Name = name;
			this.Type = type;
			this.Colour = colour;
		}




	}
}
