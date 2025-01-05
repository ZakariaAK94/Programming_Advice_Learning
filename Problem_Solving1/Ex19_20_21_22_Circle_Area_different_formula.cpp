#include <iostream>
using namespace std;

int main()
{
	short D, l , a, b;
	const float PI = 3.14;

	cout << "Please entre the diameter of your circle or the the length of the Square where the circle inscribed in :" << endl;
	cin >> D ;
	cout << "The Area of your circle is :" << (PI * D * D) / 4 << endl;
	cout << "Please enter the value of circumference :" << endl;
	cin >> l;
	cout << "The Area of your circle is:" << (l * l) / (PI * 4) << endl;
	cout << "Please enter two values of the Isosceles Triangle to calculate your circle :" << endl;
	cin >> a;
	cin >> b;
	cout << "the area of your circle is :" << (PI * b * b * (2 * a - b) / (4 * (2 * a + b)));


	return 0;
}
