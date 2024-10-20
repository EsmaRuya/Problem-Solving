/*
Write a program to ask the user to enter three numbers,
Then print the sum of the entered numbers.
*/
using System;
public class ProAdv
{
  
    
    static int[] ReadNumber()
    {
        int[] n = new int[3];
        for (int i = 0; i < n.Length; i++)
         {
            Console.Write($"Enter number {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out n[i]))
            {
                Console.Write("Please enter a valid number: ");
            }
          }
        return n;
    }
    
    static int SumOfThreeNumbers(int[] numbers)
    {
        return (numbers[0] + numbers[1] + numbers[2]);
    }
    
   static void PrintResult(int[] n)
    {
     
            Console.WriteLine("Sum = " + SumOfThreeNumbers(n));
    }
    
    
    public static void Main(string[] args)
    {
       PrintResult(ReadNumber());
    }
}