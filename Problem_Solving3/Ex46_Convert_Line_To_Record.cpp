#include <iostream>
#include<string>
#include<vector>
#include<iomanip>

using namespace std;

struct sClient
{
    string AccountNumber;
    string PinCode ;
    string Name ;
    string Phone ;
    double AccountBalance = 0;
};



vector <string> SplitString(string Line, string Delim ="#//#")
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

sClient ConvertLineToRecord(vector<string> vClient)
{
    sClient Client;
   
    Client.AccountNumber = vClient[0];
    Client.PinCode = vClient[1];
    Client.Name = vClient[2];
    Client.Phone = vClient[3];
    Client.AccountBalance = stod(vClient[4]);
    
    return Client;
}

void PrintClientRecord(sClient Client)
{

    cout << setw(20) << "Account Number:" << Client.AccountNumber << endl;
    cout << setw(20) << "PinCode:" << Client.PinCode << endl;
    cout << setw(20) << "Name:" << Client.Name << endl;
    cout << setw(20) << "Phone:" << Client.Phone << endl;
    cout << setw(20) << "AccountBalance:" << Client.AccountBalance << endl;

}

int main()
{
    string stLine = "A150#//#1234#//#ZAKARIA AKIL#//#0624495742#//#5270.0000";
    cout << "Line record is :\n" << stLine << endl;
    cout << "The following is the extracted client record : \n";
    PrintClientRecord(ConvertLineToRecord(SplitString(stLine)));
    system("pause>0");
}
