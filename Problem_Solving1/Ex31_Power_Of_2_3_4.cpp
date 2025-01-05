#include <iostream>
#include <cmath>
using namespace std;

int main()
{
	short N, M;
	cout << "Please enter your number :" << endl;
	cin >> N;
	cout << "your number two times is : " << pow(N,2) << endl;
	cout << "your number three times is : " << pow(N, 3) << endl;
	cout << "your number four times is : " << pow(N, 4) << endl;
	cout << "Enter a number which will the power of your number :" << endl;
	cin >> M;
	cout << "The number N^M is :" << round(pow(N, M)) << endl;


	return 0;
}
