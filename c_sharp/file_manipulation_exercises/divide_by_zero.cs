using System;

namespace drawing_application
{
	class Program
	{
		static void Main(string[] args)
		{
			double myNumber = UserNumber();

			try
			{
				DivideByTen(myNumber);
			}
			catch (Exception errorDivZero)
			{
				Console.Error.WriteLine(errorDivZero);
				Console.WriteLine("Please try another number");
				throw;
			}
		}

		public static double UserNumber()
		{
			Console.WriteLine("Please enter a number to be divided by 10");
			Console.WriteLine();
			double userinput = Convert.ToDouble(Console.ReadLine());
			return userinput;
		}

		public static void DivideByTen(double number)
		{
			double resultOfDivision = number / 10;

			if (resultOfDivision == 0)
			{
				throw new Exception("Attempted to divide input number by 0");
			}

			Console.WriteLine(resultOfDivision);
		}
	}
}
