
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

int GetMin(int Matrix1[3][3], int Rows, int Cols)
{
    int min = Matrix1[0][0];

    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Cols; j++)
        {
            if (Matrix1[i][j] < min)
                min = Matrix1[i][j];

        }
    }
    return min;
}

int GetMax(int Matrix1[3][3], int Rows, int Cols)
{
    int max = Matrix1[0][0];

    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Cols; j++)
        {
            if (Matrix1[i][j] > max)
                max = Matrix1[i][j];

        }
    }
    return max;
}



int main()
{
    srand((unsigned)time(NULL));
    int Matrix1[3][3];
    
    FullMatrix(Matrix1, 3, 3);

    PrintMatrixValues(Matrix1, 3, 3, "Matrix1:");

    cout << "Minimum Number is :" << GetMin(Matrix1,3,3) << endl;
    cout << "Max Number is :" << GetMax(Matrix1, 3, 3) << endl;

    system("pause>0");
}
