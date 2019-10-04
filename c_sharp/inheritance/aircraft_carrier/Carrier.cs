using System;
using System.Collections.Generic;
using System.Text;

namespace aircraft_carrier
{
	class Carrier
	{
		public List<Aircraft> aircrafts { get; set; }

		public Carrier()
		{
			aircrafts = new List<Aircraft>();
		}

		public void Add(Aircraft aircraft)
		{
			aircrafts.Add(aircraft);
		}
	}
}
