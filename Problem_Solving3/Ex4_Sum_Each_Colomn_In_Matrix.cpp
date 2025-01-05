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

int ColsSumInMatrix(int Matrix[3][3], short Rows, int ColsNumber)
{
	int Sum = 0;
	for (short i = 0; i <= Rows - 1; i++)
	{
		Sum += Matrix[i][ColsNumber];
	}
	return Sum;
}

void PrintEachColsSum(int Matrix[3][3],short Rows, short Cols)
{

	cout << "The following are the sum of each colomn in the matrix :" << endl;
	for (int j = 0; j < Cols; j++)
	{
		int Sum = ColsSumInMatrix(Matrix,3, j);
		cout << "Colomc " << j + 1 << " sum = " << Sum << endl;
	}

}

int main()
{
	srand((unsigned)time(NULL));
	int Matrix[3][3];
	
	FillMatrixWithRandomNumbers(Matrix, 3, 3);

	PrintMatrix(Matrix, 3, 3);

	PrintEachColsSum(Matrix, 3, 3);

	system("pause>0");

}
