#include <iostream>
using namespace std;

struct PointsDistance
{
	short a, b; 
	
};

int main()
{
	PointsDistance A, B;
	float distance;

	cout << "Please enter the two coordinates of the first point A :" << endl;
	cout << "Xa = ";
	cin >> A.a;
	cout << "Ya = ";
	cin >> A.b;
	cout << "Please enter the two coordinates of the second point B :" << endl;
	cout << "Xb = ";
	cin >> B.a;
	cout << "Yb = ";
	cin >> B.b;
	distance = sqrt(pow((B.a - A.a), 2) + pow((B.b - A.b), 2));
	cout << " la distance entre A(" << A.a << ";" << A.b << ") and B (" << B.a << "; " << B.b << ") est AB = " << distance << endl;
	return 0;


}