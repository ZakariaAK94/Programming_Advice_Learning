#pragma once
#include<iostream>
#include<cctype>
#include<string>
#include"clsUtil.h"
using namespace std;

class clsInputValidate
{
public:
	
	static bool IsNumberBetween(short NumberTocheck, short From, short To)
	{
		return  (NumberTocheck >= From && NumberTocheck <= To);
	}
	static bool IsNumberBetween(int NumberTocheck, int From, int To)
	{
		return  (NumberTocheck >= From && NumberTocheck <= To);
	}

	static bool IsNumberBetween(float NumberTocheck, float From, float To)
	{
		return (NumberTocheck >= From && NumberTocheck <= To);
	}
	static bool IsNumberBetween(double NumberTocheck, double From, double To)
	{
		return (NumberTocheck >= From && NumberTocheck <= To);
	}

	static bool IsDateBetween(clsDate DateToCheck, clsDate Date1, clsDate Date2)
	{
		if (clsDate::IsDate1AfterDate2(Date1, Date2))
			clsUtil::Swap(Date1, Date2);

		return (clsDate::IsDate1AfterDate2(DateToCheck, Date1) || clsDate::IsDate1EqualDate2(DateToCheck, Date1))
			&& (clsDate::IsDate1BeforeDate2(DateToCheck, Date2) || clsDate::IsDate1EqualDate2(DateToCheck, Date2));
	}


	static int ReadIntNumber(string ErrorMessage = "Invalid Number, Enter again\n")
	{
		int Number;
		while (!(cin >> Number))
		{
			cin.clear();
			cin.ignore(numeric_limits<streamsize>::max(), '\n');
			cout << ErrorMessage;
		}
		return Number;
	}

	static int ReadIntNumberBetween(int From, int To, string ErrorMessage = "Number is not within range, Enter again:\n")
	{
		int Number = ReadIntNumber();

		while (!IsNumberBetween(Number, From, To))
		{
			cout << ErrorMessage;
			Number = ReadIntNumber();
		}
		return Number;
	}

	static double ReadDblNumber(string ErrorMessage = "Invalid Number, Enter again\n")
	{
		double Number;
		while (!(cin >> Number)) {
			cin.clear();
			cin.ignore(numeric_limits<streamsize>::max(), '\n');
			cout << ErrorMessage;
		}
		return Number;
	}

	static double ReadDblNumberBetween(double From, double To, string ErrorMessage = "Number is not within range, Enter again:\n")
	{
		double Number = ReadDblNumber();

		while (!IsNumberBetween(Number, From, To)) {
			cout << ErrorMessage;
			Number = ReadDblNumber();
		}
		return Number;
	}


	static bool IsValideDate(clsDate Date)
	{
		return clsDate::IsValidDate(Date);
	}

};



