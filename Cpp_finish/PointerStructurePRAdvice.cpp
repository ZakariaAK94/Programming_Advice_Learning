#pragma warning(disable : 4996)

#include<iostream>
#include<ctime>
using namespace std; 
struct stEmplyee
{
	string Name;
	float Salary; 
};

//struct tm
//{
//	int tm_sec; // seconds of minutes from 0 to 61  
//	int tm_min; // minutes of hour from 0 to 59  
//	int tm_hour; // hours of day from 0 to 24  
//	int tm_mday; // day of month from 1 to 31  
//	int tm_mon; // month of year from 0 to 11  
//	int tm_year; // year since 1900 
//	int tm_wday; // days since sunday
//	int tm_yday; // days since January 1st 
//	int tm_isdst; // hours of daylight savings time
//};

int main()
{
	
	//example of void pointer we use *(static_cast<type de variable *> (name of pointer))
	/*void* ptr1;

	int x = 50;
	float y = 100;

	ptr1 = &x;
	cout << *(static_cast<int*>(ptr1));

	ptr1 = &y;
	cout << *(static_cast<float*>(ptr1));*/
	//we use pointer 
	int* ptrX;
	int* ptrY;
	int Taille;
	cout << "Please entere number of the table you wanna create:" << endl;
	cin >> Taille;
	ptrX = new int[Taille];
	delete[] ptrX;
	ptrY = new int;

	*ptrX = 10;
	*ptrY = 20;

	delete ptrX;
	delete ptrY;
		
	
	stEmplyee Employee1, *ptr;

	tm* CurrentDate ;

	Employee1.Name = "Mohammed Abu-Hadhoud"; 
	Employee1.Salary = 5000;

	cout << Employee1.Name << endl;     
	cout << Employee1.Salary << endl;

	ptr = &Employee1;

	cout << "\nUsing Pointer:\n"; 

	cout << ptr->Name << endl;
	cout << ptr->Salary << endl;

	 
	time_t t = time(0);   // get time now
	char* dt = ctime(&t);   // convert in string form  
	cout << "Local date and time is: " << dt << "\n";    // converting now to tm struct for UTC date/time
	tm* gmtm = gmtime(&t);    
	dt = asctime(gmtm);    
	cout << "UTC date and time is: " << dt;

	return 0;
} 

