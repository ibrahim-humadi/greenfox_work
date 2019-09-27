using System;
using System.Collections.Generic;

namespace FleetOfThings
{
	public class Fleet
	{
		public List<Thing> things { get; set; }

		public Fleet()
		{
			things = new List<Thing>();
		}

		public void Add(Thing thing)
		{
			things.Add(thing);
		}
	}
}