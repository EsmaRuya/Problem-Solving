/*
Given an array of integers, return a new array with each value doubled.

For example:

[1, 2, 3] --> [2, 4, 6]
*/
public class Kata
{
  public static int[] Maps(int[] x)
  {
    int [] arr = new int [x.Length];
    for(int i = 0; i < x.Length; i++)
      {
          arr[i] = x[i] * 2;
      }
    
    return arr;
  }

// return x.Select(n => n * 2).ToArray();
}