#include <iostream>

using namespace std;

enum enIsPrime { Prime = 1, Notprime = 2 };

enIsPrime CheckPrime(int Number)
{
	for (int i = 2; i <= sqrt(Number); i++)
	{
		if (Number % i == 0)
			return enIsPrime::Notprime;
	}
	return enIsPrime::Prime;

}

//void PrintPrimeNumbersFrom1ToN(int Number)
//{
//	int i = 1;
//	cout << "prime numbers from 1 to " << Number << " are :" << endl;
//	while (i <= Number)
//	{
//
//		switch (CheckPrime(i))
//		{
//		case Prime:
//			cout << i << endl;
//			break;
//		case Notprime:
//			break;
//		}
//		i++;
//	}
//
//}

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

void CopyOnlyPrimeNumbers(int arrSource[100], int arrDestination[100], int arrLength, int& arr2Length)
{
	int j = 0;
	for (int i = 0; i < arrLength; i++)
	{		
		if (CheckPrime(arrSource[i]) == enIsPrime::Prime)
		{
			arrDestination[j] = arrSource[i];
			j++;
		}
	}
	arr2Length = j;
}

int main()
{
	srand((unsigned)time(NULL));

	int arr[100], arrLength;
	int arr2[100], arr2Length;
	FillArrayWithRandomNumbers(arr, arrLength);
	cout << "\nArray 1 Elements : ";
	PrintArray(arr, arrLength);
	CopyOnlyPrimeNumbers(arr, arr2, arrLength, arr2Length);
	cout << "\nArray 2 Elements : ";
	PrintArray(arr2, arr2Length);

	return 0;
}








