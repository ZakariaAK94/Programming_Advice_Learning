#include <iostream>
#include <string>
using namespace std;

int main()
{
	//string st1 = "43.22334455";
	// convert string to int "stoi"
	//int N1 = stoi(st1);
	// convert string to float "stof"
	/*float N2 = stof(st1);*/
	// convert string to double "stod"
	//double N3 = stod(st1);

	/*cout << "int number = " << N1 << endl;
	cout << "float number = " << N2 << endl;
	cout << "double number = " << N3 << endl*/;

	//*****************************************************
    
	int N1 = 20;
	string stN1 = to_string(N1);
	float N2 = 33.5;
	string stN2 = to_string(N2);
	double N3 = 55.23;
	string stN3 = to_string(N3);
	cout << "string number = " << stN1 << endl;
	cout << "string number = " << stN2 << endl;
	cout << "string number = " << stN3 << endl;

	return 0;
}
