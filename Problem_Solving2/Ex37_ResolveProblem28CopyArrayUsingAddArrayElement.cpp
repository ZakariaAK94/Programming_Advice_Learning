#include <iostream>
#include<cstdlib>
using namespace std;

int ReadPositiveNumber(string Message)
{
	int Number = 0;
	do {
		cout << Message << endl;
		cin >> Number;
	} while (Number <= 0);
	return Number;
}

int RandomNumber(int From, int To)
{
	int randNumber = rand() % (To - From + 1) + From;
	return randNumber;
}

void FillArrayWithRandomNumber(int arr[100], int& arrLength)
{
	arrLength = ReadPositiveNumber("Please enter how many elements do you want to generate?");
	for (int i = 0; i < arrLength; i++)
	{
		arr[i] = RandomNumber(1, 100);
	}

}


void PrintArray(int arr[100], int arrLength)
{
	for (int i = 0; i < arrLength; i++)
		cout << arr[i] << " ";
	cout << "\n";
}



void AddArrayElement(int Number, int arr[100], int& arrLength)
{
	//its a new element so we need to add the length by 1
	arr[arrLength] = Number;
	arrLength++;
}

void CopyArrayElementByAddElement(int arrSource[100], int arrDestination[100], int arrLength, int& arrDestinationLength)
{
	while (arrDestinationLength < arrLength)
	{
		AddArrayElement(arrSource[arrDestinationLength], arrDestination, arrDestinationLength);
	}
	
}



int main()
{
	srand((unsigned)time(NULL));

	int arr1[100],arr2[100], arrLength = 0, arrDestinationLength=0;
	FillArrayWithRandomNumber(arr1, arrLength);
	cout << "\nArray 1 elements : " << endl;
	PrintArray(arr1, arrLength);
	CopyArrayElementByAddElement(arr1, arr2, arrLength, arrDestinationLength);
	cout << "\nArray 2 elements after copy: " << endl;
	PrintArray(arr2, arrLength);

	return 0;

}
