using System;
using idealWeith;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter height (cm)");
        double height = Double.Parse(Console.ReadLine());

        Console.WriteLine("Enter your age: ");
        double age = Double.Parse(Console.ReadLine());
    
        Console.WriteLine("Enter gender (M/m or F/f)");
        char sex = Char.Parse(Console.ReadLine());

        idealWeight.display(height, age, sex);

        Console.ReadKey();

    }
}