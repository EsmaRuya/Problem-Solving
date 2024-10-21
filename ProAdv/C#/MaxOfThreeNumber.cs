// Write a program to ask the user to enter 3 numbers, then print the max one.

using System;
public class ProAdv
{
    static int[] ReadNumber()
    {
        int[] n = new int[3];
        for (int i = 0; i < n.Length; i++)
        {
            Console.Write($"Enter a number: ");
            while (!int.TryParse(Console.ReadLine(), out n[i]))
            {
                Console.Write("Please enter a valid number: ");
            }
        }
        return n;
    }

    static int MaxOfThreeNumbers(int[] n)
    {
        if (n[0] > n[1])
        {
            if (n[0] > n[2])
                return n[0];
            else
                return n[2];
        }
        if (n[1] > n[2])
            return n[1];
        else
            return n[2];
    }

    static void PrintResult(int max)
    {
        Console.WriteLine("Max number is = " + max);
    }


    public static void Main(string[] args)
    {
        PrintResult(MaxOfThreeNumbers(ReadNumber()));
    }
}
