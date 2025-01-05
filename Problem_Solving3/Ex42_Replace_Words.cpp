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

string ReplaceWordInStringUsingBuiltInFunction(string S1, string StringToReplace, string sReplaceTo)
{
	short pos = 0;
	while ((pos = S1.find(StringToReplace)) != std::string::npos)
	{
		S1.replace(pos,StringToReplace.length(),sReplaceTo);
	}
	
	return S1;
}



int main()
{
	string S = ReadString();
    string S1=S;
	string StringToReplace, sReplaceTo;
	cout << "Which word would you like to change ?" << endl;
	cin >> StringToReplace;
	cout << "Which word would you like to change to ?" << endl;
	cin >> sReplaceTo;
	cout << "\n String after replace:" << endl;
	cout << ReplaceWordInStringUsingBuiltInFunction(S, StringToReplace, sReplaceTo) << endl;
	system("pause > 0");
}
