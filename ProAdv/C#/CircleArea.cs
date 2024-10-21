// Write a program to calculate the circle area, then print it on the screen.
using System;
public class ProAdv
{
    static double ReadRadious()
    {
        double n;
        Console.Write("Enter r (radious) : ");
        while (!double.TryParse(Console.ReadLine(), out n))
        {
            Console.Write("Please enter a valid number: ");
        }
        return n;
    }

    static double calculateCircleArea(double r)
    {
        return (3.14 * Math.Pow(r, 2));
    }

    static void PrintResult(double area)
    {
        Console.WriteLine("Circle area = " + area);
    }

    public static void Main(string[] args)
    {
        PrintResult(calculateCircleArea(ReadRadious()));
    }
}
