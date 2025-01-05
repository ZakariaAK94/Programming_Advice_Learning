#include <iostream>
#include <cstdlib>
#include"MyFunction1.h";
using namespace std;



int main()
{
	srand((unsigned)time(NULL));
	int Matrix[3][3];
	
	MyRandomFunction::FillMatrixWithRandomNumbers(Matrix, 3, 3);

	cout << "The following is a 3x3 matrix with random numbers :" << endl;

	MyRandomFunction::PrintMatrix(Matrix, 3, 3);

	MyRandomFunction::PrintEachRowSum(Matrix, 3, 3);
	
	return 0;

}