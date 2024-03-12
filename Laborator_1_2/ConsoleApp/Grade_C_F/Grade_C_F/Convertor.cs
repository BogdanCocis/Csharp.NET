using System;
namespace Grade_C_F
{
	public class Convertor
	{
		private double degreesC;
		private double degreesF;

		public static double CelsiusToF(double degreesC)
		{
			return (((degreesC*9)/5)+32);
		}

		public static double FToCelsius(double degreesF)
		{
			return ((degreesF - 32) * 5 / 9);
		}

    }
}

