/*
Write a program to ask the user to enter two numbers,
then print the two numbers. Then swap them and print them again (after swapping).
*/
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

    static void swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public static void Main(string[] args)
    {
        int a = ReadNumber();
        int b = ReadNumber();

        Console.WriteLine("Before swap:");
        Console.WriteLine($"A = {a} \nB = {b}");

        swap(ref a, ref b);

        Console.WriteLine("After swap:");
        Console.WriteLine($"A = {a} \nB = {b}");
    }
}
