/*
Write a function that takes an array of numbers and returns the sum of the numbers. The numbers can be negative or non-integer. If the array does not contain any numbers then you should return 0.

Examples
Input: [1, 5.2, 4, 0, -1]
Output: 9.2

Input: []
Output: 0

Input: [-2.398]
Output: -2.398
*/

using System.Linq; // if you use Sum() method

public class Kata
{
  public static double SumArray(double[] array)
        {
        // return (array.Length == 0) ? 0 : array.Sum();

            if (array.Length == 0)
                return 0;
    
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
              sum += array[i];
            }
            return sum;
    
          

        }
}