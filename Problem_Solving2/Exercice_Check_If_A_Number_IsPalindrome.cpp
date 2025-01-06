#include <iostream>
#include <string>
using namespace std;

int ReadNumber(string Message)
{
	int Number;
	cout << Message << endl;
	cin >> Number;
	return Number;
}

void TestNumberAndItsInverse(int Number)
{
	string NumberStr = "";
	string NumberStrInv = "";
	NumberStr = to_string(Number);
	NumberStrInv = to_string(Number);
	int Counter = NumberStr.length();
	for (int i = 0; i < Counter ; i++)
	{
		NumberStrInv[i] = NumberStr[Counter - 1];
		Counter--;
	}
	if(NumberStr == NumberStrInv)
        cout << "The number is Palindrome !!" << endl;
    else
        cout << "The number is not Palindrome !!" << endl;

}

void TestNumberAndItsInverse2way(int Number)
{
	int TabNumber[50];
	bool IsResult = true;
	int i = 0, Counter=0;
	while (Number % 10 > 0)
   {
       
       TabNumber[i] = Number % 10;
       Number = (Number - TabNumber[i]) / 10;
       i++;
   }
	Counter = i - 1;
	for (int j = 0; j <= Counter/2; j++)
	{
		if (TabNumber[j] != TabNumber[Counter])
		{
			cout << "The number " + to_string(TabNumber[j]) + "in the position " + to_string(j) + " is different from the number " + to_string(TabNumber[Counter]) + "in the position " + to_string(Counter - 1) << endl;
			cout << "So number is not Palindrome" << endl;
			IsResult = false;
			break;
		}
		else
			Counter--;

	}
	if (IsResult)
		cout << "The number is Palindrome :)" << endl;
		
}

int main()
{
	/*TestNumberAndItsInverse(ReadNumber("Please enter a number to test ?"));*/
	TestNumberAndItsInverse2way(ReadNumber("Please enter a number to test ?"));

	return 0;
}




