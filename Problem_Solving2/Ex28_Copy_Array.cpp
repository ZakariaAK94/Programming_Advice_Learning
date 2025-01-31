#include <iostream>

using namespace std;

int RandomNumber(int From, int To)
{
	int randNumber = rand() % (To - From + 1) + From;
	return randNumber;
}

void FillArrayWithRandomNumbers(int arr[100], int& arrLength)
{
	cout << "\nEnter number of elements:\n";
	cin >> arrLength;
	for (int i = 0; i < arrLength; i++)
	{
		arr[i] = RandomNumber(1, 100);
	}
	cout << endl;
}


void PrintArray(int arr[100], int arrLength)
{
	for (int i = 0; i < arrLength; i++)
		cout << arr[i] << " ";
	cout << "\n";
}

void CopyArray(int arrSource[100],int arrDestination[100], int arrLength)
{
	for (int i = 0; i < arrLength; i++)
	{
		arrDestination[i] = arrSource[i];
	}
}

int main()
{
	srand((unsigned)time(NULL));

	int arr[100], arr2[100], arrLength;
	FillArrayWithRandomNumbers(arr, arrLength);
	cout << "\nArray 1 Elements : ";
	PrintArray(arr, arrLength);
	CopyArray(arr, arr2, arrLength);
	cout << "\nArray 2 Elements : ";
	PrintArray(arr2, arrLength);

	return 0;
}

