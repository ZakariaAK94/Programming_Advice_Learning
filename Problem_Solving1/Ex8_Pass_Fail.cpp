#include <iostream>
using namespace std;

enum enPassFail { Pass = 1, Fail =2 };

int ReadMark()
{
	int Mark;
	cout << "Please enter a Mark" << endl;
	cin >> Mark;
	return Mark;
}

enPassFail CheckMark(int Mark)
{
	if (Mark >= 50)
		return enPassFail::Pass;
	else
		return enPassFail::Fail;
}
//
//void PrintResults(enPassFail Mark)
//{
//	if (Mark == enPassFail::Pass)
//		cout << "You passed !!";
//	else
//		cout << "You failed !!";
//}

void PrintResult(int Number)
{
	if (CheckMark(Number) == enPassFail::Pass)
		cout << "You passed !!";
	else
		cout << "You failed !!";
}

int main()
{
	PrintResult(ReadMark());
	return 0;
}
