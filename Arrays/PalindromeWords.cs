using System;
using System.Linq;

// Palindrome words
public class Array
{
    public static void Main(string[] args)
    {
       Console.Write("Enter a word to check: ");
       string word = Console.ReadLine();
       
        word = word.ToLower();
        
        string reversed = new string(word.Reverse().ToArray());
        
        if (word == reversed)
            Console.Write($"Palindrome");
        else
             Console.Write($"Not Palindrome");
       
    }
}