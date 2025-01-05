#include <iostream>
using namespace std;

enum enTypeOfNumbers { odd = 1, even=2 };

int ReadNumber()
{
	int Number;
	cout << "Please enter a number to check if it is even or odd ? " << endl;
	cin >> Number;
	return Number;
}
enTypeOfNumbers CheckTYpeOfNumber(int Number)
{
	if (Number % 2 == 0)
	{
		return enTypeOfNumbers::even;
	}
	else
		return enTypeOfNumbers::odd;

}

void CheckParityOfNumbers(enTypeOfNumbers TypeNumber)
{
	if (TypeNumber == enTypeOfNumbers::even)
	{
		cout << "The number is Even." << endl;
	}
	else
		cout << "The number is Odd." << endl;
}

int main()
{
	CheckParityOfNumbers(CheckTYpeOfNumber(ReadNumber()));
	return 0;
}
