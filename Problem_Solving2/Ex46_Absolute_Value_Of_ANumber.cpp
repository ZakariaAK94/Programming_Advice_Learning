#include <iostream>
#include<math.h>
#include<cstdlib>
using namespace std;

float ReadPositiveNumber(string Message)
{
	float Number = 0;
	cout << Message << endl;
	cin >> Number;
	return Number;
}

float MyABS(int Number)
{
	if (Number >= 0)
		return Number;
	else
		return (-1) * Number;
}

void PrintABSNumber(int Number)
{
	cout << "My abs result : " << MyABS(Number) << endl;
}
 


int main()
{
	int Number = ReadPositiveNumber("Please enter a number");
	PrintABSNumber(Number);
	cout << "C++ abs Result : " << abs(Number) << endl;
	return 0;

}

