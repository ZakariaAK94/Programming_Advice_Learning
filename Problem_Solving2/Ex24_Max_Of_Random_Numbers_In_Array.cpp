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

int MaxNumberInArray(int arr[100], int arrLength)
{
	int max = arr[0];
	for (int i = 0; i < arrLength; i++)
	{
		
		if (max < arr[i])
			max = arr[i];
	}

	return max;
}

int main()
{
	srand((unsigned)time(NULL));

	int arr[100], arrLength;
	FillArrayWithRandomNumbers(arr, arrLength);
	cout << "\nArray Elements : ";
	PrintArray(arr, arrLength);
	cout << "Max number is : " << MaxNumberInArray(arr, arrLength) << endl;

	return 0;
}
