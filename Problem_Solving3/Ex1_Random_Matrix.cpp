#include <iostream>
#include<iomanip>
#include <cstdlib>
#include"MyRandomFunction.h";
using namespace std;



int main()
{
	srand((unsigned)time(NULL));
	int Matrix[3][3];
	int T[3];
	vector <int> Tv;
	MyRandomFunction::FillMatrixWithRandomNumbers(Matrix,3,3);

	cout << "The following is a 3x3 matrix with random numbers :" << endl;
	
	MyRandomFunction::PrintMatrix(Matrix,3,3);
	
	return 0;

}
