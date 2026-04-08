#include <iostream>
using namespace std;
/*
Write a program to fill a 3x3 matrix with random numbers.
*/

int RandomNumber(int From, int To)
{
    return rand() % (To - From + 1) + From;
}

void FillMatrixWithRandomNumber(int arr[3][3], short rows, short cols)
{
    for(short i = 0; i < rows; i++)
    {
        for(short j = 0; j < cols; j++)
        {
            arr[i][j] = RandomNumber(1,100);
        }
    }
}

void PrintMatrix(int arr[3][3], short rows, short cols)
{
    for(short i = 0; i < rows; i++)
    {
        for(short j = 0; j < cols; j++)
        {
            cout << arr[i][j] << " ";
        }
        cout << "\n";
    }
}

int main()
{
    srand(time(NULL));
    
    int arr[3][3];
    FillMatrixWithRandomNumber(arr,3,3);
    PrintMatrix(arr,3,3);
    
    return 0;
}