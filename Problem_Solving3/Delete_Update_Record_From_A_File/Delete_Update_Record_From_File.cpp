#include <iostream>
#include<fstream>
#include<vector>
#include<string>
using namespace std;

void LoadDataFromFileToVector(string FileName, vector <string>& vLine)
{
    fstream MyFileContent;
    MyFileContent.open(FileName, ios::in);
    if (MyFileContent.is_open())
    {
        string Line;
        while (getline(MyFileContent, Line))
        {
            vLine.push_back(Line);

        }
        MyFileContent.close();
    }


}

void SaveVectorToFile(string FileName, vector <string> vLine)
{
    fstream MyFileContent;
    MyFileContent.open(FileName, ios::out);
    if (MyFileContent.is_open())
    {

        for (string Line : vLine)
        {
            if (Line != "")
            {
                MyFileContent << Line << endl;
            }

        }
        MyFileContent.close();
    }
}

void DeleteRecordFromFile(string FileName, string Record)
{
    vector <string> vLine;
    LoadDataFromFileToVector(FileName, vLine);
    for (string &Line : vLine)
    {
        if (Line == Record)
            Line = "";
    }
    SaveVectorToFile(FileName, vLine);
}

void UpdatedRecordInTheFile(string FileName, string Record, string Updated)
{
    vector <string> vLine;
    LoadDataFromFileToVector(FileName, vLine);
    for (string& Line : vLine)
    {
        if (Line == Record)
            Line = Updated;
    }
    SaveVectorToFile(FileName, vLine);
}


void PrintFileContent(string FileName)
{
    fstream MySeconde;
    MySeconde.open(FileName, ios::in);
    if (MySeconde.is_open())
    {
        string Line;
        while (getline(MySeconde, Line))
        {
            cout << Line << endl;
        }
        MySeconde.close();
    }
}

int main()
{
    cout << "The content of the file before Delete anything :" << endl;
    PrintFileContent("MySecondeFile.txt");
    DeleteRecordFromFile("MySecondeFile.txt", "Otmane");
    cout << "The content of the file after Delete anything :" << endl;
    PrintFileContent("MySecondeFile.txt");
    UpdatedRecordInTheFile("MySecondeFile.txt", "Ahmed","Karim");
    cout << "The content of the file after updating :" << endl;
    PrintFileContent("MySecondeFile.txt");

    return 0;
}

