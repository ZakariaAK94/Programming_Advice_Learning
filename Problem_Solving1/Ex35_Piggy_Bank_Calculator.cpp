#include <iostream>
using namespace std;

int main()
{
	short a, b, c, d, e;
	float sumtotal;
	cout << "Please enter quatity of Pennies, Nickels, Dimes, Quarters, Dollars :" << endl;
	cin >> a;
	cin >> b;
	cin >> c; 
	cin >> d; 
	cin >> e;
	sumtotal = a + (b * 5 )+ (c * 10) + (d * 25) + (e * 100);
	cout << "The total pennies is :" << sumtotal << endl;
	cout << "The total dollars is : " << sumtotal / 100 << endl;

	return 0;

}
