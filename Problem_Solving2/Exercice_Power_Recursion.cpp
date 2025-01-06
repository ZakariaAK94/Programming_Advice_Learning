#include <iostream>
#include "MyFunctions2.h";

using namespace std;
/*declaration of a function*/
int PowerMtoN2(int, int);

int main()
{
    cout << "the result is :" << PowerMtoN2(8, 2) << endl;
}

/* definition of a function */
int PowerMtoN2(int N, int M)
{
	if (0 < M)
		return N * PowerMtoN2(N, M - 1);
	else
		return 1;
}