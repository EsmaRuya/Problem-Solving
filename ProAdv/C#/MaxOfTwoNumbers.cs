// Write a program to ask the user to enter 2 numbers, then print the max one.
// Don't use array

using System;
public class ProAdv
{
    static int ReadNumber()
    {
        int n;
        Console.Write($"Enter a number: ");
        while (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.Write("Please enter a valid number: ");
        }
        return n;
    }

    static int MaxOfTwo(int num1, int num2)
    {
        return (num1 > num2) ? num1 : num2;
    }

    static void PrintResult(int max)
    {
        Console.WriteLine("Max number is = " + max);
    }


    public static void Main(string[] args)
    {
        int num1 = ReadNumber();
        int num2 = ReadNumber();
        PrintResult(MaxOfTwo(num1, num2));
    }
}
