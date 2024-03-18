using System;
namespace ex2_Calcule
{
	public class Calculator
	{
		private char action;

		public static double Add(double number1, double number2)
		{
			return number1 + number2;
		}

		public static double Diference(double number1, double number2)
		{
            return number1 - number2;
        }

		public static double Multiply(double number1, double number2)
		{
            return number1 * number2;
        }

		public static double Division(double number1, double number2)
		{            
            return number1 / number2;
        }

        public static void Display(double number1, double number2, double result, char operation)
        {
            Console.WriteLine("number1 {0} number2 = {1}", operation, result);
        }

    }
}

