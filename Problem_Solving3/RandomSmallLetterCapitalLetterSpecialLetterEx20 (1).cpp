#include <iostream>
#include<cstdlib>

using namespace std;

enum enCharType{ SmallLetter = 1, CapitalLetter =2, SpecialCharacter =3, Digit =4 };

//enCharType ReadChoiceOfUser()
//{
//	int Choice;
//	cout << "Please choose from the list below :" << endl;
//	cout << "(1) : Small Letters." << endl;
//	cout << "(2) : Capital Letters." << endl;
//	cout << "(3) : Special Letters." << endl;
//	cout << "(4) : Digit." << endl;
//	cin >> Choice;
//	return (enCharType)Choice;
//}
int RandomNumber(int From, int To)
{
	int randNumber = rand() % (To - From + 1) + From;
	return randNumber;
}

char GetRandomCharacter(enCharType CharType)
{
	switch (CharType) 
	{ 
		case enCharType::SmallLetter :
		{ 
			return char(RandomNumber(97, 122)); 
			break;   
		} 
		case enCharType::CapitalLetter : 
		{
			return char(RandomNumber(65, 90));
			break;    
		} 
		case enCharType::SpecialCharacter :
		{ 
			return char(RandomNumber(33, 47));
			break;    
		} 
		case enCharType::Digit : 
		{ 
			return char(RandomNumber(48, 57)); 
			break;  
		} 
	}
}

int main()
{
	srand((unsigned)time(NULL));
	cout << GetRandomCharacter(enCharType::SmallLetter) << endl; 
	cout << GetRandomCharacter(enCharType::CapitalLetter) << endl;  
	cout << GetRandomCharacter(enCharType::SpecialCharacter) << endl; 
	cout << GetRandomCharacter(enCharType::Digit) << endl;

	return 0;
}
