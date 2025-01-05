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

vector <string> SplitString(string S1, string Delim)
{
    vector <string> vString;
    short pos = 0;
    string sWord; // define a string variable 
    //use find()  function to get the position of the delimiters
    while ((pos = S1.find(Delim)) != std::string::npos)
    {
        sWord = S1.substr(0, pos); // store the word
        if (sWord != "")
        {
            vString.push_back(sWord);
        }
        S1.erase(0, pos + Delim.length());
    }
    if (S1 != "")
    {
        vString.push_back(S1); // it adds last word of the string.
    }
    return vString;
}

string ReplaceWordInStringUsingBuiltInFunction(string S1, string StringToReplace, string sReplaceTo)
{
    short pos = 0;
    while ((pos = S1.find(StringToReplace)) != std::string::npos)
    {
        S1.replace(pos, StringToReplace.length(), sReplaceTo);
    }

    return S1;
}

stDate ChangeStringToDate(string DateString)
{
    stDate Date;
    vector <string> vDate = SplitString(DateString, "-");
    Date.Day = stoi(vDate[0]);
    Date.Month = stoi(vDate[1]);
    Date.Year = stoi(vDate[2]);

    return Date;
}

string ChooseDateFormat(stDate Date, string S="dd-mm-yyyy")
{
    string S1 = S;
    S1 = ReplaceWordInStringUsingBuiltInFunction(S1, "dd", to_string(Date.Day));
    S1 = ReplaceWordInStringUsingBuiltInFunction(S1, "mm", to_string(Date.Month));
    S1 = ReplaceWordInStringUsingBuiltInFunction(S1, "yyyy", to_string(Date.Year));
    return S1;
}



string ReadFullDate()
{
    string sDateUser;
    cout << "Please Enter a Date dd/mm/yyy : \n";
    getline(cin >> ws, sDateUser);
    return sDateUser;
}

int main()
{

    stDate Date = ChangeStringToDate(ReadFullDate());
    cout << ChooseDateFormat(Date,"mm-dd-yyyy");
 
    
    system("pause>0");
    return 0;
}