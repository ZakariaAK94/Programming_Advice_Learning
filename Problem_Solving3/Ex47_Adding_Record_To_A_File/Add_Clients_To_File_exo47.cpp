#include <iostream>
#include<fstream>
#include<string>
#include<vector>

using namespace std;
const string ClientsFileName = "Clients.txt";

struct sClient
{
    string AccountNumber ;
    string PinCode ;
    string Name ;
    string Phone;
    double AccountBalance ;
};

sClient ReadNewClient()
{
    sClient Client;
    cout << "Enter Account Number ?";
    // Usage of std::ws will extract all the whitespace character
    getline(cin >> ws, Client.AccountNumber);
    cout << "Enter PinCode?";
    getline(cin, Client.PinCode);
    cout << "Enter Name ? ";
    getline(cin, Client.Name);
    cout << "Enter Phone ?";
    getline(cin, Client.Phone);
    cout << "Enter AccountBalance ?";
    cin >> Client.AccountBalance;

    return Client;
}

string ConvertRecodrToLine(sClient Client, string Seperator = "#//#")
{
    string stClientRecord = "";
    stClientRecord += Client.AccountNumber + Seperator;
    stClientRecord += Client.PinCode + Seperator;
    stClientRecord += Client.Name + Seperator;
    stClientRecord += Client.Phone + Seperator;
    stClientRecord += to_string(Client.AccountBalance);
    return stClientRecord;
}

void AddDataLineToFile(string Filename, string stDataLine)
{
    fstream MyFile;

    MyFile.open(Filename, ios::out | ios::app);

    if (MyFile.is_open())
    {
        MyFile << stDataLine << endl;
    }
    MyFile.close();
    
}

void AddNewClient()
{
    sClient Client;
    Client = ReadNewClient();
    AddDataLineToFile(ClientsFileName, ConvertRecodrToLine(Client));
}

void AddClient()
{
    char AddMore ='Y';

    do {
        system("CLS");
        cout << " Adding new client :\n\n";
        AddNewClient();
        cout << "Client added successfully.Do you want to add more clients ? Y/y" << endl;
        cin >> AddMore;


    } while (toupper(AddMore) == 'Y');
}

int main()
{
    AddClient();
    system("pause>0");
}

