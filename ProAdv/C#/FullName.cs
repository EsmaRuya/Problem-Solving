// Write a program to ask the user to enter his first name and last name.
// Then print the full name on the screen.
using System;
public class ProAdv
{
    struct stInfo 
    {
      public string firstName;
      public string lastName;
    };
    
    static stInfo ReadInfo()
    {
        stInfo info;
        Console.Write("Enter your first name: ");
        info.firstName = Console.ReadLine();
       
        Console.Write("Enter your last name: ");
        info.lastName = Console.ReadLine();
        
        return info;
    }
    
    static string fullName(stInfo info, bool reversed)
    {
        if (reversed)
            return (info.lastName + " " + info.firstName);
        else
            return (info.firstName + " " + info.lastName);
    }
    
   static void PrintFullName(string fullName)
    {
            Console.WriteLine(fullName);
    }
    
    
    public static void Main(string[] args)
    {
        PrintFullName(fullName(ReadInfo(), true));
    }
}