#include <iostream>
#include <cmath>
using namespace std;
/*
Write a program to print sqrt of numbers, don't use built-in sqrt function.
*/

float readNumber()
{
    float number;
    cout << "Enter a number: ";
    cin >> number;
    return number;
}

float mySqrtunction(float number)
{
    return pow(number, 0.5);
}

int main()
{
    float number = readNumber();
    cout << "My sqrt function : " << mySqrtunction(number) << endl;
    cout << "C++ sqrt : " << sqrt(number) << endl;

    return 0;
}