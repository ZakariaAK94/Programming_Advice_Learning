#include <iostream>
using namespace std;

int ReadNumber(string Message)
{
    int Password = 0;
    do {
        cout << Message << endl;
        cin >> Password;
    } while (Password < 0);

    return Password;
}

bool CheckPassword(int Password)
{
    if (Password == 1234)
        return true;
    else
        return false;
}

void PrintResult(bool Result)
{
    int i = 1;
    while (i <3)
    {
        if (Result)
        {
            cout << "Your Balance is : 7500 " << endl;
            system("color 2F");
            break;
        }
        else
        {
            cout << " Wrong PIN" << endl;
            system("color DF");
            Result = CheckPassword(ReadNumber("Please enter a new password"));
            i++;
        }
            
    }
    cout << "Your card is blocked !!" << endl;
   
}



int main()
{
    
    PrintResult(CheckPassword(ReadNumber("Please enter the Password :")));
    
    return 0;
        
}
