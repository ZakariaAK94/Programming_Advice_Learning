#include <iostream>
using namespace std;

void PrintNumberFromNTo1(int& Number)
{
	cout << "Please enter a number :" << endl;
	cin >> Number;
	int Counter = Number;
	while (Counter != 0)
	{
		cout << " - " << Counter ;
		Counter--;
	}
	cout << "\n";

}
void PrintNumberFrom1ToN(int& Number)
{
	cout << "Please enter a number :" << endl;
	cin >> Number;
	int i = 1;
	while (i<=Number)
	{
		cout << i << endl;
		i++;
	}


}
int SumOfOddNumber(int Number)
{
	int sum = 0, i=1;
	while (i <= Number)
	{
		if (i % 2 != 0)
			sum += i;
		i++;
	}
	return sum;
}
int SumOfEvenNumber(int Number)
{
	int sum = 0, i = 2;
	while (i <= Number)
	{
		if (i % 2 == 0)
			sum += i;
		i++;
	}
	return sum;
}
int SumUntilAspecificNumber()
{
	int sum = 0;
	int Joker;
	cout << "Please enter a Number " << endl;
	cin >> Joker;
	while (Joker != -99)
	{
		sum += Joker;
		cout << "Please enter a Number " << endl;
		cin >> Joker;
	}
	return sum;
}

int FactorialNumberwithWhile(int& Number)
{
	int sum = 1;
	cout << "Please enter a Number " << endl;
	cin >> Number;
	while (Number < 0)
	{
		cout << "Please enter a Number positive " << endl;
		cin >> Number;

	}
	if (Number == 0 || Number == 1)
	{
		return sum;
	}
	else
	{
		int Counter = Number;
		while (Counter != 1)
		{
			sum *= Counter;
			Counter--;
		}
		return sum;
	}
}




int main()
{
	int Number;
	int SumFactorial;
	SumFactorial = FactorialNumberwithWhile(Number);
	cout << Number << "! "<< SumFactorial << endl;
	return 0;
}
