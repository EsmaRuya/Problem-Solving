// Write a program to calculate the circle area inscribed in a square, then print it on the screen.
using System;
public class ProAdv
{
    static double ReadSquareSide()
    {
        double n;
        Console.Write("Enter a (square side) : ");
        while (!double.TryParse(Console.ReadLine(), out n))
        {
            Console.Write("Please enter a valid number: ");
        }
        return n;
    }

    static double calculateCircleAreInscribedInASquare(double a)
    {
        return (3.14 * Math.Pow(a, 2)) / 4;
    }

    static void PrintResult(double area)
    {
        Console.WriteLine("Circle area = " + area);
    }

    public static void Main(string[] args)
    {
        PrintResult(calculateCircleAreInscribedInASquare(ReadSquareSide()));
    }
}
