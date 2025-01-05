
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

bool IsNumberInMatrix(int Matrix1[3][3], int Rows, int Cols, int NumberToCheck)
{
    

    return(CountNumberInMatrix(Matrix1, 3, 3, NumberToCheck ) >0 );

}

bool CheckNumberInMtrix(int Matrix1[3][3], int Rows, int Cols, int NumberToCheck)
{
    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Cols; j++)
        {
            if (Matrix1[i][j] == NumberToCheck)
                return true;

        }
    }
    return false;
}


int main()
{
    srand((unsigned)time(NULL));
    int Matrix1[3][3] = { {0,0,5},{0,0,12},{5,5,5} };
    int NumberToCheck = 0;
    /*FullMatrix(Matrix1, 3, 3);*/

    PrintMatrixValues(Matrix1, 3, 3, "Matrix1:");

    cout << "Please enter a number to look for in the matrix ?" << endl;
    cin >> NumberToCheck;

    if (IsNumberInMatrix(Matrix1, 3, 3, NumberToCheck))
        cout << "Yes : it's there";
    else
        cout << "No : it's not there";
    // second method to solve this problem

    if (CheckNumberInMtrix(Matrix1, 3, 3, NumberToCheck))
        cout << "\nYes : it's there";
    else
        cout << "\nNo : it's not there";

    system("pause>0");
}