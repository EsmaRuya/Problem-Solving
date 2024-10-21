/*
Given an array of integers.

Return an array, where the first element is the count of positives numbers and the second element is sum of negative numbers. 0 is neither positive nor negative.

If the input is an empty array or is null, return an empty array.
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        if (input == null || input.Length == 0) // null first
           return new int[0];

        int[] arr = new int[2];
        int pos_counter = 0, negNum = 0;
        for (int i = 0; i < input.Length; i++)
          {
              if(input[i] > 0)
                  pos_counter++;
              if(input[i] < 0)
                  negNum += input[i];
          }
        arr[0] = pos_counter;
        arr[1] = negNum;
      
        return arr;
    }
}