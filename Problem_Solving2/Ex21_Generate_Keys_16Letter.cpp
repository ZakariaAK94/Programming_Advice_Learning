#include <iostream>
#include<cstdlib>

using namespace std;

enum enCharType { SmallLetter = 1, CapitalLetter = 2, SpecialCharacter = 3, Digit = 4 };

int ReadPositiveNumber(string Message)
{
	int Number = 0;
	do {
		cout << Message << endl;
		cin >> Number;
	} while (Number <=0 || Number >= 10);
	return Number;
}

int RandomNumber(int From, int To)
{
	int randNumber = rand() % (To - From + 1) + From;
	return randNumber;
}

char GetRandomCharacter(enCharType CharType)
{
	switch (CharType)
	{
	case enCharType::SmallLetter:
	{
		return char(RandomNumber(97, 122));
		break;
	}
	case enCharType::CapitalLetter:
	{
		return char(RandomNumber(65, 90));
		break;
	}
	case enCharType::SpecialCharacter:
	{
		return char(RandomNumber(33, 47));
		break;
	}
	case enCharType::Digit:
	{
		return char(RandomNumber(48, 57));
		break;
	}
	}
}

string GenerateWord(enCharType CharType, short length)
{
	string word;
	for (int i = 0; i <= length; i++)
	{
		word = word + char(GetRandomCharacter(CharType));
	}

	return word;
}

string GenerateKey()
{
	string key ="";
	key = GenerateWord(enCharType::CapitalLetter, 4) + '-';
	key = key + GenerateWord(enCharType::CapitalLetter, 4) + '-';
	key = key + GenerateWord(enCharType::CapitalLetter, 4) + '-';
	key = key + GenerateWord(enCharType::CapitalLetter, 4);
	return key;
}

void GenerateKeys(int Number)
{
	for (int i = 1; i <= Number; i++)
		cout << " Key [" << i << "] : " << GenerateKey() << endl;
}


int main()
{
	srand((unsigned)time(NULL));

	GenerateKeys(ReadPositiveNumber("Please how many keys would you like to generate ?"));
	
	return 0;
}
