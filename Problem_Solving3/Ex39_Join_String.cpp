#include <iostream>
#include<string>
#include<vector>

using namespace std;

string JoinString(vector<string> vString, string Delim)
{
    string S1 = "";
    for (string &Word : vString)
    {
        S1 = S1+ Word + Delim;
    }
    return S1.substr(0,S1.length()-Delim.length());
}



int main()
{
    vector <string> Words = { "Zakaria", "is", "the best", "programmer" };

    cout << "Vector after join : \n"<< JoinString(Words," ");
    

    system("pause>0");
}


