#include<iostream>
#include<vector>
#include<string>
#include<CCtype>
using namespace std;

string ReadString()
{
    string S;
    cout << "Origin string ?" << endl;
    getline(cin, S);
    return S;
}

string RemovedPunctiationFromWord(string& word)
{
    string NWord="";
    for (char& C : word)
    {
        if ((int(C) >= 65 && int(C) <= 90) || (int(C) >= 97 && int(C) <= 122) || int(C) == 32)
            /*if (!ispunct(C))
                S += S1[i];*/ 
           NWord+=C;
        
    }
    
    return NWord;
}

/* Function predefine in C++
    * string RemovePunctiation
    string S2 = "";
    for (short i = 0; i < S1.length(); i++)
    {
        if (!ispunct(S1[i]))
        {
            S2 += S1[i];
        }

    }*/

int main()
{
    string S1 = "We''lcome to Jor-dan,.;:. Jordan is a nice cou-*ntry; it's amazing...";
    
    cout << "Original String :\n" << S1;
    cout << "\n\nPunctiation removed: ";
    cout << "\n" << RemovedPunctiationFromWord(S1);
    
    system("pause > 0");
}
