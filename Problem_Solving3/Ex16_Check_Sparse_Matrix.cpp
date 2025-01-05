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

int CountNumberInMatrix(int Matrix1[3][3], int Rows, int Cols, int NumberToCount)
{
    int Count = 0;

    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Cols; j++)
        {
            if (Matrix1[i][j] == NumberToCount)
                Count++;

        }
    }
    return Count;
}

bool IsSparseMatrix(int Matrix1[3][3], int Rows, int Cols)
{
    short MatrixSize = Rows * Cols;

    return(CountNumberInMatrix(Matrix1, 3, 3, 0) > MatrixSize / 2);

}



int main()
{
    srand((unsigned)time(NULL));
    int Matrix1[3][3] = { {0,0,5},{0,0,12},{5,5,5} };
    int NumberToCount = 0;
    /*FullMatrix(Matrix1, 3, 3);*/

    PrintMatrixValues(Matrix1, 3, 3, "Matrix1:");

    if (IsSparseMatrix(Matrix1, 3, 3))
        cout << "Yes : it's a sparse matrix";
    else
        cout << "No : it's not a sparse matrix.";

    system("pause>0");
}
