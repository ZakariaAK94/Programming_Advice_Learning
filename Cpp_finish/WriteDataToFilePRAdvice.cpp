#include <iostream>
#include<fstream>
#include<vector>
#include<string>
using namespace std;

//void PrintFileContent(string FileName)
//{
//    fstream MyFileContent;
//    MyFileContent.open(FileName, ios::in);
//    if (MyFileContent.is_open())
//    {
//        string Line;
//        while(getline(MyFileContent,Line))
//        {
//            cout << Line << endl;
//            
//        }
//        MyFileContent.close();
//    }
//    
//
//}


void LoadDataFromFileToVector(string FileName, vector <string> & vLine)
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
        
        for(string Line : vLine)
        {
            if (Line != "")
            {
                MyFileContent << Line << endl;
            }

        }
        MyFileContent.close();
    }
}

int main()
{
    fstream MySeconde;
    vector <string> vLine;
    /*MySeconde.open("MySecondeFile.txt", ios::out | ios::app);
    if (MySeconde.is_open())
    {
        MySeconde << "I will be the best programmer :)" <<endl;
        MySeconde << "You have to dedicate more engery and time in learning" << endl;
        MySeconde.close();
    }*/
    /*MySeconde.open("MySecondeFile.txt", ios::out | ios::app);
    if (MySeconde.is_open())
    {
        MySeconde << "My name is Zakaria, I have created this file !!!" << endl;
       
        MySeconde.close();
    }*/

    /*PrintFileContent("MySecondeFile.txt");*/
    /*LoadDataFromFileToVector("MySecondeFile.txt", vLine);
    for (string Line : vLine)
    {
        cout << Line << endl;
    }*/
    vector <string> vFileContent = { "Zakaria", "Otmane", "Reda", "Ahmed" };
    SaveVectorToFile("MySecondeFile.txt", vFileContent);
    
    return 0;
}

