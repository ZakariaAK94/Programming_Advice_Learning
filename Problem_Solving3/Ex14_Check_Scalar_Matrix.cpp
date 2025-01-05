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
            printf("%0*d     ", 1, Matrix[i][j]);
        }
        printf("\n");
    }

}

bool CheckDiagonalMatrix(int Matrix1[3][3], int Rows, int Cols)
{

    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Cols; j++)
        {
            if (i != j && Matrix1[i][j] != 0)
                return false;
        }
    }
    return true;

}

bool CheckScalarMatrix(int Matrix1[3][3], int Rows, int Cols)
{
    if (CheckDiagonalMatrix(Matrix1, Rows, Cols))
    {
        for (int i = 0; i < Rows - 1; i++)
        {
            for (int j = 0; j < Cols - 1; j++)
            {
                if (i == j && Matrix1[i][j] != Matrix1[i + 1][j + 1])
                {
                    return false;
                }
            }
        }
        return true;
    }
    else
        return false;
}

// Prof Solution

bool IsScalarMatrix(int Matrix1[3][3], int Rows, int Cols)
{
    int FirstDiagElements = Matrix1[0][0];

    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Cols; j++)
        {
            if (i == j && Matrix1[i][j] != FirstDiagElements)
            {
                return false;
            }
            else if (i != j && Matrix1[i][j] != 0)
                return false;
        }
    }
    return true;
}


int main()
{
    srand((unsigned)time(NULL));
    /*int Matrix1[3][3];
    FullMatrix(Matrix1, 3, 3);*/

    int Matrix1[3][3] = { {3,0,0},{0,3,0},{0,0,3} };

    PrintMatrixValues(Matrix1, 3, 3, "Matrix1:");

    /*if (CheckScalarMatrix(Matrix1, 3, 3))
        cout << "\nYES: Matrix is scalar.";
    else
        cout << "\nNo: Matrix is not scalar.";*/

    // Prof Solution
    if (IsScalarMatrix(Matrix1, 3, 3))
        cout << "\nYES: Matrix is scalar.";
    else
        cout << "\nNo: Matrix is not scalar.";

    system("pause>0");
}
