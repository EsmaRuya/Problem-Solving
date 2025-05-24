#include <iostream>
#include <string>
using namespace std;
/*
Write a program to read a number and print a pattern as following:
input : 3
1
22
333
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

void printNumberPattern(int n)
{
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            cout << i ;
        }
        cout << endl ;
    }
}

int main()
{
    printNumberPattern(readPositiveNumber("Enter a positive number: "));
    
    return 0;
}