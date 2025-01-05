#include <iostream>
#include<string>
#include<vector>
using namespace std;

string ReadString()
{
    string S1 = " ";
    cout << "Please enter your string ?" << endl;
    getline(cin, S1);
    return S1;
}

vector <string> SplitString(string S1, string delim, vector <string> &SplitToWords)
{
    
    short pos = 0;
    string sWord = " "; // define a string variable
    
    //use find () function to get the position of delimiters
    while ((pos = S1.find(delim)) != std::string::npos)
    {
        sWord = S1.substr(0, pos); // store the word
        if (sWord != "")
            SplitToWords.push_back(sWord);
        S1.erase(0, pos + delim.length()); // erase() until position and move to next word 
    }
    if (S1 != "")
        SplitToWords.push_back(S1); // it print last word of the string

    return SplitToWords;
}

void PrintWordInTheVector(vector <string> SplitToWord)
{
    for (string& word : SplitToWord)
        cout << word << endl;
}

int main()
{
    vector <string> SplitToWords;
    SplitString(ReadString(), " ", SplitToWords);
    cout << "Tokens : " << SplitToWords.size() << endl;
    PrintWordInTheVector(SplitToWords);
    system("pause>0");
}