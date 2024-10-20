/*
Write a program to ask the user to enter a mark, 
then print "Pass" if the mark >= 50, otherwise print "Fail"
*/
using System;
public class ProAdv
{
  
    
    static double ReadMark()
    {
        double m = 0;
        Console.Write("Enter your mark: ");
        while (!double.TryParse(Console.ReadLine(), out m) || m < 0 || m > 100)
        {
         Console.Write("Please enter a valid mark (0-100): ");
        }
        return m;
    }
    
    static bool isPass(double mark)
    {
        return (mark >= 50);
    }
    
   static void PrintResult(double number)
    {
        if (isPass(number))
            Console.WriteLine("Pass");
        else
            Console.WriteLine("Fail");
    }
    
    
    public static void Main(string[] args)
    {
        PrintResult(ReadMark());
    }
}