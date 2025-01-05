#include <iostream>
using namespace std;

class clsPerson
{
private:

    short _ID;
    string _FirstName;
    string _LastName;
    string _FullName;
    string _Email;
    string _Phone;

public:
    clsPerson(short ID, string FirstName, string LastName, string Email, string Phone)
    {
        _ID = ID;
        _FirstName = FirstName;
        _LastName = LastName;
        _Email = Email;
        _Phone = Phone;
    }

    short ID()
    {
        return _ID;
    }
    // property Set
    void SetFirstName(string FirstName)
    {
        _FirstName = FirstName;
    }
    // property Get
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

    string FullName()
    {
        return _FirstName + " " + _LastName;
    }

    void Print()
    {
        cout << "\n\nInfo : \n";
        cout << "__________________________" << endl;
        cout << "ID           : " << _ID << endl;
        cout << "First Name   : " << _FirstName << endl;
        cout << "Last Name    : " << _LastName << endl;
        cout << "Full Name    : " << FullName() << endl;
        cout << "Email        : " << _Email << endl;
        cout << "Phone        : " << _Phone << endl;
        cout << "__________________________" << endl;
    }

    void SendEmail(string Subject, string Body)
    {
        cout << "\nThe following message sent successfully to email :" << _Email;
        cout << "\nSubject :" << Subject << endl;
        cout << "Body :" << Body << endl;
    }

    void SendSMS(string TextMessage)
    {
        cout << "\nThe following SMS sent successfully to phone :" << _Phone;
        cout << "\n" << TextMessage << endl;
    }
};

class clsEmployee : public clsPerson
{
private: 
    string _Title;
    string _Departement;
    float _Salary;
public:

    clsEmployee(int ID, string FirstName, string LastName, string Title, string Email, string Phone, string Departement, float Salary)
        :clsPerson(ID, FirstName, LastName, Email, Phone)
    {
        
        _Title = Title;    
        _Departement = Departement;
        _Salary = Salary;
    }

    //property Set
    void SetDepartement(string Departement)
    {
        _Departement = Departement;
    }
    //property Get
    string Departement()
    {
        return _Departement;
    }
    //property Set
    void SetTitle(string Title)
    {
        _Title = Title;
    }
    //property Get
    string Title(string Title)
    {
        return _Title;
    }
    void SetSalary(float Salary)
    {
        _Salary = Salary;
    }
    //property Get
    float Salary()
    {
        return _Salary;
    }
    

    void Print()
    {
        cout << "\n\nInfo : \n";
        cout << "__________________________" << endl;
        cout << "ID           : " << ID() << endl;
        cout << "First Name   : " << FirstName() << endl;
        cout << "Last Name    : " << LastName() << endl;
        cout << "Full Name    : " << FullName() << endl;
        cout << "Email        : " << Email() << endl;
        cout << "Phone        : " << Phone() << endl;
        cout << "Departement  : " << _Departement << endl;
        cout << "Salary       : " << _Salary << endl;
        cout << "__________________________" << endl;
    }

    void SendEmail(string Subjet, string Remerciement)
    {
        cout << "\nSubject :" << Subjet << endl;
        cout << "to Mr /Mme " << FullName() << " We are so happy to announce that your salary " << _Salary << " will be increase by 5% starting from today, and you will be working on new departement " << _Departement << "." << endl;
        cout << Remerciement << endl;
    }

    void SendSMS(string TextMessage)
    {
        cout << "\nthe message sent succesfully to the person concern under " <<endl;
        cout << "ID: " << ID() << endl;
        cout << "Email: " << Email() << endl;
        cout << "Phone: " << Phone() << endl;
        cout << TextMessage << endl;
    }

};

class clsDevelopper : public clsEmployee
{
private:
    string _MainProgrammingLanguage;
public:
    clsDevelopper(int ID, string FirstName, string LastName, string Title, string Email, string Phone, string Departement, float Salary, string MainProgrammingLanguage)
        :clsEmployee(ID, FirstName, LastName, Title, Email, Phone, Departement, Salary)
    {
        _MainProgrammingLanguage = MainProgrammingLanguage;
    }
    void SetMainProgrammingLanguage(string MainProgrammingLanguage)
    {
        _MainProgrammingLanguage = MainProgrammingLanguage;
    }
    string mainprogrammerlanguage()
    {
        return _MainProgrammingLanguage;
    }
    void Print()
    {
        cout << "\n\nInfo : \n";
        cout << "__________________________" << endl;
        cout << "ID          : " << ID() << endl;
        cout << "First Name  : " << FirstName() << endl;
        cout << "Last Name   : " << LastName() << endl;
        cout << "Full Name   : " << FullName() << endl;
        cout << "Email       : " << Email() << endl;
        cout << "Phone       : " << Phone() << endl;
        cout << "Departement : " << Departement() << endl;
        cout << "Salary      : " << Salary() << endl;
        cout << "PLanguage   : " << mainprogrammerlanguage() << endl;
        cout << "__________________________" << endl;
    }

};


int main()
{
    clsDevelopper Developper(123, "ZAKARIA", "AKIL", "PROJECT ENGINEER", "AKILZAKARIA02@GMAIL.COM", "628495742", "EXPORT",2500,"C++");
    Developper.Print();

    Developper.SendEmail("PROMOTION", "Thank you for being an evaluated person in our company.");
    Developper.SendSMS("Please confirm reception of our email of today.");
    Developper.mainprogrammerlanguage();
    system("pause>0");
}


