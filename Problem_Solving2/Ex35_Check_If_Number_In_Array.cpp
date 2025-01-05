#include <iostream>
#include<cstdlib>

using namespace std;

int RandomNumber(int From, int To)
{
	int randNumber = rand() % (To - From + 1) + From;
	return randNumber;
}

void FillArrayWithRandomNumber(int arr[100], int& arrLength)
{
	cout << "Please enter number of elements of the Arrray:" << endl;
	cin >> arrLength;
	for (int i = 0; i < arrLength; i++)
	{
		arr[i] = RandomNumber(1, 100);
	}

}


int ReadPositiveNumber(string Message)
{
	int Number = 0;
	do {
		cout << Message << endl;
		cin >> Number;
	} while (Number <= 0);
	return Number;
}


void PrintArray(int arr[100], int arrLength)
{
	cout << "\nArray Elements: ";
	for (int i = 0; i < arrLength; i++)
		cout << arr[i] << " ";
	cout << "\n";
}

short FindPositionAndOrderOfNumber(int Number, int arr[100], int arrLength)
{
	for (int i = 0; i < arrLength; i++)
	{
		if (Number == arr[i])
		{
			return i;
			
		}
	}
	return -1;

}

bool IsNumberInArray(int Number, int arr[100], int arrLength)
{
	return (FindPositionAndOrderOfNumber(Number,arr,arrLength)!=-1);

}


void PrintIfNumberInArrayOrNot(int Number, int arr[100], int arrLength)
{
		if (IsNumberInArray(Number,arr,arrLength))
		{
			cout << "Number you are looking for is :" << Number << endl;
			cout << "Yes, The number is found :-)" <<endl;
		}
		else
		{
			cout << "Number you are looking for is :" << Number << endl;
			cout << "No, The number is not found :-(" << endl;
		}
}

int main()
{
	int arr[100], arrLength, NumberToCheck;
	FillArrayWithRandomNumber(arr, arrLength);
	PrintArray(arr, arrLength);
	NumberToCheck = ReadPositiveNumber("Please Enter a number to search for ? ");
	PrintIfNumberInArrayOrNot(NumberToCheck, arr, arrLength);

	return 0;
}

