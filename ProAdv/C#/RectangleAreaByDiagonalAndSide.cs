/*
Write a program to calculate the rectangle area through the diagonal
and side area of the rectangle, and print it on the screen.
*/

using System;
public class ProAdv
{
    static double ReadNumbers(string t)
    {
        double n;
        Console.Write(t);
        while (!double.TryParse(Console.ReadLine(), out n))
        {
            Console.Write("Please enter a valid number: ");
        }
        return n;
    }

    static double calculateRectangleAreaByDiagonalAndSide(double a, double d)
    {
        return (a * Math.Sqrt(Math.Pow(d, 2) - Math.Pow(a, 2)));
    }

    static void PrintResult(double area)
    {
        Console.WriteLine("Rectangle area = " + area);
    }

    public static void Main(string[] args)
    {
        double a = ReadNumbers("Enter a (side) : ");
        double d = ReadNumbers("Enter d (diagonal): ");

        PrintResult(calculateRectangleAreaByDiagonalAndSide(a, d));
    }
}
