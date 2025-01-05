#include <iostream>
#include <vector>
using namespace std;

struct stYearMonthDay
{
    short Year;
    short Month;
    short Day;
};

short CalculateDayOfBirthday(stYearMonthDay UserData)
{
    short a,y,m,d;
    a = (14 - UserData.Month) / 12;
    y = UserData.Year - a;
    m = UserData.Month + 12 * a - 2;
    d = (UserData.Day + y + ((31 * m) / 12) + ((100 * y - 4 * y + y) / 400))%7;
    return d;
}


stYearMonthDay ReadUserData()
{
    stYearMonthDay UserData;
    cout << "\nPlease enter a Year ? " ;
    cin >> UserData.Year;
    cout << "\nPlease enter a Month ? ";
    cin >> UserData.Month;
    cout << "\nPlease enter a Day ? ";
    cin >> UserData.Day;
    
    return UserData;
}

string GetDayName(short d)
{
    string ArrDay[] = { "Sunday" ,"Monday" ,"Tuesday" ,"Wednesday" ,"Thursday" ,"Friday","Saturday" };
    
    return ArrDay[d];
    
}

void ShowResult()
{
    stYearMonthDay UserData;
    UserData = ReadUserData();
    short d = CalculateDayOfBirthday(UserData);
    cout << "Date      : " << UserData.Day << "/" << UserData.Month << "/" << UserData.Year << endl;
    cout << "Day order : " << d <<endl;
    cout << "Day name  : " << GetDayName(d);
}



int main()
{

    ShowResult();
    

    system("pause>0");
}

