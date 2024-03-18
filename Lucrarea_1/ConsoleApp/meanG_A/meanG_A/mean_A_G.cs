using System;

namespace meanG_A
{
	public class mean_A_G
	{
		public static void meanAG()
		{
            Console.WriteLine("The number of numbers: ");
			int n = int.Parse(Console.ReadLine());
			int[] a = new int[n];
			double meanA = 0;
			double meanG = 0;
			double sum = 0;
			double pro = 1;

			for(int i = 0; i < n; i++)
			{
                Console.WriteLine("Enter number {0}: ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
			}

			for(int i = 0; i < n; i++)
			{
				sum += a[i];
			}
			meanA = sum / n;

			for (int i = 0; i < n; i++)
			{
				pro *= a[i];
			}
			meanG = Math.Sqrt(pro);

			Console.WriteLine("The arithmetic mean is = {0:F2}", meanA);
			Console.WriteLine("The geometric mean is = {0:F2}", meanG);
			Console.ReadKey();
		}
	}
}

