#include <iostream>
using namespace std;

struct stRectangle
{
	int Length;
	int Width;
};

stRectangle ReadRectangleParameters()
{
	stRectangle Rectangle;
	cout << "Please enter the length of your rectangle :" << endl;
	cin >> Rectangle.Length;
	cout << "Please enter the length of your rectangle :" << endl;
	cin >> Rectangle.Width;
	return Rectangle;

}

int CalculateAreaOfRectangle(stRectangle Rectangle)
{
	return Rectangle.Length * Rectangle.Width;
}

void PrintResult(int Area)
{
	cout << " The area of your rectangle is : " << Area << endl<< endl;
}

int main()
{
	PrintResult(CalculateAreaOfRectangle(ReadRectangleParameters()));
    return 0;
}


