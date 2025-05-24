#include <iostream>
#include <string>
using namespace std;
/*
Write a program to read a number, then print the sum of its digits
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

int sumOfDigits(int number)
{
    int remainder = 0, sum = 0;

    while (number > 0)
    {
        remainder = number % 10;
        number = number / 10;
        sum += remainder;
    }
    return sum;
}

int main()
{
    int n = readPositiveNumber("Enter a positive number: ");
    cout << "Sum of digits = "
         << sumOfDigits(n)
         << endl;
    
    return 0;
}