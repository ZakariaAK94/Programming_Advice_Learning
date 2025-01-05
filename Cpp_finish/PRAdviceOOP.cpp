#include <iostream>

using namespace std;

class clsPerson
{
    //this private and will not be accessed from outside the class//for internal use only
    int x;
    public:
        string FirstName;
        string LastName;

        string PrintFullName()
        {
            return FirstName + " " + LastName;
        }
};


int main()
{
    clsPerson Person1;
    clsPerson Person2;

    Person1.FirstName = "ZAKARIA";
    Person1.LastName = "AKIL";
    cout << "I'am : " << Person1.PrintFullName() << " I will be the best programmer in the world.";
    Person2.FirstName = "ZAKARIA2";
    Person2.LastName = "AKIL2";
    cout << "I'am : " << Person1.PrintFullName() << " I will be the best programmer in the world.";
    cout << &Person1.FirstName << endl;
    cout << &Person2.FirstName << endl;
    cout << &Person1.LastName << endl;
    cout << &Person2.LastName << endl;

    system("pause>0");
}

