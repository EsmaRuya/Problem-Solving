// Write a program to read name and print your name on the screen.
using System;

public class ProAdv
{
    static void PrintName(string name)
    {
        Console.WriteLine($"Your name is : {name}");
    }
    
    static string ReadName()
    {
        string name = "";
        Console.Write("Enter your name : ");
        name = Console.ReadLine();
        return name;
    }
    
    public static void Main(string[] args)
    {
        PrintName(ReadName());
    }
}