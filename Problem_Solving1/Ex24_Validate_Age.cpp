#include <iostream>
using namespace std;

int ReadAgeFromUser()
{
	int Age;
	cout << "Please enter an age between 18 and 45 ?" << endl;
	cin >> Age;
	return Age;
}

bool ValidateNumberInRange(int Age , int From, int To)
{
	return (Age >= From && Age <= To);
}

int RepetationUntilGetAgeInRange(int From, int To)
{
	int Age = 0;
	do
	{
		Age = ReadAgeFromUser();
	} while (!ValidateNumberInRange(Age, 18, 45));
	
	return Age;
}

void PrintResult(int Age)
{

	cout << "Validate Age is " << Age << endl;
}

int main()
{
	PrintResult(RepetationUntilGetAgeInRange(18,45));
	return 0;
}
