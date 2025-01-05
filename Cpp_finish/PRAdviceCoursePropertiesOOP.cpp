#include <iostream>
using namespace std;

class clsPerson
{
private:
    string _FirstName;
    string _LastName;
public:
    //only setfirstname that allowed to change the value of _FirstName
    void setFirstName(string FirstName)
    {
        _FirstName = FirstName;
    }
    // only this function will allow you to access to the content of FirstName
    string GetFirstName()
    {
        return _FirstName;
    }

    void setLastName(string LastName)
    {
        _LastName = LastName;
    }

    string GetLastName()
    {
        return _LastName;
    }

    string GetFullName()
    {
        return _FirstName + " " + _LastName;
    }
};

class clsStudent
{
private:
    int _ID = 20;
    int _X;
    int _Y;
    int _Z;

public:

    void SetValues(int x, int y, int z)
    {
        _X = x;
        _Y = y;
        _Z = z;
    }

    int GetID()
    {
        return _ID;
    }
    int GetSumOfValues()
    {
        return (_X + _Y + _Z);
    }

    float GetAverage(float sum)
    {
        return (sum / 3);
    }

};


int main()
{
    clsPerson Person1;

    Person1.setFirstName("ZAKARIA");
    Person1.setLastName("AKIL");
    cout << "Your first name is : " << Person1.GetFirstName() << endl;
    cout << "Your last name is : " << Person1.GetLastName() << endl;
    cout << "Your Full Name is : " << Person1.GetFullName() << endl;
   
    
    clsStudent Student1;

    Student1.SetValues(12, 16, 9);

    cout << "Your ID is :" << Student1.GetID() << endl;

    cout << "Your averge is : " << Student1.GetAverage(Student1.GetSumOfValues()) << endl; 

    system("pause >0 ");

}

