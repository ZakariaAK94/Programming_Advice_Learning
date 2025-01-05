#include <iostream>
using namespace std;

void ReadTableInformation(int Table[],int& Size)
{
	cout << " How Many Numbers do you want to enter ? 1 to 100 ?" << endl;
	cin >> Size;
	for (int i = 1; i <= Size; i++)
	{
		cout << "Please enter Number " << i << endl;
		cin >> Table[i];
	}
	
}
float CalculateSumOfTable(int Table[], int Size)
{
	float sum = 0;
	for (int i = 1; i <= Size; i++)
	{
		sum += Table[i];
	}
	return sum;
}
float CalculateAverageOfTable(int Table[], int Size)
{
	float Average;
	Average = (CalculateSumOfTable(Table, Size) / Size);
	return Average;
}
void PrintTableInformation(int Table[], int Size)
{
	for (int i = 1; i <= Size; i++)
	{
		cout << "Number [" << i << "] :" << Table[i] << endl;
	}
	cout << "**********************************\n";

	cout << "Sum : " << CalculateSumOfTable(Table,Size) << endl;
	cout << "Average : " << CalculateAverageOfTable(Table, Size) << endl;
	
}


int main()
{
	int Table[100], Size;
	ReadTableInformation(Table,Size);
	PrintTableInformation(Table, Size);
	return 0;
}
