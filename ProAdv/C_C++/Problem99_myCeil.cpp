#include <iostream>
#include <cmath>
using namespace std;
/*
Write a program to print ceil of numbers, don't use built-in abs function.
*/

float readNumber()
{
    float number;
    cout << "Enter a number: ";
    cin >> number;
    return number;
}

int myCeilfunction(float number)
{
    return (number > 0) ? (int)++number : (int)number;
}

int main()
{
    float number = readNumber();
    cout << "My ceil function : " << myCeilfunction(number) << endl;
    cout << "C++ ceil : " << ceil(number) << endl;

    return 0;
}