#include<iostream>
#include <fstream>
#include<string>
#include<vector>
using namespace std;

void ReadMyFiles(string File)
{
	fstream MyFirstFile;
	MyFirstFile.open(File, ios::in);
	if (MyFirstFile.is_open())
	{
		string line;
		while (getline(MyFirstFile, line))
		{
			cout << line << endl;
		}
		MyFirstFile.close();
	}


}

void WriteInsideFile(string File)
{
	fstream MyFirstFile;
	MyFirstFile.open(File, ios::out | ios::app);
	if (MyFirstFile.is_open())
	{
		MyFirstFile << "Hello, I overwrite my file" << endl;
		MyFirstFile << "This is the second line I have created "<< endl;
		MyFirstFile << "This is the third line I have created " << endl;
		MyFirstFile.close();
	}

}

void ChangeFileContent(string File, vector <string>& vLine)
{
	fstream MyFirstFile;
	MyFirstFile.open(File, ios::in);
	if (MyFirstFile.is_open())
	{
		string line;
		while (getline(MyFirstFile, line))
		{
			 vLine.push_back(line) ;
		}
		
		for (string& Line : vLine)
		{
			if (Line == "overwrite")
				Line = "";
		}

		MyFirstFile.close();
	}

}


int main()
{
	vector <string> vLine;
	ReadMyFiles("MyFirstFile.txt");
	WriteInsideFile("MyFirstFile.txt");
	ChangeFileContent("MyFirstFile.txt", vLine);
	ReadMyFiles("MyFirstFile.txt");

	return 0;
}
