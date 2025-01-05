#include<iostream>
using namespace std;

enum enOperationType {Addition= '+', Multiplication = '*', Subtraction = '-', Division = '/' };



float ReadNumber(string Message )
{
	float Number = 0;
	cout << Message << endl;
	cin >> Number;
	
	return Number;

}

char ChoiceTypeOfOperation()
{
	char Operation;
	cout << "Please tap the operation you want to apply on these two number :\n";
	cout << " (+) : Addition " << endl;
	cout << " (*) : Multiplication " << endl;
	cout << " (-) : Subtraction " << endl;
	cout << " (/) : Division " << endl << endl;
	cin >> Operation;
	return Operation;
}

enOperationType ReadOpType()
{
	char OT = '+';
	cout << "******************************" << endl;
	cout << "Please enter your choice from the list bellow :" << endl;
	cout << " (+) : Addition " << endl;
	cout << " (*) : Multiplication " << endl;
	cout << " (-) : Subtraction " << endl;
	cout << " (/) : Division " << endl << endl;
	cin >> OT;
	return (enOperationType)OT;
}


float Calculate(float Number1, float Number2, float Number3, enOperationType OpType)
{
	switch ( OpType)
	{
	case enOperationType::Addition:
			return Number1 + Number2 + Number3;
	case enOperationType::Multiplication:
		return Number1 * Number2 * Number3;
	case enOperationType::Subtraction:
		return Number1 + Number2 + Number3;
	case enOperationType::Division:
		return Number1 / Number2;
	default:
		return Number1 + Number2 + Number3;
	}
}

int main()
{
	float Number1 = ReadNumber("Please enter the first number ?");
	float Number2 = ReadNumber("Please enter the second number ?");
	float Number3 = ReadNumber("Please enter the three number ?");
	enOperationType OpType = ReadOpType();
	cout << endl << " Result = " << Calculate(Number1, Number2,Number3, OpType) << endl;
	return 0;
}
