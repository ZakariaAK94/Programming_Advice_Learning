#include <iostream>
#include<string>
#include<vector>

using namespace std;

string ReadString()
{
    string S1;
    cout << "Please enter your string ?\n";
    getline(cin,S1);

    return S1;
}

vector <string> SplitString(string S1, string Delim)
{
    vector <string> vString;
    short pos = 0;
    string sWord;
    while ((pos = S1.find(Delim)) != std::string::npos)
    {
        sWord = S1.substr(0, pos);
        if (sWord != "")
        {
            vString.push_back(sWord);
        }
        S1.erase(0, pos+Delim.length());
    }
    if (S1 != "")
    {
        vString.push_back(S1);
    }
    return vString;
}

string ReverseWordInString(string S1, string Delim)
{
    vector <string> vString;
    string S2 = "";
    vString = SplitString(S1,Delim);
    vector <string>::iterator iter = vString.end();
    while (iter != vString.begin())
    {   
        --iter;
        S2 += *iter + Delim;
    }

    return S2.substr(0, S2.length() - Delim.length());
}

int main()
{
    string S1 = ReadString();
       
    /* Method 3 for this problem */
    cout << "\nString after reversing words with method 3:" << endl;
    cout << ReverseWordInString(S1," ");
    
    system("pause>0");
}