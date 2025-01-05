#include <iostream>
#include <cmath>
using namespace std;

int main()
{
	short a, b; /*d, l;*/
	/*float r;*/
	const float PI = 3.14;
	/*cout << "Please enter the two values a and d to calcualte the area of the rectangle :" << endl;
	cin >> a;
	cin >> d;
	cout << "the result is :" << a * sqrt(pow(d, 2) - pow(a, 2)) << endl;

	cout << "Please enter the rayon of the circle r :" << endl;
	cin >> r;
	cout << "The Area of the circle is:" << ceil(PI * pow(r, 2)) << endl;
	cout << "Please enter the diameter of the circle d :" << endl;
	cin >> d;
	cout << "The Area of the circle is:" << ceil((PI * pow(d, 2))/4) << endl;
	cout << "Please enter the circumference l :" << endl;
	cin >> l;
	cout << "The Area of the circle is :" << floor(pow(l, 2) / (4 * PI)) << endl;*/
	cout << "Please enter the two values a and b to calcualte the area of the circle:" << endl;
	cin >> a;
	cin >> b;
	cout << "the result is :" <<floor((PI * pow(b,2) * (2*a-b))/(4*(2*a+b)))<< endl;

	return 0;
}