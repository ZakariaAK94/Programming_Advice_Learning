#include <iostream>
using namespace std;

enum enTypeOfParity{ Odd=1, Even=2, All=3};


enTypeOfParity ReadTypeOfOperationUsing()
{
	int Choice=0;
	cout << "Please choose the type of operation you would like to apply :" << endl;
	cout << " (1) : Sum of Odd Numbers between 1 to N." << endl; 
	cout << " (2) : Sum of Even Numbers between 1 to N." << endl;
	cout << " (3) : Sum of All Numbers etween 1 to N." << endl;
	cout << "*************************************************************" << endl;
	cin >> Choice;
	return (enTypeOfParity) Choice;
}

enTypeOfParity CheckIfNumberIsOddOrEven(int N)
{
	if (N % 2 == 0)
		return enTypeOfParity::Even;
	else
		return enTypeOfParity::Odd;
}

int CalculateSumOfNumbersOddOrEven(enTypeOfParity Choice)
{
	cout << "*****************************************\n";
	int From = 0, To = 0;
	cout << "Please enter the range (From ; To) where you want to start and finish your calculation :" << endl;
	cout << "From :";
	cin >> From;
	cout << "To :";
	cin >> To;
	cout << "*****************************************\n";
	cout << "Numbers are : (";
	int sum = 0;
	if (Choice == enTypeOfParity::Odd)
	{
		for (int i = From; i <= To; i++)
		{
			if (CheckIfNumberIsOddOrEven(i) == enTypeOfParity::Odd)
			{
				cout << i << " ; ";
				sum += i;
			}
		}
		cout << " )";
		return sum;
	}
	else if (Choice == enTypeOfParity::Even)
	{
		for (int i = From; i <= To; i++)
		{
			if (CheckIfNumberIsOddOrEven(i) == enTypeOfParity::Even)
			{
				cout << i << " ; ";
				sum += i;
			}
		}
		cout << " )";
		return sum;

	}
	else
	{
		for (int i = From; i <= To; i++)
		{
			cout << i << " ; ";
			sum += i;
		}
		cout << " )";
		return sum;

	}

}

void PrintResult(int sum)
{
	cout << "\n*****************************************\n";
	cout << " \n == >  The sum is :" << sum << endl;
}


int main()
{
	PrintResult(CalculateSumOfNumbersOddOrEven(ReadTypeOfOperationUsing()));
	return 0;
}