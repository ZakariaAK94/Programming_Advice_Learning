#include<iostream>
#include<string>
#include<vector>
using namespace std;

string ReadString()
{
	string S1 = " ";
	cout << "Please enter your String ?" << endl;
	getline(cin, S1);

	return S1;

}

void PrintFirstLetterOfEachWord(string Phrase)
{
	cout << "First letters of this string is:" << endl;
	bool IsFirstLetter = true;
	for(char &Ptr : Phrase)
	{
		if (Ptr != ' ')
		{
			if(IsFirstLetter)
				cout << Ptr << endl;
		}		
		IsFirstLetter = (Ptr ==' ' ? true:false);			
	}
}

int main()
{
	PrintFirstLetterOfEachWord(ReadString());

	return 0;
}