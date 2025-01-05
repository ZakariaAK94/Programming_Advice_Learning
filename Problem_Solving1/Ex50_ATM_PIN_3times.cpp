#include <iostream>
#include <string>
using namespace std;

void PasswordTest(string Password)
{
       cout << "Please enter the Password consist of 6 digits :" << endl;
       cin >> Password;
       while (Password.length() != 6)
       {
           cout << "Wrong,please respect the length of the password 6 digits !!" << endl;
           cin >> Password;
       }
       int i = 1;
       while (i <= 3)
       {
           if (Password == "123456")
           {
               cout << " Your Balance is : 7500" << endl;
               break;
           }
           else
           {
               cout << "Your Password is wrong, you still have " << 3 - i << " chance !!\n";
               cout << "Please try again, enter the Password consist of 6 digits :" << endl;
               cin >> Password;
               while (Password.length() != 6)
               {
                   cout << "Wrong,please respect the length of the password 6 digits !!" << endl;
                   cin >> Password;
               }
               i++;
           }
       }
}


int main()
{
    string Password;
    PasswordTest(Password);
    
    return 0;
}

