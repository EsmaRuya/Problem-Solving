#include <iostream>
#include <string>
using namespace std;
/*
Write a program to read a number and print letter pattern as following:
input : 3
A
BB
CCC
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

void printLetterPattern(int n)
{
    for (int i = 65; i <= 65 + n - 1; i++)
    {
        for (int j = 1; j <= i - 65 + 1; j++)
        {
            cout << char(i);
        }
        cout << "\n";
    }
}

int main()
{
    printLetterPattern(readPositiveNumber("Enter a positive number: "));
    
    return 0;
}