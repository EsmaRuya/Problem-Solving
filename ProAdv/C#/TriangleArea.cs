// Write a program to calculate the triangle area, then print it on the screen.

using System;
public class ProAdv
{
    static float ReadNumbers(string t)
    {
        float n;
        Console.Write(t);
        while (!float.TryParse(Console.ReadLine(), out n))
        {
            Console.Write("Please enter a valid number: ");
        }
        return n;
    }

    static float calculateTriangleArea(float a, float h)
    {
        return ((a / 2) * h);
    }

    static void PrintResult(float area)
    {
        Console.WriteLine("Triangle area = " + area);
    }

    public static void Main(string[] args)
    {
        float a = ReadNumbers("Enter a : ");
        float h = ReadNumbers("Enter h : ");

        PrintResult(calculateTriangleArea(a, h));
    }
}
