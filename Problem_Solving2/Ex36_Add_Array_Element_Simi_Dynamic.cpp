#include <iostream>

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


void PrintArray(int arr[100], int arrLength)
{
	for (int i = 0; i < arrLength; i++)
		cout << arr[i] << " ";
	cout << "\n";
}

/*My solution for this problem*/
//short FillNumberInArray(int arr[100], int& arrLength)
//{
//	bool ChoiceUser;
//	do
//	{
//		cout << "Please enter a number ?";
//		cin >> arr[arrLength];
//		arrLength++;
//		cout << "Do you want to add more Numbers ?" << "[0]: No, [1]: Yes ?";
//		cin >> ChoiceUser;
//	} while (ChoiceUser == 1);
//
//
//		return arrLength;
//}


void AddArrayElement(int Number, int arr[100], int& arrLength)
{
	//its a new element so we need to add the length by 1
	 
	arr[arrLength] = Number;
	arrLength++;
} 
void InputUserNumbersInArray(int arr[100], int& arrLength) 
{
	bool AddMore = true;
	do {
		AddArrayElement(ReadPositiveNumber("Please enter a Number?"), arr, arrLength);
		cout << "\nDo you want to add more numbers? [0]:No,[1]:yes? ";
		cin >> AddMore;
	} while (AddMore);
}


int main()
{
	int arr[100], arrLength=0;
	/*cout << "\nArray Length :" << FillNumberInArray(arr, arrLength) << endl;
	PrintArray(arr, arrLength);*/
	InputUserNumbersInArray(arr, arrLength);    
	cout << "\nArray Length: " << arrLength << endl; 
	cout << "Array elements: ";   
	PrintArray(arr, arrLength);

	return 0;

}
