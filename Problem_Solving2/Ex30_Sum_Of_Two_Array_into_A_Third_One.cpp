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

void FillArrayWith1toN(int arr[100], int arrLength)
{
	for (int i = 0; i < arrLength; i++)
	{
		arr[i] = i+1;
	}

}

void ShuffleArray(int arr[100], int arrLength) 
{ 
	for (int i = 0; i < arrLength; i++)
	{
		int A = RandomNumber(1, arrLength) - 1;
		int B = RandomNumber(1, arrLength) - 1;
		Swap(arr[A], arr[B]);
	}
}

//void FillArrayWithRandomNumbers(int arr[100], int arrLength)
//{
//	arr[0] = RandomNumber(1, arrLength);
//	for (int i = 1; i < arrLength; i++)
//	{
//		arr[i] = RandomNumber(1, arrLength);
//		for (int j = 0; j <i; j++)
//		{
//			while (arr[i] == arr[j])
//			{
//				arr[i] = RandomNumber(1, arrLength);
//				j = 0;
//			}
//		}
//
//			
//	}
//	
//	
//}

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
	int arrLength = ReadPositiveNumber("How many elements would you like to generate ?");
	cout << "\nArray Elements before shuffle : " << endl;
	FillArrayWith1toN(arr1, arrLength);
	PrintArray(arr1, arrLength);
	cout << "\nArray Elements after shuffle : " << endl;
	ShuffleArray(arr1, arrLength);
	PrintArray(arr1, arrLength);

	return 0;
}
