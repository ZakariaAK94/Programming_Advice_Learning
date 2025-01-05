#include <iostream>
using namespace std;

enum enChoiceOfTypeOfLoop{ ByForLoop=1, ByWhileLoop=2, ByDoWhileLoop};
enum enChoiceSumOfOddorEvenNumbers { Odd = 2, Even = 1 };

enChoiceOfTypeOfLoop ChoiceOfTHeUser()
{
	int choice;
	cout << " Please choose which Loop do you want to use :" << endl;
	cout << " (1) : Using For Loop :" << endl;
	cout << " (2) : Using While Loop :" << endl;
	cout << " (3) : Using Do While Loop :" << endl;
	cin >> choice;
	return (enChoiceOfTypeOfLoop)choice;
}

enChoiceSumOfOddorEvenNumbers ChoiceParity()
{
	int choice;
	cout << " Please choose which Sum do you want to calculate :" << endl;
	cout << " (1) : Even Numbers :" << endl;
	cout << " (2) : Odd Numbers :" << endl;
	cin >> choice;
	return (enChoiceSumOfOddorEvenNumbers)choice;
}
	

int ReadNumber(int& N)
{
	do
	{
		cout << " Please enter a number positive :" << endl;
		cin >> N;
	} while (N <= 0);
	
	return N;
}

void PrintNumberFrom1toNUsingForLoop(int N, bool reversed)
{
	cout << "With For Loop " << endl;
	if (reversed)
	{
		for (int i = N; 1 <= i; i--)
		{
			cout << i << endl;
		}
	}
	else
	{
		for (int j = 1; j <= N; j++)
		{
			cout << j << endl;
		}
	}

}
void PrintNumberFrom1toNUsingWhileLoop(int N, bool reversed)
{
	cout << "With While Loop " << endl;
	int counter = N, i = 1;
	if (reversed)
	{
		while (1 <= counter)
		{
			cout << counter << endl;
			counter--;
		}
	}
	else
	{	while (i <= N)
		{
			cout << i << endl;
			i++;
		}
    }

}
void PrintNumberFrom1toNUsingDoWhileLoop(int N, bool reversed)
{
	cout << "With Do While Loop " << endl;
	if (reversed)
	{
		int counter = N;
		do
		{
			cout << counter << endl;
			counter--;
		} while (1 <= counter);

	}
	else
	{
		int i=1;
		do
		{
			cout << i << endl;
			i++;
		} while (i <= N);

	}
	
}

int CalculateSumOfNumbersOddorEvenBtw1toN(enChoiceSumOfOddorEvenNumbers ChoiceParity,int N)
{
	int sum = 0;
	if (ChoiceParity == enChoiceSumOfOddorEvenNumbers::Even)
	{
		for (int i = 1; i <= N; i++)
		{
			if (i % 2 != 0)
				continue;
			else
				sum += i;
		}
	}
	else
	{
		for (int i = 1; i <= N; i++)
		{
			if (i % 2 == 0)
				continue;
			else
				sum += i;
		}

	}
	return sum;
}

void ShowResultToUser(enChoiceOfTypeOfLoop choice, int N)
{
	if (choice == enChoiceOfTypeOfLoop::ByForLoop)
		PrintNumberFrom1toNUsingForLoop(N, false);
	else if (choice == enChoiceOfTypeOfLoop::ByWhileLoop)
		PrintNumberFrom1toNUsingWhileLoop(N, false);
	else
		PrintNumberFrom1toNUsingDoWhileLoop(N, false);
}

void ShowResultofCalculationEvenOrOddNumbers(int Sum)
{
	cout << "The result is :" << Sum << endl;
}

int main()
{
	int N=ReadNumber(N);
	ShowResultToUser(ChoiceOfTHeUser(),N);
	ShowResultofCalculationEvenOrOddNumbers(CalculateSumOfNumbersOddorEvenBtw1toN(ChoiceParity(), N));
	return 0;
}