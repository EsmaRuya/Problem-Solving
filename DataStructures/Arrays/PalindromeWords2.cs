using System;

// Palindrome words
public class Array
{
    public static void Main(string[] args)
    {
       Console.Write("Enter a word to check: ");
       string word = Console.ReadLine().ToUpper();
       
       bool isPalindrome = true;
       for (int i = 0; i < word.Length / 2; i++)
       {
           if (word[i] != word[word.Length - i - 1])
               {
                    isPalindrome = false;
                    break;
               }
       }
        
        if (isPalindrome)
            Console.Write($"Palindrome");
        else
             Console.Write($"Not Palindrome");
       
    }
}