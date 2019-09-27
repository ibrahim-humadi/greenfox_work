using System;

namespace FleetOfThings
{
	public class FleetOfThings
	{
		public static void Main(string[] args)
		{
			var fleetOne = new Fleet();

			var thingOne = new Thing("Get milk");
			var thingTwo = new Thing("Remove the obstacles");
			var thingThree = new Thing("Stand up");
			var thingFour = new Thing("Eat lunch");

			fleetOne.Add(thingOne);
			fleetOne.Add(thingTwo);
			thingThree.Complete();
			fleetOne.Add(thingThree);
			thingFour.Complete();
			fleetOne.Add(thingFour);

			foreach (var item in fleetOne.things)
			{
				item.Print(item);
			}
		}
	}
}