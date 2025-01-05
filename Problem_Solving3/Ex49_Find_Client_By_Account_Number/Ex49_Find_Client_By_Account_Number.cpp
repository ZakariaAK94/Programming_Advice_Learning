#include <iostream>
#include<fstream>
#include<string>
#include<vector>
#include<iomanip>

using namespace std;
const string ClientsFileName = "Clients2.txt";


struct sClient
{
    string AccountNumber;
    string PinCode;
    string Name;
    string Phone;
    double AccountBalance;
};

string ReadAccountNumber()
{
    string AccountNbr;
    cout << "Please enter AccountNumber ?";
    cin >> AccountNbr;

    return AccountNbr;
}
vector <string> SplitString(string Line, string Delim = "#//#")
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


vector <sClient> LoadCleintsDataFromFile(string Filename)
{

    fstream MyFile;
    vector <sClient> AllClients;
    vector <string> SplitIntoWords;
    sClient Client;

    MyFile.open(Filename, ios::in);

    if (MyFile.is_open())
    {
        string Line;
        while (getline(MyFile, Line))
        {
            SplitIntoWords = SplitString(Line);
            Client = ConvertLineToRecord(SplitIntoWords);
            AllClients.push_back(Client);
        }
        MyFile.close();
    }


    return AllClients;
}

void PrintClientCard(sClient Client)
{
    cout << "The following are the client details :" << endl;
    cout << "Account Number : " << Client.AccountNumber << endl;
    cout << "Pin Code : " << Client.PinCode << endl;
    cout << "Name : " << Client.Name << endl;
    cout << "Phone : " << Client.Phone << endl;
    cout << "Account Balance : " << Client.AccountBalance << endl;
}

/*MY SOLUTION RESULT IN TABLE*/
//void PrintAllClientData(vector <sClient> AllClients, string AccountNbr)
//{
//    bool IsFound = false;
//    for (int i = 0; i < AllClients.size(); i++)
//    {
//        if (AllClients[i].AccountNumber == AccountNbr)
//        {
//            cout << "\n\t\t\t\t\t Client list (" << AllClients.size() << ") Client(s)." << endl;
//            cout << "________________________________________________________________________________________________" << endl;
//            cout << "| " << left << setw(15) << "Account Number"
//                << "| " << left << setw(10) << "Pin code"
//                << "| " << left << setw(40) << "Client name"
//                << "| " << left << setw(12) << "Phone"
//                << "| " << left << setw(12) << "Balance" << endl;
//            cout << "________________________________________________________________________________________________" << endl;
//            PrintClientRecord(AllClients[i]);
//            IsFound = true;
//            break;
//        }
//    }
//    if (!IsFound)
//        cout << "Client with Acount Number (" << AccountNbr << ") Not Found !" << endl;
//
//}

bool FindClientByAccountNumber(string AccountNbr, sClient & Client) 
{
     vector <sClient> vClient = LoadCleintsDataFromFile(ClientsFileName);
    for (sClient &C : vClient)
    {
        if (C.AccountNumber == AccountNbr)
        {
            Client =  C;
            return true;
        }
    }
    return false;

}

int main()
{
    sClient Client;
    string AccountNbr = ReadAccountNumber();
    if (FindClientByAccountNumber(AccountNbr, Client))
    {
        PrintClientCard(Client);
    }
    else
        cout << "\n Client with account Number (" << AccountNbr << ") is nt found !!";
    system("pause>0");
}
