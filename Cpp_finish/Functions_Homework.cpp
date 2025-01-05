#include <iostream>
using namespace std;

void DisplayMyCardInfo()
{
	string Name = "Mohammed Abu-Hadhoud";
	short Age = 44;
	string City = "Amman";
	string Country = "Jordan";

	cout << "My first Function :" << endl;
	cout << "*********************" << endl;
	cout << "Name:" << Name << ".\n";
	cout << "Age:" << Age << ".\n";
	cout << "City:" << City << ".\n";
	cout << "Country:" << Country << ".\n";
	cout << "*********************" << ".\n\n";
}
void PrintSquareStarts()
{
	cout << "My second function :" << endl;
	cout << "**********" << endl;
	cout << "**********" << endl;
	cout << "**********" << endl;
	cout << "**********" << endl<<endl;
}

void I_Love_Programming()
{
	cout << "My third function:" << endl << endl;
	cout << "I love programming." << endl;
	cout << "I promise to be the best developer ever!!!" << endl;
	cout << "I know it will take some time to practice, but I will achieve my goal." << endl << endl;
	cout << "Best Regards," << endl;
	cout << "Zakarai AKIL" << endl << endl;
}

void Print_H()
{
	cout << "My Fourth function :" << endl << endl;
	cout << "*         *" << endl;
	cout << "*         *" << endl;
	cout << "*         *" << endl;
	cout << "***********" << endl;
	cout << "*         *" << endl;
	cout << "*         *" << endl; 
	cout << "*         *" << endl << endl; 
}



int main()
{
	DisplayMyCardInfo();
	PrintSquareStarts();
	I_Love_Programming();
	Print_H();
	return 0;
}