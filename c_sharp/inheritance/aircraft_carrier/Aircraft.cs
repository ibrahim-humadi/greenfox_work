using System;
using System.Collections.Generic;
using System.Text;

namespace aircraft_carrier
{
	class Aircraft
	{
		public string AirType { get; set; }
		public int Ammo { get; set; }
		public bool IsAPriorty { get; set; }

		public Aircraft(string airType = "F16", int ammo = 0, bool isAPriorty = false)
		{
			this.AirType = airType;
			this.Ammo = ammo;
			this.IsAPriorty = isAPriorty;
		}

		public string TypeIs()
		{
			return AirType;
		}

		public bool IsPriorty()
		{
			return IsAPriorty;
		}

		public int Refill(int ammoIn)
		{
			int ammoOut = 0;


			return ammoOut
		}
	}

	class FSixteen : Aircraft
	{

	}

	class FThirtyFive : Aircraft
	{
		public FThirtyFive(string airType = "F35")
		{
			this.AirType = airType;
		}
	}
}
