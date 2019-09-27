using System;
using System.Collections.Generic;

namespace DiceSet
{
	class Program
	{
		public static void Main(string[] argv)
		{
			DiceSet diceSet = new DiceSet();
			do
			{
				diceSet.WriteDice(diceSet);
				diceSet.Reroll();

			} while (diceSet.GetSum(diceSet) != 36);
			diceSet.WriteDice(diceSet);
		}
	}
}