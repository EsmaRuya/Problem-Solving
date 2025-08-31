using System;

public class Array
{
    public static void Main(string[] args)
    {
        // Ask the user to enter the number of items in an integer array.
        Console.Write("Enter the number of the array's item : ");
        int arrSize = int.Parse(Console.ReadLine());
        
        // Ask the user to enter the items of the array.
        int[] arr = new int[arrSize];
        for (int i = 0; i < arrSize; i++)
        {
            Console.Write($"Enter the item N[{i+1}]: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        
        // Find the smallest number in the array
        // Find the greatest number in the array
        // Calculate the average of the array
        int smallNumber = int.MaxValue, G_Number = int.MinValue, sum = 0;
        foreach(int n in arr)
        {
            sum += n; // sum
            
            if (n < smallNumber) // smallest
                smallNumber = n;
                
            if (n > G_Number) // greatest
                G_Number = n;
        }
        float AvrgArr = sum / arr.Length; // average
        
        // Print result
        Console.WriteLine($"The smallest number in the array is {smallNumber}.");
        Console.WriteLine($"The greatest number in the array is {G_Number}.");
        Console.WriteLine($"The average of the array is {AvrgArr}.");
    }
}