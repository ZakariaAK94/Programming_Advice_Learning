#include<iostream>
#include<string>
using namespace std;

string ReadText()
{
    string Text = "";
    cout << "Please enter a text ? " << endl;
    getline(cin,Text);

    return Text;
}

string EncryptText(string Text, int EncryptionKey)
{
    for (int i = 0; i < Text.length(); i++)
        Text[i] = char(int(Text[i]) + EncryptionKey);
   
    return Text;
}

string DecryptText(string Text, int EncryptionKey)
{
    for (int i = 0; i < Text.length(); i++)
        Text[i] = char(int(Text[i]) - EncryptionKey);

    return Text;
}

int main()
{
    const short EncryptionKey = 4;
    string Text = ReadText();
    string EncryptionText = EncryptText(Text, EncryptionKey);
    string DecryptionText = DecryptText(EncryptionText, EncryptionKey);
    cout << "Text before Encryption :" << Text << endl;
    cout << "Text after Encryption :" << EncryptionText << endl;
    cout << "Text after  Decryption :" << DecryptionText << endl;
    return 0;
}
