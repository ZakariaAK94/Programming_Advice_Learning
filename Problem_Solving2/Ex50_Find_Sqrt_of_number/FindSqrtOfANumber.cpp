#include <iostream>
#include<math.h>

#include "MyInputData.h";

using namespace std;

int main()
{
	float Number = MyInputData::ReadPositiveNumber("Please enter a positive number :");
	int result = MyInputData::MySqrt(Number);
	if(result != 0)
		cout << "Mysqrt result : " << result << endl;
	else
		cout << "The square root of 24 is not a natural number because it is not an integer, below the resut" << endl;
	cout << "C++ sqrt result : " << sqrt(Number) << endl;
	return 0;

}