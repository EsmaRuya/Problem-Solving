#include <iostream>
#include <string>
using namespace std;
/*
Write a program to read a number and print inverted pattern as following:
input : 3
333
22
1
*/

int readPositiveNumber(string message)
{
    int number = 0;

    do
    {
        cout << message;
        cin >> number;
    } while (number < 0);

    return number;
}

void printInvertedNumberPattern(int n)
{
    for (int i = n; i >= 1; i--)
    {
        for (int j = i; j >= 1; j--)
        {
            cout << i << " ";
        }
        cout << "\n";
    }
}

int main()
{
    printInvertedNumberPattern(readPositiveNumber("Enter a positive number: "));
    
    return 0;
}