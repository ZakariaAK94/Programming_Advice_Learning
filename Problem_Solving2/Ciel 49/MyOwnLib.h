#pragma once

#include<iostream>
using namespace std;

namespace MyOwnLib {

	float ReadPositiveNumber(string Message)
	{
		float Number = 0;
		cout << Message << endl;
		cin >> Number;
		return Number;
	}

	int MyCeil(float Number)
	{
		int IntPart;
		IntPart = int(Number);

		if (Number > 0)
			return IntPart + 1;
		else
			return IntPart;

	}

}