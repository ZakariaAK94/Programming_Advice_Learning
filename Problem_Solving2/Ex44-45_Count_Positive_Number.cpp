#include <iostream>
#include <cstdlib>
#include "MyFuntions.h";

using namespace std;

int main()
{
	srand((unsigned)time(NULL));

	int arr[100], arrLength = 0, CountPv = 0;
	MyFunctions::FillArrayWithRandomNumber(arr, arrLength);
	cout << "\nArray 1 elements : " << endl;
	MyFunctions::PrintArray(arr, arrLength);
	CountPv = MyFunctions::CountPositiveNumber(arr, arrLength);
	cout << "\n Positive count is : " << CountPv << endl;
	cout << "\n Negative count is : " << arrLength- CountPv << endl;
	return 0;

}