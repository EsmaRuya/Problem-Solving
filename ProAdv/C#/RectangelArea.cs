// Write a program to calculate the rectangle area and print it on the screen.

using System;
public class ProAdv
{
    static float ReadNumbers()
    {
        float n;
        Console.Write($"Enter a number: ");
        while (!float.TryParse(Console.ReadLine(), out n))
        {
            Console.Write("Please enter a valid number: ");
        }
        return n;
    }

    static float calculateRectangleArea(ref float a, ref float b)
    {
        return a * b;
    }

    static void PrintResult(float area)
    {
        Console.WriteLine("Rectangle area = " + area);
    }

    public static void Main(string[] args)
    {
        float a = ReadNumbers();
        float b = ReadNumbers();

        PrintResult(calculateRectangleArea(ref a, ref b));
    }
}
