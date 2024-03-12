using System;
namespace Fibonacci
{
	public class FibonacciNumber
	{
        private static int n;

        public static int CalculateFibonacci(int n)
        {
            if(n == 0 || n == 1)
            return n;
            return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
        }
    }
}

