/*
Write a program to the ask user to enter : 3 marks, then print the average of the
entered marks, and print the "Pass" if the mark >= 50, otherwise print "Fail".

// Use enums
*/

using System;
public class ProAdv
{

    enum enPassFail { Pass = 1, Fail = 2 };

    static int[] ReadMarks()
    {
        int[] n = new int[3];
        for (int i = 0; i < n.Length; i++)
        {
            Console.Write($"Enter mark {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out n[i]) || n[i] < 0 || n[i] > 100)
            {
                Console.Write("Please enter a valid mark: ");
            }
        }
        return n;
    }

    static int SumOfThreeNumbers(int[] numbers)
    {
        return (numbers[0] + numbers[1] + numbers[2]);
    }

    static double CalculateAverage(int[] numbers)
    {
        return (double)SumOfThreeNumbers(numbers) / 3;
    }

    static enPassFail checkAverage(double average)
    {
        return (average >= 50) ? enPassFail.Pass : enPassFail.Fail;
    }

    static void PrintResult(double avrg)
    {
        Console.WriteLine("Your average = " + avrg);
        if (checkAverage(avrg) == enPassFail.Pass)
            Console.WriteLine("You passed.");
        else
            Console.WriteLine("You failed.");
    }


    public static void Main(string[] args)
    {
        PrintResult(CalculateAverage(ReadMarks()));
    }
}
