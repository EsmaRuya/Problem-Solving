#include <iostream>
using namespace std;
/*
Write a program to fill an array with numbers (hardcoded), then check if it is palindrome array or not.
*/

void printArray(int arr[], int length)
{
    for (int i = 0; i < length; i++)
    {
        cout << arr[i] << " ";
    }
    cout << endl;
}

bool isPalindromeArray(int arr[], int length)
{
    for (int i = 0; i < length; i++)
    {
        if (arr[i] != arr[length - i - 1])
            return false;
    }
    return true;
}

int main()
{
    int arr[] = {10, 20, 30, 30, 20, 10};
    int length = sizeof(arr) / sizeof(arr[0]);

    cout << "Array elements:\n";
    printArray(arr, size(arr));

    if (isPalindromeArray(arr, length))
        cout << "\nYes, it is a palindrome array!\n";
    else
        cout << "\nNo, it is not a palindrome array!\n";

    return 0;
}