#include <iostream>
#include<fstream>
#include<string>
#include<vector>
#include<iomanip>

using namespace std;
const string ClientsFileName = "Clients.txt";

struct sClient
{
    string AccountNumber;
    string PinCode;
    string Name;
    string Phone;
    double AccountBalance;
    bool MarkForChange = false;
};

// function to use
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

string ConvertRecordToLine(sClient Client, string Seperator = "#//#")
{
    string stClientRecord = "";
    stClientRecord += Client.AccountNumber + Seperator;
    stClientRecord += Client.PinCode + Seperator;
    stClientRecord += Client.Name + Seperator;
    stClientRecord += Client.Phone + Seperator;
    stClientRecord += to_string(Client.AccountBalance);
    return stClientRecord;
}

vector <sClient> LoadClientsDataFromFile(string Filename)
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

sClient ReadClientData(string AccountNumber)
{
    sClient Client;
    Client.AccountNumber = AccountNumber;
    cout << "Enter PinCode? ";
    getline(cin>>ws,Client.PinCode);
    cout << "Enter Name?";
    getline(cin,Client.Name);
    cout << "Enter phone ?";
    getline(cin,Client.Phone);
    cout << "Enter Account Balance ?";
    cin >>Client.AccountBalance;

    return Client;
}

bool FindClientByAccountNumber(string AccountNbr, vector <sClient>& vClient, sClient& Client)
{
    for (sClient& C : vClient)
    {
        if (C.AccountNumber == AccountNbr)
        {
            Client = C;
            C.MarkForChange = true;
            return true;
        }
    }
    return false;

}


void SaveClientsDataToFile(string FileName, vector<sClient> vClients, string AccountNumber)
{
    fstream MyFile;
    MyFile.open(FileName, ios::out);//overwrite
    string DataLine;
    if (MyFile.is_open())
    {
        for (sClient C : vClients)
        {
            if (C.MarkForChange == true)
            {
                //we only write records that are not marked for delete.  
                C = ReadClientData(AccountNumber);
                DataLine = ConvertRecordToLine(C);
                MyFile << DataLine << endl;
            }
            else
            {
                DataLine = ConvertRecordToLine(C);
                MyFile << DataLine << endl;
            }
        }
        MyFile.close();
    }
    
}

bool UpdatedClientByAccountNumber(string AccountNumber, vector<sClient>& vClients)
{
    sClient Client;
    char Answer = 'n';
    if (FindClientByAccountNumber(AccountNumber, vClients, Client))
    {
        PrintClientCard(Client);
        cout << "\n\nAre you sure you want to updated information of this client? y/n ? ";
        cin >> Answer;
        if (tolower(Answer) == 'y')
        {
            SaveClientsDataToFile(ClientsFileName, vClients, AccountNumber); //Refresh Clients 
            cout << "\n\nClient Updated Successfully.";
            return true;
        }
    }
    else
    {
        cout << "\nClient with Account Number (" << AccountNumber << ") is Not Found!";
        return false;
    }
}


int main()
{
    vector <sClient> vClients = LoadClientsDataFromFile(ClientsFileName);
    string AccountNumber = ReadAccountNumber();
    UpdatedClientByAccountNumber(AccountNumber, vClients);

    system("pause>0");
}

