#include <iostream>
#include<cstdlib>

using namespace std;

int RandoNumber(int From, int To)
{
	int RandNum = rand() % (To - From + 1) + From;
	return RandNum;
}

int main()
{
	srand((unsigned)time(NULL));

	cout << RandoNumber(5, 6) << endl;
	cout << RandoNumber(5, 6) << endl;
	cout << RandoNumber(5, 6) << endl;

	return 0;
}