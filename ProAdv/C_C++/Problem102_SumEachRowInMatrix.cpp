#include <iostream>
#include <iomanip>
using namespace std;
/*
Write a program to fill a 3x3 matrix with random numbers,
then print each row.
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
            cout << setw(3) << arr[i][j] << " ";
        }
        cout << "\n";
    }
}

int RowSum(int arr[3][3],short rowNumber, short cols)
{
    int sum = 0;
        for(short j = 0; j < cols; j++)
        {
            sum += arr[rowNumber][j];
        }
    return sum;
}

void PrintEachRowSum(int arr[3][3], short rows, short cols)
{
    for(short i = 0; i < rows; i++)
    {
        cout << "Row " << i + 1 << " Sum = "  << RowSum(arr, i, cols) << endl;
    }
}

int main()
{
    srand(time(NULL));
    
    int arr[3][3];
    FillMatrixWithRandomNumber(arr,3,3);
    
    cout << "The following is a 3x3 random matrix:\n";
    PrintMatrix(arr,3,3);
    
    cout << "\nThe following are the sum of each row in the matrix:\n";
    PrintEachRowSum(arr,3,3);
    
    return 0;
}