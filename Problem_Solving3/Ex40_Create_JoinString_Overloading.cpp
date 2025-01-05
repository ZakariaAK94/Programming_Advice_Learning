#include <iostream>
#include<string>
#include<vector>

using namespace std;

string JoinString(vector<string> vString, string Delim)
{
    string S1 = "";
    for (string& Word : vString)
    {
        S1 = S1 + Word + Delim;
    }
    return S1.substr(0, S1.length() - Delim.length());
}

string JoinString(string arrString[4], short Length, string Delim)
{
    string S1 = "";
    for (int i=0; i<Length;i++)
    {
        S1 = S1 + arrString[i] + Delim;
        
    }
    return S1.substr(0, S1.length() - Delim.length());
}



int main()
{
    vector <string> Words = { "Zakaria", "is", "the best", "programmer" };
    string arrString[] = {"Zakaria", "is", "the best", "programmer"};

    cout << "Vector after join : \n" << JoinString(Words, " ");
    cout << "\nArray after join : \n" << JoinString(arrString,4, " ");


    system("pause>0");
}

