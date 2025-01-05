#include <iostream>
#include<math.h>

#include "MyOwnLib.h";

using namespace std;



int main()
{
	float Number = MyOwnLib::ReadPositiveNumber("Please enter a number");
	cout << "My Round result : " << MyOwnLib::MyCeil(Number) << endl;
	cout << "C++ Round result : " << ceil(Number) << endl;
	return 0;

}
