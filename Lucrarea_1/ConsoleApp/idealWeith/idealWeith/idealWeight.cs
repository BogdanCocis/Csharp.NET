using System;
namespace idealWeith
{
	public class idealWeight
	{
		public static double idealWeightMen(double height, double age)
		{
			return (((height-100)-((height-150)/4))+((age-20)/4));
		}

		public static double idealWeightWoman(double height, double age)
		{
			return (((height - 100) - ((height-150)/2.5))+((age-20)/6));
		}

		public static void display(double height, double age, Char sex)
		{
			Console.WriteLine("For a person of sex {0} with height {1} and age of {2}", sex, height, age);
			if (sex == 'M' || sex == 'm')
				Console.WriteLine("The ideal weight is {0:F2} kg", idealWeightMen(height, age));
			else if (sex == 'F' || sex == 'f')
				Console.WriteLine("The ideal weight is {0:F2} kg", idealWeightWoman(height, age));
			else
				Console.WriteLine("Please enter the correct gender (M/m or F/f)");
        }
    }
}

