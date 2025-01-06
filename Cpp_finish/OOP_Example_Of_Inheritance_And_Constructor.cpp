#include <iostream>
using namespace std;

class clsPerson
{
protected:
    int _ID = 10;
    string _FirstName;
    string _LastName;
    string _Email;
    string _Phone;
public:
    clsPerson()
    {

    }
    clsPerson(int ID, string FirstName,string LastName,string Email, string Phone)
    {
        _ID = ID;
        _FirstName = FirstName;
        _LastName = LastName;
        _Email = Email;
        _Phone = Phone;
    }

    int ID()
    {
        return _ID;
    }
    void SetFirstName(string FirstName)
    {
        _FirstName = FirstName;
    }
    string FirstName()
    {
        return _FirstName;
    }
    void SetLastName(string LastName)
    {
        _LastName = LastName;
    }
    string LastName()
    {
        return _LastName;
    }
    string FullName()
    {
        return _FirstName + " " + _LastName;
    }
    void SetEmail(string Email)
    {
        _Email = Email;
    }
    string Email()
    {
        return _Email;
    }
    void SetPhone(string Phone)
    {
        _Phone = Phone;
    }
    string Phone()
    {
        return _Phone;
    }

    void Print()
    {
        cout << " Info : \n";
        cout << "_____________________________________" <<endl;
        cout << "ID          : " << ID() << endl;
        cout << "FirstName   : " << FirstName() << endl;
        cout << "LastName    : " << LastName() << endl;
        cout << "FullName    : " << FullName() << endl;
        cout << "Email       : " << Email() << endl;
        cout << "Phone       : " << Phone() << endl;
        cout << "_____________________________________" << endl;
    }

    void SendEmail(string Subject, string Body)
    {
        cout << "\nThe following message sent successfully to email: " << Email() << endl;
        cout << "Subject :" << Subject << endl;
        cout << "Body :" << Body << endl;
    }

    void SendSMS(string Message)
    {
        cout << "The following SMS sent successfully to phone : " << Phone() << endl;
        cout << Message;
    }
};


class clsEmployee : public clsPerson
{
private:
    float _Salary;
    string _Title;
public:
    clsEmployee(int ID, string FirstName, string LastName, string Email, string Phone, string Title, float Salary):clsPerson(ID, FirstName, LastName, Email, Phone)
    {
        _Title = Title;
        _Salary = Salary;
    }
     
    void SetTitle(string Title)
    {
        _Title = Title;
    }
    string Title()
    {
        return _Title;
    }
    void SetSalary(float Salary)
    {
        _Salary = Salary;
    }
    float Salary()
    {
        return _Salary;
    }


    void Print()
    {
        cout << " Info : \n";
        cout << "_____________________________________" << endl;
        cout << "ID          : " << ID() << endl;
        cout << "FirstName   : " << _FirstName << endl;
        cout << "LastName    : " << LastName() << endl;
        cout << "FullName    : " << FullName() << endl;
        cout << "Email       : " << Email() << endl;
        cout << "Phone       : " << Phone() << endl;
        cout << "Salary       : " << _Salary<< endl;
        cout << "Title       : " << _Title<< endl;
        cout << "_____________________________________" << endl;
    }
};

class clsDeveloper : public clsEmployee
{
    string _MainLanguageProgramming;
public:
    clsDeveloper(int ID, string FirstName, string LastName, string Email, string Phone, string Title, float Salary, string LanguagePr) :clsEmployee(ID, FirstName, LastName, Email, Phone, Title, Salary)
    {
        _MainLanguageProgramming = LanguagePr;
    }

    void SetMainLanguageProgramming(string LanguagePR)
    {
        _MainLanguageProgramming = LanguagePR;
    }

    string MainLanguagePR()
    {
        return _MainLanguageProgramming;
    }

    void Print()
    {
        cout << " Info : \n";
        cout << "_____________________________________" << endl;
        cout << "ID             : " << ID() << endl;
        cout << "FirstName      : " << FirstName() << endl;
        cout << "LastName       : " << LastName() << endl;
        cout << "FullName       : " << FullName() << endl;
        cout << "Email          : " << Email() << endl;
        cout << "Phone          : " << Phone() << endl;
        cout << "Salary         : " << Salary() << endl;
        cout << "Title          : " << Title() << endl;
        cout << "Language PR    : " << MainLanguagePR() << endl;
        cout << "_____________________________________" << endl;
    }
    
};

int main()
{
    clsDeveloper Developer1 (10,"Zakaria","AKIL","a@agmail.com","0628495742", "Developer",1000,"C++");
    Developer1.Print();
    Developer1.SetFirstName("Otmane");
    Developer1.Print();
    
    system("pause>0");
    return 0;
}


