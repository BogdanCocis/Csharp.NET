using System;
using Fibonacci;

class Program
{
    static void Main(string[] args)
    {
        FibonacciNumber fibonaci = new FibonacciNumber();
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Fibonacci({i}) = {FibonacciNumber.CalculateFibonacci(i)}");

        }
        Console.ReadKey();
    }
}
