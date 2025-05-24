#include <iostream>
#include <string>
using namespace std;
/*
Write a program to read a digit and a number, then print digit frequency in that number
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

int DigitFrequency(int number, int digit)
{
    int remainder = 0, ferquency = 0;

    while (number > 0)
    {
        remainder = number % 10;
        number = number / 10;
        
        if (remainder == digit)
            ferquency++;
        
    }
    return ferquency;
}

int main()
{
    int n = readPositiveNumber("Enter a positive number: ");
    short d = readPositiveNumber("Enter a digit to check: ");
    
    cout << "Digit" << d << "frequency is "
         << DigitFrequency(n, d) << " time(s)."
         << endl;
    
    return 0;
}