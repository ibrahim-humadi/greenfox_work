using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fox_club.Models
{
	public class Fox
	{
		public string Name { get; set; }
		public string Food { get; set; }
		public string Drink { get; set; }
		public List<string> tricks { get; set; }

		public Fox(string name, string food, string drink)
		{
			tricks = new List<string>();
			this.Name = name;
			this.Food = food;
			this.Drink = drink;
		}
		
		public void AddTrick(string trick)
		{
			tricks.Add(trick);
		}

		public void RemoveTrick(string trick)
		{
			tricks.Remove(trick);
		}
	}
}
