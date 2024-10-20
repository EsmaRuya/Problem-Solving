/*
Write a program to ask the user to enter three marks,
then print the average of the entered marks.
*/
using System;
public class ProAdv
{
  
    
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
    
    static double AverageNumbers(int[] numbers)
    {
        return (SumOfThreeNumbers(numbers) / 3);
    }
    
   static void PrintResult(int[] n)
    {
     
            Console.WriteLine("Average = " + AverageNumbers(n));
    }
    
    
    public static void Main(string[] args)
    {
       PrintResult(ReadMarks());
    }
}