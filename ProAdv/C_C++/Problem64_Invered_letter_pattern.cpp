#include <iostream>
#include <string>
using namespace std;
/*
Write a program to read a number and print inverted letter pattern as following:
input : 3
CCC
BB
A
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

void printInvertedLetterPattern(int n)
{
    for (int i = n; i >= 1; i--)
    {
        for (int j = i; j >= 1; j--)
        {
            cout << char(65 + i - 1);
        }
        cout << "\n";
    }
}

int main()
{
    printInvertedLetterPattern(readPositiveNumber("Enter a positive number: "));
    
    return 0;
}