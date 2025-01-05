#include <iostream>
#include<math.h>

using namespace std;

float ReadPositiveNumber(string Message)
{
	float Number = 0;
	cout << Message << endl;
	cin >> Number;
	return Number;
}

int MyFloor(float Number)
{
	int IntPart;
	IntPart = int(Number);
	
	if (Number >0)
		return IntPart;
	else
		return IntPart - 1;

}

int main()
{
	float Number = ReadPositiveNumber("Please enter a number");
	cout << "My Round result : " << MyFloor(Number) << endl;
	cout << "C++ Round result : " << floor(Number) << endl;
	return 0;

}

