#include <iostream>
#include <string>
using namespace std;

int ReadNumber()
{
	int Number;
	cout << "Please enter a Number :" << endl;
	cin >> Number;

	return Number;
}

float CalculateHalfOfNumber(float Number)
{
	return (float) Number / 2;
}

void PrintResult(float Number)
{
	string Result = "";
	Result = "The Half of " + to_string(Number) + " is " + to_string(CalculateHalfOfNumber(Number));
	cout << endl << Result << endl;
}


int main()
{
	PrintResult(ReadNumber());
	return 0;
}
