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

bool IsPalindromeMatrix(int Matrix1[3][3], int Rows, int Cols)
{
     for (int i = 0; i < Rows; i++)
    {
         for (int j = 0; j < Cols / 2; j++)
         {
             if (Matrix1[i][j] != Matrix1[i][Cols-j-1])
             {
                 return false;
             }
         }
        
    }
     return true;
    
}

int main()
{
    srand((unsigned)time(NULL));
    int Matrix1[3][3] = {{1,7,1},{2,5,2},{9,2,9}};

    /*FullMatrix(Matrix1, 3, 3);*/

    PrintMatrixValues(Matrix1, 3, 3, "Matrix1:");

    if(IsPalindromeMatrix(Matrix1,3,3))
        cout << "Yes: it is Palindrome!! " << endl;
    else
        cout << "No: it is not Palindrome!! " << endl;
    

    system("pause>0");
}

