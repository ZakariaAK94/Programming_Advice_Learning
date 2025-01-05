#include <iostream>

using namespace std;

int ReadPositiveNumber(string Message)
{
	int Number = 0;
	do {
		cout << Message << endl;
		cin >> Number;
	} while (Number < 0);
	return Number;
}

void Swap(int& A, int& B)
{
	int Temp;
	Temp = A;
	A = B;
	B = Temp;
}

int RandomNumber(int From, int To)
{
	int randNumber = rand() % (To - From + 1) + From;
	return randNumber;
}

void CopyArray(int arrSource[100], int arrDestination[100], int arrLength)
{
	for (int i = 0; i < arrLength; i++)
	{
		arrDestination[i] = arrSource[i];
	}
}

void FillArrayWithRandomNumber(int arr[100], int arrLength)
{
	for (int i = 0; i < arrLength; i++)
	{
		arr[i] = RandomNumber(1,100);
	}

}

void CopyArrayInReversedOrder(int arrSource[100], int arrDestination[100], int arrLength)
{
	CopyArray(arrSource, arrDestination, arrLength);

	for (int j = 0; j <= arrLength / 2; j++)
	{
		swap(arrDestination[j], arrDestination[arrLength - j - 1]);
	}
}

void PrintArray(int arr[100], int arrLength)
{
	for (int i = 0; i < arrLength; i++)
		cout << arr[i] << " ";
	cout << "\n";
}


int main()
{
	srand((unsigned)time(NULL));

	int arr1[100];
	int arr2[100];
	int arrLength = ReadPositiveNumber("How many elements would you like to generate ?");
	cout << "\nArray 1 Elements : " << endl;
	FillArrayWithRandomNumber(arr1, arrLength);
	PrintArray(arr1, arrLength);
	cout << "\nArray 2 Elements after copying array 1 in reversed order : " << endl;
	CopyArrayInReversedOrder(arr1,arr2, arrLength);
	PrintArray(arr2, arrLength);

	return 0;
}
