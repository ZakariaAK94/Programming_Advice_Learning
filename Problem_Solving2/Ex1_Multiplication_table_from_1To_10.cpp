#include<iostream>
using namespace std;


void ShowTableForMultiplication(int A)
{
	for (int i = 1; i <= 10; i++)
		cout << A << " * " << i << " = " << A * i << endl;
}

void ShowTableForMultiplication1to10()
{
	for (int i = 1; i <= 10; i++)
	{
		cout << "********************" << endl;
		cout << "i = " << i << endl;
		ShowTableForMultiplication(i);
		cout << "********************" << endl;
	}
}


int main()
{
	ShowTableForMultiplication1to10();
	return 0;
}