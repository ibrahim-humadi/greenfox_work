using System;
using System.Collections.Generic;
using System.Text;

namespace counter
{
	class Counter
	{
		public int Value { get; set; }
		public int Resetvalue { get; set; }

		public Counter (int resetValue = 0, int value = 0)
		{
			this.Resetvalue = resetValue;
			this.Value = value;
		}

		public void AddNumber(int number)
		{
			Value += number;
			Resetvalue += number;
		}

		public void Add()
		{
			Value++;
			Resetvalue++;
		}

		public void Reset()
		{
			Value -= Resetvalue;
			Resetvalue -= Resetvalue;
		}

		public string Get(int inputValue)
		{
			string equalString = "";
			equalString = Convert.ToString(inputValue);
			return equalString;
		}
	}
}
