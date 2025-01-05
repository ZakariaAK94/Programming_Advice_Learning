#pragma once

#include<iostream>
#include<string>
using namespace std;

struct stDate1
{
    short Days;
    short Month;
    short Year;
};

namespace myInput {

    int NumberOfDaysToAdd()
    {
        int nbrdays;
        cout << "\nPlease enter number of days to add ? ";
        cin >> nbrdays;

        return nbrdays;
    }


   

    stDate1 ReadDataFromUser(string Message)
    {
        stDate1 DateBeforeAddingDays;
        cout << Message;
        cout << "\nPlease enter a Day ? ";
        cin >> DateBeforeAddingDays.Days;
        cout << "\nPlease enter a Month ? ";
        cin >> DateBeforeAddingDays.Month;
        cout << "\nPlease enter a Year ? ";
        cin >> DateBeforeAddingDays.Year;


        return DateBeforeAddingDays;
    }
}