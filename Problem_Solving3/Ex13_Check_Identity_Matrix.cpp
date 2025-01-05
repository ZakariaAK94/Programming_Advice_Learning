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

bool CheckIdentityMatrix(int Matrix1[3][3],int Rows, int Cols)
{

    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Cols; j++)
        {
            if (i == j && Matrix1[i][j] != 1)
                return false;
            else if (i!=j && Matrix1[i][j] !=0)
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
    
    int Matrix1[3][3] = { {1,0,0},{0,1,0},{0,0,1} };
    
    PrintMatrixValues(Matrix1, 3, 3, "Matrix1:");

    if (CheckIdentityMatrix(Matrix1, 3, 3))
        cout << "\nYES: Matrix is identity.";
    else
        cout << "\nNo: Matrix is not identity.";

    system("pause>0");
}
