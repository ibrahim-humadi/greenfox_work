using System;

namespace DiceSet
{
	public class DiceSet
	{
		private Random randomValue = new Random();
		private int[] dice = new int[6];

		public int[] Roll()
		{
			for (int i = 0; i < dice.Length; i++)
			{
				dice[i] = randomValue.Next(1, 7);
			}

			return dice;
		}

		public int[] GetCurrent()
		{
			return dice;
		}

		public int GetCurrent(int i)
		{
			return dice[i];
		}

		public int GetSum(DiceSet diceSet)
		{
			int sum = 0;
			for (int i = 0; i <= dice.Length - 1; i++)
			{
				sum += diceSet.GetCurrent(i);
			}

			return sum;
		}

		public void WriteDice(DiceSet diceSet)
		{
			for (int i = 0; i < 6; i++)
			{
				Console.Write(diceSet.GetCurrent(0 + i));
			}
			Console.WriteLine();
		}

		public void Reroll()
		{
			for (int i = 0; i < dice.Length; i++)
			{
				dice[i] = randomValue.Next(1, 7);
			}
		}

		public void Reroll(int k)
		{
			dice[k] = randomValue.Next(1, 7);
		}
	}
}