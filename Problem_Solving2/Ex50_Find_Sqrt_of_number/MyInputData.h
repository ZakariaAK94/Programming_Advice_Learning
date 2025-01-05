#pragma once

#include<iostream>

using namespace std;

namespace MyInputData
{
	int ReadPositiveNumber(string Message)
	{
		float Number = 0;
		cout << Message << endl;
		cin >> Number;
		return Number;
	}

	int MySqrt(int Number)
	{
		for (int i = 0; i <= Number / 2; i++)
			if (i * i == Number)
				return i;
		return 0;
	}
}