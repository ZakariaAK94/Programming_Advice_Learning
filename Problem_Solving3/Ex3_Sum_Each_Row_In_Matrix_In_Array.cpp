#include <iostream>
#include<string>
#include<iomanip>
#include <cstdlib>

using namespace std;

int RandomNumber(int from, int to)
{
	return (rand() % (to - from + 1) + from);
}

void FillMatrixWithRandomNumbers(int Matrix[3][3], short Rows, short Cols)
{
	for (short i = 0; i < Rows; i++)
	{
		for (short j = 0; j < Cols; j++)
		{
			Matrix[i][j] = RandomNumber(1, 100);
		}
	}
}

void PrintMatrix(int Matrix[3][3], short Rows, short Cols)
{
	cout << "The following is 3x3 random matrix :" << endl;
	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Cols; j++)
		{
			cout << setw(3) << Matrix[i][j] << "    ";
		}
		cout << endl;
	}
}

void RowSumInArray(int Matrix[3][3], int T[3] ,short RowNumber, int Cols)
{
	T[RowNumber] = 0;
	for (short j = 0; j <= Cols - 1; j++)
	{
		T[RowNumber] = T[RowNumber] + Matrix[RowNumber][j];
	}

}

void PrintEachRowSum(int Matrix[3][3], int T[3], short Rows, short Cols)
{
	
	cout << "The following are the sum of each row in the matrix :" << endl;
	for (int i = 0; i < Rows; i++)
	{
		RowSumInArray(Matrix, T,i, 3);
		cout << "Row " << i + 1 << " sum = " << T[i] << endl;
	}

}

int main()
{
	srand((unsigned)time(NULL));
	int Matrix[3][3];
	int T[3];

	FillMatrixWithRandomNumbers(Matrix, 3, 3);

    PrintMatrix(Matrix, 3, 3);

	PrintEachRowSum(Matrix,T, 3, 3);

	system("pause>0");

}
