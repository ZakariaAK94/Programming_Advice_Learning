#include<iostream>
#include<string>
using namespace std;

class clsA
{
public:
	int var;
	static int counter;
	clsA()
	{
		counter += 5;
		cout << "the static member is :" << counter << endl;
	}

	void Print()
	{
		cout << "\nvar     = " << var << endl;
		cout << "counter = " << counter << endl;
	}
};

int clsA::counter = 0;//static variable initialisation outside the class

int main()
{
	clsA A1, A2,A3;
	A1.var = 10;
	A2.var = 20;  
	A3.var = 30;   
	A1.Print();
	A2.Print(); 
	A3.Print(); 
	clsA B1;
	B1.var = 10;
	B1.Print();
	clsA B2;
	B2.var = 20;
	B2.Print();
	clsA B3;
	B3.var = 30;
	B3.Print();
	A1.counter = 500;
	cout << "\nafter chaning the static member counter in one object:\n";  
	A1.Print();    
	A2.Print(); 
	A3.Print(); 
}