using System;

public class Array
{
    static int GetSizeOfArray() {
        int arrSize = 0;
        Console.Write("Enter the number of the array's item : ");
        arrSize = int.Parse(Console.ReadLine());
        return arrSize;
    }
    
    static void ReadItemsOfArray(int[] arr) {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Enter the item N[{i+1}]: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
    }
    
    static int FindSmalestNumberInArray(int[] arr) {
        int smallNumber = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (smallNumber > arr[i]) 
                    smallNumber = arr[i];
        }
        return smallNumber;
    }
    
    static int FindGreatestNumberInArray(int[] arr) {
        int G_Number = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (G_Number < arr[i]) 
                    G_Number = arr[i];
        }
        return G_Number;
    }
    
    static int CalculateSumOfArray(int[] arr){
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
            sum += arr[i];
        return sum;
    }
    
    static float CalculateAverageOfArray(int[] arr){
        
        return CalculateSumOfArray(arr) / arr.Length;
    }
    
    public static void Main(string[] args)
    {
        // Ask the user to enter the number of items in an integer array.
        int arrSize = GetSizeOfArray();
        
        // Ask the user to enter the items of the array.
        int[] arr = new int[arrSize];
        ReadItemsOfArray(arr);
        
        // Find the smallest number in the array
        int smallNumber = FindSmalestNumberInArray(arr);
        Console.WriteLine($"The smallest number in the array is {smallNumber}.");
        
        // Find the greatest number in the array
        int G_Number = FindGreatestNumberInArray(arr);
        Console.WriteLine($"The greatest number in the array is {G_Number}.");
        
        // Calculate the average of the array.
        float AvrgArr = CalculateAverageOfArray(arr);
        Console.WriteLine($"The average of the array is {AvrgArr}.");
    }
}