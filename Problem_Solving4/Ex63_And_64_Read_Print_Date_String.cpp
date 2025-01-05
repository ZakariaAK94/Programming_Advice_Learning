#include <iostream>
#include<vector>
#include<string>
using namespace std;

struct stDate
{
    short Day;
    short Month;
    short Year;
};

vector <string> SplitString(string Line, string Delim )
{
    vector <string> SplitToWords;
    short pos = 0;
    string sWord = " "; // define a string variable

    //use find () function to get the position of delimiters
    while ((pos = Line.find(Delim)) != std::string::npos)
    {
        sWord = Line.substr(0, pos); // store the word
        if (sWord != "")
            SplitToWords.push_back(sWord);
        Line.erase(0, pos + Delim.length()); // erase() until position and move to next word 
    }
    if (Line != "")
        SplitToWords.push_back(Line); // it print last word of the string

    return SplitToWords;
}

stDate ChangeStringToDate(string DateString)
{
    stDate Date;
    vector <string> vDate = SplitString(DateString,"/");
    Date.Day = stoi(vDate[0]);
    Date.Month = stoi(vDate[1]);
    Date.Year = stoi(vDate[2]);

    return Date;
}

string ChangeDateToString(stDate Date)
{
    return to_string(Date.Day) + "/" + to_string(Date.Month) + "/" + to_string(Date.Year);
}



string ReadFullDate()
{
    string sDateUser;
    cout << "Please Enter a Date dd/mm/yyy : \n";
    getline(cin >>ws, sDateUser);
    return sDateUser;
}

int main()
{
    
     stDate Date = ChangeStringToDate(ReadFullDate());
     cout << "Day : " << Date.Day << endl;
     cout << "Month : " << Date.Month << endl;
     cout << "Year : " << Date.Year << endl;

     cout << "You entered : " << ChangeDateToString(Date) << endl;

    system("pause>0");
    return 0;
}
