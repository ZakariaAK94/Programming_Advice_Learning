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

void PrintMiddleRowValues(int Matrix[3][3], int RowMiddle, int Cols, string Message)
{

    cout << Message << endl;
    for (int j = 0; j < Cols; j++)
    {
            printf("%0*d     ", 2, Matrix[RowMiddle][j]);
    }
    printf("\n");
    
}

void PrintMiddleColosValues(int Matrix[3][3], int Rows, int ColsMiddle, string Message)
{

    cout << Message << endl;
    for (int i = 0; i < Rows; i++)
    {
        printf("%0*d     ", 2, Matrix[i][ColsMiddle]);
    }
    printf("\n");

}



int main()
{
    srand((unsigned)time(NULL));
    int Matrix1[3][3], Matrix2[3][3], MatrixResults[3][3];
    FullMatrix(Matrix1, 3, 3);
    PrintMatrixValues(Matrix1, 3, 3, "Matrix1:");
    PrintMiddleRowValues(Matrix1, 1, 3, "Middle Row of Matrix is:");
    PrintMiddleColosValues(Matrix1, 3, 1, "Middle Cols of Matrix is:");
    
    system("pause>0");
}