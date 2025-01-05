#include <iostream>
using namespace std;

class clsPerson
{
public:
    virtual void Print()
    {
       cout << "\nHi ! I'm a Person ";
    }
};

class clsEmployee : public clsPerson
{
public:
    void Print()
    {
        cout << "\nHi ! I'm a Employee ";
    }
};

class clsStudent : public clsPerson
{
public:
    void Print()
    {
        cout << "\n Hi ! I'm a Student ";
    }
};

int main()
{
    clsEmployee  Employee;
    clsStudent  Student;
    
    Employee.Print();
    Student.Print();

    clsPerson* Person1 = &Employee;
    clsPerson* Person2= &Student;

    Person1->Print();
    Person2->Print();

    system("pause>0");


    return 0;
}
