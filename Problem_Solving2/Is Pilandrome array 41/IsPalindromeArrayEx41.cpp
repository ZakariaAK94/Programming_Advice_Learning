#include <iostream>
#include "MyLib.h";

using namespace std;

int main()
{
	int arrSource[100], arrLength = 0;
	MyLib::FillArray(arrSource, arrLength);
	MyLib::PrintArray(arrSource, arrLength);
	if (MyLib::IsPalindromeArray(arrSource,arrLength))
		cout << "\n Yes, Array is a Palindrome" << endl;
	else
		cout << "\n No, Array is not a Palindrome" << endl;

	return 0;

}







