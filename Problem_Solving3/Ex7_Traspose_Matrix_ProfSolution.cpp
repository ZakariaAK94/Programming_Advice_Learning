#include <iostream>
#include<iomanip>
#include<string>

using namespace std;

void TrasposeMatrix(int Matrix[3][3],int MatrixTransposed[3][3], int Rows, int Cols)
{
    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Cols; j++)
        {
           MatrixTransposed[i][j] = Matrix[j][i];
        }
    }
}

void FullMatrix(int Matrix[3][3], int Rows, int Cols)
{
    Matrix[0][0] = 1;
    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Cols; j++)
        {
            Matrix[i][j + 1] = Matrix[i][j] + 1;
        }
    }
}

void PrintMatrixValues(int Matrix[3][3], int MatrixTransposed[3][3], int Rows, int Cols)
{
    FullMatrix(Matrix, 3, 3);
    cout << "The following is a 3x3 ordered matrix :" << endl;
    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Cols; j++)
        {
            cout << setw(3) << Matrix[i][j] << "     ";
        }
        cout << endl;
    }
    TrasposeMatrix(Matrix, MatrixTransposed,3, 3);
    cout << "The following is a 3x3 traspose matrix :" << endl;
    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Cols; j++)
        {
            cout << setw(3) << MatrixTransposed[i][j] << "     ";
        }
        cout << endl;
    }
}



int main()
{
    int Matrix[3][3], MatrixTransposed[3][3];
    PrintMatrixValues(Matrix, MatrixTransposed,3, 3);
    system("pause>0");
}