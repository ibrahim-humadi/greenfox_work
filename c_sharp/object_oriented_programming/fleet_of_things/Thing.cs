using System;

namespace FleetOfThings
{
	public class Thing
	{
		private string name;
		private bool completed;

		public Thing(string name)
		{
			this.name = name;
		}

		public void Complete()
		{
			completed = true;
		}

		public void Print(Thing thing)
		{
			if (thing.completed == true)
			{
				Console.Write("[X]");
			}
			else
			{
				Console.Write("[ ]");
			}
			Console.Write(" " + thing.name);
			Console.WriteLine();
		}
	}
}