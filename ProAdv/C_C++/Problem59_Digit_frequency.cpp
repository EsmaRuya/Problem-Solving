#include <iostream>
#include <string>
using namespace std;
/*
Write a program to read a number, then print all digit frequency in that number
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

int DigitFrequency(int number, short digit)
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

void printAllFreqeuncy(int number)
{
    
    for (int i = 0; i <= 9; i++)
    {
        short digitFrequency = DigitFrequency(number,i);
        
        if (digitFrequency > 0)
        cout << "Digit " << i << " frequency is "
             << digitFrequency << " time(s)." << endl;
    }
}


int main()
{
    printAllFreqeuncy(readPositiveNumber("Enter a positive number: "));
    
    
    
    return 0;
}