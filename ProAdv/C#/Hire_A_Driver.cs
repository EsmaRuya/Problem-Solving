/*
Write a program to ask the user to enter their: Age, Driver's license, And if they have a recommendation.
Then, print "Hired" if their age is greater than 21 and they have a driver's license, otherwise print "Rejected".

Note: If they have a recommendation, hire them without conditions!
*/
using System;
public class ProAdv
{
    struct stInfo 
    {
      public int age;
      public bool isHasDrivedLicense;
      public bool isHasRecommendation;
    };
    
    static stInfo ReadInfo()
    {
        stInfo info;
        Console.Write("Enter your age: ");
        while (!int.TryParse(Console.ReadLine(), out info.age) || info.age < 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
            Console.Write("Enter your age: ");
        }
 
        Console.Write("Do you have a drived license? [True/False]: ");
        while (!bool.TryParse(Console.ReadLine(), out info.isHasDrivedLicense))
        {
            Console.WriteLine("Invalid input. Please enter True or False.");
            Console.Write("Do you have a driving license? [True/False]: ");
        }
        
        Console.Write("Do you have a recommendation? [True/False]: ");
        while (!bool.TryParse(Console.ReadLine(), out info.isHasRecommendation))
        {
            Console.WriteLine("Invalid input. Please enter True or False.");
            Console.Write("Do you have a recommendation? [True/False]: ");
        }
        
        return info;
    }
    
   static bool isAccepted(stInfo info)
    {
        if (info.isHasRecommendation)
            return true;
        else
        return (info.age > 21 && info.isHasDrivedLicense);
    }
    
   static void PrintResult(stInfo info)
    {
        if(isAccepted(info))
            Console.WriteLine("Hired!");
        else
            Console.WriteLine("Rejected!");
    }
    
    
    public static void Main(string[] args)
    {
        PrintResult(ReadInfo());
    }
}