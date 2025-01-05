#include <iostream>
#include <string>
#include <cctype>
using namespace std;

// enum UpperOrLowerLetter{Upper:1,Lower:2}; //

string ReadString()
{
    string Sentence = " ";
    cout << "Please enter your string?";
    getline(cin, Sentence);

    return Sentence;
}

string UpperFirstEachWord(string Ste)
{
    bool IsFirstLetter = true;

    for (int i = 0; i <= Ste.length(); i++)
    {
        if (Ste[i] != ' ' && IsFirstLetter)
        {
            Ste[i] = toupper(Ste[i]);
        }
        IsFirstLetter = (Ste[i] == ' ' ? true : false);
    }
    return Ste;
}

string LowerFirstEachWord(string Ste)
{
    bool IsFirstLetter = true;

    for (int i = 0; i <= Ste.length(); i++)
    {
        if (Ste[i] != ' ' && IsFirstLetter)
        {
            Ste[i] = tolower(Ste[i]);
        }
        IsFirstLetter = (Ste[i] == ' ' ? true : false);
    }
    return Ste;
}

int main()
{
    string Sentence = " ";
    Sentence = ReadString();
    cout << "Sentence before changed :\n";
    cout << Sentence << endl;
    cout << "Sentence after changed :\n";
    Sentence = UpperFirstEachWord(Sentence);
    cout << Sentence << endl;
    cout << "Sentence after changed :\n";
    Sentence = LowerFirstEachWord(Sentence);
    cout << Sentence << endl;
    return 0;
}