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
    bool MarkForDelete = false;
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

bool FindClientByAccountNumber( string AccountNbr, vector <sClient>& vClient, sClient& Client)
{
    for (sClient& C : vClient)
    {
        if (C.AccountNumber == AccountNbr)
        {
            Client = C;
            C.MarkForDelete = true;
            return true;
        }
    }
    return false;

}


void SaveCleintsDataToFile(string FileName, vector<sClient> vClients) 
{
    fstream MyFile;    
    MyFile.open(FileName, ios::out);//overwrite
    string DataLine; 
    if (MyFile.is_open())    
    {
        for (sClient C : vClients)
        { 
            if (C.MarkForDelete == false) 
            { 
                //we only write records that are not marked for delete.  
                DataLine = ConvertRecordToLine(C); 
                MyFile << DataLine << endl;   
            }    
        }  
        MyFile.close();
    } 
}

bool DeleteClientByAccountNumber(string AccountNumber, vector<sClient>& vClients)
{
    sClient Client;
    char Answer = 'n'; 
    if (FindClientByAccountNumber(AccountNumber, vClients, Client)) 
    {
        PrintClientCard(Client);
        cout << "\n\nAre you sure you want delete this client? y/n ? ";      
        cin >> Answer; 
        if (Answer == 'y' || Answer == 'Y')
        { 
        SaveCleintsDataToFile(ClientsFileName, vClients); //Refresh Clients 
        vClients = LoadClientsDataFromFile(ClientsFileName);             
        cout << "\n\nClient Deleted Successfully."; 
        return true;         
        }    
    }
    else 
    { 
        cout << "\nClient with Account Number (" << AccountNumber<< ") is Not Found!"; 
        return false; 
    }
}


int main()
{
    vector <sClient> vClients = LoadClientsDataFromFile(ClientsFileName); 
    string AccountNumber = ReadAccountNumber();
    DeleteClientByAccountNumber(AccountNumber, vClients);

    system("pause>0");
}

