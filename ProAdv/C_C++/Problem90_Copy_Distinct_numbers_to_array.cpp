#include <iostream>
#include <cmath>
using namespace std;
/*
Write a program to fill an array with numbers (hardcoded), then print distinct numbers to another array.
*/

void printArray(int arr[], int length)
{
    for (int i = 0; i < length; i++)
    {
        cout << arr[i] << " ";
    }
    cout << endl;
}

void addNumberToArray(int arr[], int &length, int number)
{
    length++;
    arr[length - 1] = number;
}

short findNumberPositionInArray(int arr[], int length, int number)
{
    for (int i = 0; i < length; i++)
    {
        if (arr[i] == number)
            return i; 
    }
    return -1;
}

bool isNumberInArray(int arr[], int length, int number)
{
    return (findNumberPositionInArray(arr, length, number) != -1);
}

void copyDistinctNumbersToArray(int arr[], int length, int arr2[], int &length2)
{
    for (int i = 1; i < length; i++)
     {
	    if (!isNumberInArray(arr2, length, arr[i]))
		    addNumberToArray(arr2, length2, arr[i]);
     }
}

int main()
{
    int arr[] = {10, 10, 10, 50, 50, 70, 70, 70, 70, 90};
    int arr2[10], length2 = 0;

    copyDistinctNumbersToArray(arr, 10, arr2, length2);

    cout << "Array 1: ";
    printArray(arr, 10);
    cout << "Array 2: ";
    printArray(arr2, length2);
    
    
    return 0;
}