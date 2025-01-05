#pragma once
#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

namespace FctToApplyOnVectors
{
	void ReadNumber(vector <int> &Vector1)
	{
		int Number = 0;
		char ResultUser = 'N';
		char ReadMore = 'Y';

		while (ReadMore == 'Y' || ReadMore == 'y')
		{
			cout << "please enter a number :" << endl;
			cin >> Number;
			Vector1.push_back(Number);
			cout << "Do you like to add another number : Y / N ?" << endl;
			cin >> ReadMore;
		} 
	}

	void PrintVectorElement(vector <int> & Vector1)
	{
		cout << "The vector elements are :" << endl;
		for (int& Number : Vector1)
			cout << Number << " " << endl;
	}

	void SortInTheOpposeSense(vector <int>& Vector1)
	{
		 sort(Vector1.end(), Vector1.begin());
		for (int& Number : Vector1)
			cout << Number << " " << endl;
	}
}
