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

float GetFractionPart(float Number)
{ 
	return Number - int(Number);
}

float MyABS(float Number)
{
	if (Number >= 0)
		return Number;
	else
		return (-1) * Number;
}

int MyRound(float Number)
{
	int IntPart; 
	IntPart = int(Number);
	float FractionsPart = GetFractionPart(Number);
	if (abs(FractionsPart) < 0.5)
		return IntPart;
	else if (FractionsPart >= 0.5)
		return  IntPart +1;
	else
		return IntPart - 1;
	
}

int main()
{
	float Number = ReadPositiveNumber("Please enter a number");
	cout << "My Round result : " << MyRound(Number) << endl;
	cout << "C++ Round result : " << round(Number) << endl;
	return 0;

}

