#include <iostream>
#include<string>
using namespace std;

string ReadString()
{
    string S1 = " ";
    cout << "Please enter your string ?" << endl;
    getline(cin, S1);
    return S1;
}

void PrintEachWordInString(string S1)
{
    string delim = " "; //delimiter
    short pos = 0;
    string sWord = " "; // define a string variable

    //use find () function to get the position of delimiters
    while ((pos = S1.find(delim)) != std::string::npos)
    {
        sWord = S1.substr(0, pos); // store the word
        if (sWord != "")
            cout << sWord << endl;
        S1.erase(0, pos + delim.length()); // erase() until position and move to next word 
    }
    if (S1 != "")
        cout << S1 << endl; // it print last word of the string
}

int main()
{
    PrintEachWordInString(ReadString());
    system("pause>0");
}


