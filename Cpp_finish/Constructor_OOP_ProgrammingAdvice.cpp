#include <iostream>
using namespace std;

class clsPlayer
{
private:
    string _FullName;
    int _PlayerNumber;
    float _Salary;
public:
    clsPlayer(string FullName, int PlayerNumber, float Salary)
    {
        _FullName = FullName;
        _PlayerNumber = PlayerNumber;
        _Salary = Salary;
    }
    // Copy Constructor   
    clsPlayer(clsPlayer& old_obj)
    {
        _FullName = old_obj.FullName();
        _PlayerNumber = old_obj.PlayerNumber();
        _Salary = old_obj.Salary();
        
    }

    void SetFullName(string FullName)
    {
        _FullName = FullName;
    }
    string FullName()
    {
        return _FullName;
    }
    void SetPlayerNumber(int PlayerNumber)
    {
        _PlayerNumber = PlayerNumber;
    }
    int PlayerNumber()
    {
        return _PlayerNumber;
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
        cout << "The player " << _FullName << " Will have the number " << _PlayerNumber << " with a salary of " << _Salary;

    }
};

int main()
{
    clsPlayer Player1("Zakaria Akil",8,1625.29);
    Player1.Print();
    clsPlayer Player2 = Player1;
    cout << "\n";
    Player2.Print();
    system("pause>0");
    return 0;
}

