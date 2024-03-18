using System;
using Grade_C_F;

class Program
{
    public static void Main(string[] args)
    {
        Convertor convertor = new Convertor();
        Console.WriteLine("If you want from G to F press: 1");
        Console.WriteLine("If you want from F to G press: 2");
        int option = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a value: ");
        double grade = Double.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                Console.WriteLine($"The value in G in F is = {Convertor.CelsiusToF(grade)} F");
                break;
            case 2:
                Console.WriteLine($"The value in F in G is = {Convertor.FToCelsius(grade)} C");
                break;
            default:
                Console.WriteLine("Wrong option");
                break;
        }
        Console.ReadKey();
    }
}

