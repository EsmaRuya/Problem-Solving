#include <iostream>
#include <cstdlib>
using namespace std;
/*
Write a program to print 3 random numbers from 1 to 10.
*/

int randomNumber(int From, int To)
{
    return rand() % (To - From + 1) + From;
}

int main()
{
   srand(time(NULL));
   
    cout << randomNumber(1,10) << endl;
    cout << randomNumber(1,10) << endl;
    cout << randomNumber(1,10) << endl;
    
    return 0;
}