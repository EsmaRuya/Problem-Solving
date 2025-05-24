#include <iostream>
#include <string>
using namespace std;
/*
Write a program to read a number, then check if it's Palindrome.
Palindrome is a number that reads the same backwards as forwards.
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

int ReverseNumber(int number)
{
    int remainder = 0, result = 0;

    while (number > 0)
    {
        remainder = number % 10;
        number = number / 10;
        result = result * 10 + remainder;
    }
    return result;
}

bool isPalindrome(int number)
{
    return (number == ReverseNumber(number));
}

int main()
{
    if (isPalindrome(readPositiveNumber("Enter a positive number: ")))
        cout << "Yes, it is a Palindrome number" << endl;
    else
        cout << "No, it is Not a Palindrome number" << endl;
    
    return 0;
}