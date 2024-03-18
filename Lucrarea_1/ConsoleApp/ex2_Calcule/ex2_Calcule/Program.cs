
using System;
using ex2_Calcule;

class Program
{
    public static void Main(string [] args)
    {
        Calculator calculator = new Calculator();
        Console.WriteLine("Enter first number: ");
        double number1 = Double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double number2 = Double.Parse(Console.ReadLine());
        Console.WriteLine("Desired operation: ");
        char operation = char.Parse(Console.ReadLine());
        switch (operation)
        {
            case '+':
                Calculator.Display(number1, number2,Calculator.Add(number1, number2), operation);
                    break;
            case '-':
                Calculator.Display(number1, number2, Calculator.Diference(number1, number2), operation);
                break;
            case '*':
                Calculator.Display(number1, number2, Calculator.Multiply(number1, number2), operation);
                break;
            case '/':
                Calculator.Display(number1, number2, Calculator.Division(number1, number2), operation);
                break;
            default:
                Console.WriteLine("Wrong operation!");
                break;
        }
        Console.ReadKey();
    }
}

