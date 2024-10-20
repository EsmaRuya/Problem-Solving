// Write a program to ask the user to enter a number,
// then print the "Half of the <number> is <???>".
using System;
public class ProAdv
{
  
    
    static double ReadNumber()
    {
        double number = 0;
        Console.Write("Enter a number: ");
        number = Convert.ToDouble(Console.ReadLine());
        return number;
    }
    
    static double halfNumber(double number)
    {
        return number / 2;
    }
    
   static void PrintResult(double number)
    {
            Console.WriteLine($"Half of the <{number}> is <{halfNumber(number)}>" );
    }
    
    
    public static void Main(string[] args)
    {
        PrintResult(ReadNumber());
    }
}