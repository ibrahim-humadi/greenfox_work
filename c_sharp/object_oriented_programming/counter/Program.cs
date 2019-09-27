using System;

namespace counter
{
	class Program
	{
		static void Main(string[] args)
		{
			Counter firstCounter = new Counter();

			Console.WriteLine("Value = " + firstCounter.Value + " and Reset value = " + firstCounter.Resetvalue);

			firstCounter.AddNumber(5);

			Console.WriteLine("Value = " + firstCounter.Value + " and Reset value = " + firstCounter.Resetvalue);

			firstCounter.Add();

			Console.WriteLine("Value = " + firstCounter.Value + " and Reset value = " + firstCounter.Resetvalue);

			firstCounter.Add();

			Console.WriteLine("Value = " + firstCounter.Value + " and Reset value = " + firstCounter.Resetvalue);

			firstCounter.Reset();

			Console.WriteLine("Value = " + firstCounter.Value + " and Reset value = " + firstCounter.Resetvalue);



		}
	}
}
