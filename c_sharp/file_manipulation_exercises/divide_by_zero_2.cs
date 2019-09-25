using System;

namespace drawing_application
{
	class Program
	{
		static void Main(string[] args)
		{
			WaitForNumber();
		}

		static void WaitForNumber()
		{
			int myNumber = UserNumber(); // my number = user inputted number.

			try
			{
				DivideByTen(myNumber);
			}
			catch (DivideByZeroException myError)
			{
				Console.Error.WriteLine(myError);
				WaitForNumber();
			}
		}

		public static int UserNumber()
		{
			Console.WriteLine();
			int userinput = Convert.ToInt32(Console.ReadLine());
			return userinput;
		}

		public static void DivideByTen(int number)
		{
			int resultOfDivision = 10 / number;

			if (resultOfDivision == 0)
			{
				throw new DivideByZeroException("Attempted to divide input number by 0");
			}

			Console.WriteLine(resultOfDivision);
		}
	}
}
