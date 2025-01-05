#include <iostream>
#include<iomanip>
#include<string>
#include<cstdlib>
#include<cstdio>

using namespace std;

int RandomNumber(int from, int to)
{
    return (rand() % (to - from + 1) + from);
}

void FullMatrix(int Matrix[3][3], int Rows, int Cols)
{

    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Cols; j++)
        {
            Matrix[i][j] = RandomNumber(1, 10);
        }
    }
}

void PrintMatrixValues(int Matrix[3][3], int Rows, int Cols, string Message)
{

    cout << Message << endl;
    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Cols; j++)
        {
            printf("%0*d     ", 2, Matrix[i][j]);
        }
        printf("\n");
    }

}

bool CheckMatrix(int Matrix1[3][3], int Matrix2[3][3], int Rows, int Cols)
{

    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Cols; j++)
        {
            if (Matrix1[i][j] != Matrix2[i][j])
                return false;
        }
    }
    return true;

}

int main()
{
    srand((unsigned)time(NULL));
   int Matrix1[3][3], Matrix2[3][3];
    FullMatrix(Matrix1, 3, 3);
    FullMatrix(Matrix2, 3, 3);
    /*int Matrix1[3][3] = { {1,2,3},{4,5,6},{8,9,10} };
    int Matrix2[3][3] = { {1,2,3},{4,5,6},{8,9,10} };*/
    PrintMatrixValues(Matrix1, 3, 3, "Matrix1:");
    PrintMatrixValues(Matrix2, 3, 3, "Matrix2:");
    
    if (CheckMatrix(Matrix1, Matrix2, 3, 3))
        cout << "\nYES: both martices are equal.";
    else
        cout << "\nNo: martices are NOT equal.";

    system("pause>0");
}