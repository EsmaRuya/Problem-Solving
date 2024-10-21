// Write a program to calculate the circle area through the diameter, then print it on the screen.
using System;
public class ProAdv
{
    static double ReadDaiameter()
    {
        double n;
        Console.Write("Enter d (diameter) : ");
        while (!double.TryParse(Console.ReadLine(), out n))
        {
            Console.Write("Please enter a valid number: ");
        }
        return n;
    }

    static double calculateCircleAreaByDiameter(double d)
    {
        return ((3.14 * Math.Pow(d, 2)) / 4);
    }

    static void PrintResult(double area)
    {
        Console.WriteLine("Circle area = " + area);
    }

    public static void Main(string[] args)
    {
        PrintResult(calculateCircleAreaByDiameter(ReadDaiameter()));
    }
}
