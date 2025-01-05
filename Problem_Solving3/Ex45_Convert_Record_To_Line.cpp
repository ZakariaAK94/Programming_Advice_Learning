#include <iostream>
#include<string>

using namespace std;

struct sClient 
{
    string AccountNumber = "";
    string PinCode = 0;
    string Name = "";
    string Phone = "";
    double AccountBalance = 0;
};

sClient ReadClientData()
{
    sClient Client;
    cout << "Enter Account Number ?";
    getline(cin,Client.AccountNumber); 
    cout << "Enter PinCode?";
    getline(cin,Client.PinCode);
    cout << "Enter Name ? ";
    getline(cin,Client.Name);
    cout << "Enter Phone ?";
    getline(cin, Client.Phone);
    cout << "Enter AccountBalance ?";
    cin >> Client.AccountBalance;

    return Client;
}

string ConvertRecodrToLine(sClient Client, string Seperator ="#//#")
{
    string stClientRecord = "";
    stClientRecord += Client.AccountNumber + Seperator;
    stClientRecord += Client.PinCode + Seperator;
    stClientRecord += Client.Name + Seperator;
    stClientRecord += Client.Phone + Seperator;
    stClientRecord +=to_string(Client.AccountBalance);
    return stClientRecord;
}


int main()
{
    cout << "Please enter client Data :\n\n";
    sClient Client;
    Client = ReadClientData();
    cout << "\nClient Recodr for saving is : \n"<<ConvertRecodrToLine(Client);

    return 0;
}


