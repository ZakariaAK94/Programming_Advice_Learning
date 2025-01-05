#include <iostream>

using namespace std;

int RandomNumber(int From, int To)
{
	int randNumber = rand() % (To - From + 1) + From;
	return randNumber;
}

void FillArrayWithRandomNumber(int arr[100], int arrLength)
{
	for (int i = 0; i < arrLength; i++)
	{
		arr[i] = RandomNumber(1,100);
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

//int TimesRepeated(int Number, int arr[100], int arrLength)
//{
//	int count = 0;
//	for (int i = 0; i < arrLength; i++)
//	{
//		if (Number == arr[i])
//			count++;
//	}
//	return count;
//}


void ShowPositionAndOrderOfNumber(int Number, int arr[100], int arrLength)
{
	int count = 1;
	bool IsExist = false;
	for (int i = 0; i < arrLength; i++)
	{
		if (Number == arr[i])
		{
			cout << "Number you are looking for is :" << Number << " for "<< count << " time(s)"<< endl;
			cout << "The number found at position :" << i << endl;
			cout << "The number found its order :" << i + 1 << endl;
			count++;
			IsExist = true;
		}
	}
	if(IsExist==false)
		cout << "The number is not found:-(" << endl;

}

int main()
{
	int arr[100], arrLength, NumberToCheck;
	arrLength = ReadPositiveNumber("Please enter number of elements of the Arrray:");
	FillArrayWithRandomNumber(arr, arrLength);
	PrintArray(arr, arrLength);
	NumberToCheck = ReadPositiveNumber("Please Enter a number to search for ? ");
	ShowPositionAndOrderOfNumber(NumberToCheck, arr, arrLength);
	
	return 0;
}
