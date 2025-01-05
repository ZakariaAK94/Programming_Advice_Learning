#include <iostream>
#include "MyFunctions.h";
using namespace std;
using namespace MyFunctions;

int main()
{
	int arr[100], arrLength = 0;
	FillArrayWithRandomNumber(arr, arrLength);
	cout << "\nArray 1 elements : " << endl;
	PrintArray(arr, arrLength);
	cout << "\n Odd Number Count : " << TimesRepeatedOddNumber(arr,arrLength) << endl;
	cout << "\n Even Number Count : " << arrLength-TimesRepeatedOddNumber(arr,arrLength) << endl;
	
    return 0;

}











void AddArrayElement(int Number, int arr[100], int& arrLength)
{
	//its a new element so we need to add the length by 1

	arr[arrLength] = Number;
	arrLength++;
}

void CopyOddElementToNewArray(int arrSource[100], int arrDestination[100], int arrLength, int& arrDestinationLength)
{
	int i = 0;
	while (i < arrLength)
	{
		if (IsOddNumber(arrSource[i]))
			AddArrayElement(arrSource[i], arrDestination, arrDestinationLength);
		i++;
	}

}
