#include <iostream>
using namespace std;
/*
Write a program to print abs of numbers, don't use built-in abs function.
*/

float readNumber()
{
    int number;
    cout << "Enter a number: ";
    cin >> number;
    return number;
}

float myABSfunction(float number)
{
    return (number < 0) ? number * -1 : number;
}

int main()
{
    // ABS function: converts negative numbers to positive numbers while positive numbers remain unaffected.
    float number = readNumber();
    cout << "My abs function : " << myABSfunction(number) << "\n";
    cout << "C++ abs : " << abs(number) << "\n";

    return 0;
}