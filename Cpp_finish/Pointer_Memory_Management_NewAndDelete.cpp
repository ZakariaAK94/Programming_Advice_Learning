#include <iostream>
using namespace std;

int main()
{
	//declare an int pointer
	int *ptrX;
	//declare an float pointer
	float *ptrY;
	//dynamically allocate memory
	ptrX = new int;
	ptrY = new float;
	//assigning value to the memory
	*ptrX = 45;
	*ptrY = 10.5;

	cout << *ptrX << endl;
	cout << *ptrY << endl;

	delete ptrX;
	delete ptrY;

	system("pause>0");
}

