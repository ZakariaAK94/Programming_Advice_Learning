#pragma once

#include <iostream>
using namespace std;

namespace MyLib
{
	int ReadPositiveNumber()
	{
		int Number = 0;
		do
		{
			cout << "Please enter number of elements ? \n";
			cin >> Number;
		} while (Number <= 0);
		return Number;
	}

	void FillArray(int arr[100], int& arrLength)
	{
		arrLength = ReadPositiveNumber();
		for (int i = 0; i < arrLength; i++)
		{
			cout << "Please enter a number N° " << i << ": ";
			cin >> arr[i];
		}
	}

	void PrintArray(int arr[100], int arrLength)
	{
		for (int i = 0; i < arrLength; i++)
			cout << arr[i] << " ";
		cout << "\n";
	}

	bool IsPalindromeArray(int arrSource[100], int arrLength)
	{

		for (int i = 0; i <= arrLength / 2; i++)
			if (arrSource[i] != arrSource[arrLength - i - 1])
				return false;
		return true;
	}

}

