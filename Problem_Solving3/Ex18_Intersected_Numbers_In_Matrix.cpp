
#include <iostream>
#include<iomanip>
#include<string>
#include<cstdlib>
#include<cstdio>


using namespace std;

void PrintMatrixValues(int Matrix[3][3], int Rows, int Cols, string Message)
{

    cout << Message << endl;
    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Cols; j++)
        {
           // printf("%0*d     ", 1, Matrix[i][j]);
            cout << setw(3) << Matrix[i][j] << "      ";
        }
        printf("\n");
    }

}

bool IsNumberInMtrix(int Matrix1[3][3], int Rows, int Cols, int NumberToCheck)
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

void PrintIntersectedNumbers(int Matrix1[3][3], int Matrix2[3][3], int Rows, int Cols)
{
    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Cols; j++)
        {
            if(IsNumberInMtrix(Matrix2, 3, 3, Matrix1[i][j]))
                cout << setw(3) << Matrix1[i][j] << "      ";

        }
    }
}


int main()
{
    srand((unsigned)time(NULL));
    int Matrix1[3][3] = { {77,5,12},{22,20,1},{1,0,9} };
    int Matrix2[3][3] = { {5,80,90},{22,77,1},{10,8,33} };
    
    PrintMatrixValues(Matrix1, 3, 3, "Matrix1:");
    PrintMatrixValues(Matrix2, 3, 3, "Matrix2:");

    cout << "Intersected numbers are :" << endl;
    PrintIntersectedNumbers(Matrix1, Matrix2, 3, 3);
    
    system("pause>0");
}
