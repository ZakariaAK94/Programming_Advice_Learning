#include <iostream>
#include <cmath>

using namespace std;

int main()
{
	short a, b, c;
	float p, Area;
	const float PI = 3.14;
	cout << "Could you please enter the three values of the triangle :" << endl;
	cin >> a;
	cin >> b;
	cin >> c;
	p = (a + b + c) / 2;
	Area = PI * pow(((a * b * c) / (4 * sqrt(p*(p-a)*(p-b)*(p-c)))), 2);
	cout << "The area based on the value of three variables is :" << round(Area) << endl;

	return 0;
}