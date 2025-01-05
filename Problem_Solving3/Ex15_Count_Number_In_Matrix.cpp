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



int main()
{
    srand((unsigned)time(NULL));
    int Matrix1[3][3];
    int NumberToCount = 0;
    FullMatrix(Matrix1, 3, 3);

    PrintMatrixValues(Matrix1, 3, 3, "Matrix1:");

    cout << "Enter the number to count in matrix ? " << endl;
    cin >> NumberToCount;

    cout << "Number " << NumberToCount << " count in matrix is " << CountNumberInMatrix(Matrix1, 3, 3, NumberToCount);

    system("pause>0");
}
