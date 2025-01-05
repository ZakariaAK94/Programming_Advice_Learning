#include <iostream>
#include <vector>
#include "MyFunctions.h";
using namespace std;

int main()
{
	char IsRemove = 'Y';
	vector <stEmployesInfo> vUsers;
	MyFunctions::ReadInforEmployes(vUsers);
	MyFunctions::PrintInfoEmployes(vUsers);
	cout << "Do you want to remove elements from your data ? Y/N ?" << endl;
	cin >> IsRemove;
	if (IsRemove == 'Y')
	{
		MyFunctions::RemoveElemsFromVectrs(vUsers);
	}
	MyFunctions::PrintInfoEmployes(vUsers);
}


