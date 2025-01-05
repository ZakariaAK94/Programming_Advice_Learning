#include <iostream>
using namespace std;

class clsPerson
{
public:
    string FullName = "Mohammed Abu-Hadhoud ";
};

class clsEmployee : public clsPerson
{
public:
    string Title = "CEO";
};

int main()
{
    clsEmployee  Employee;
    cout << Employee.FullName << endl;
    clsPerson* Person1;
    // upcasting 
    Person1 = &Employee;
    cout << Person1->FullName << endl;
    
    //DownCasting
    /*clsPerson Person2;
    clsEmployee* Employee1;
    Employee1 = &Person2;*/
    
    system("pause>0");
    return 0;
}