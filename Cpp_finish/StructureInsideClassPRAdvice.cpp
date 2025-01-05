#include <iostream>
using namespace std;

class clsStudent
{
    struct stInfoStudents
    {
        string FirstName;
        string LastName;
        float Average;
    };
public:
    stInfoStudents Student1;
    clsStudent()
    {
        Student1.FirstName = "Zakaria";
        Student1.LastName = "AKIL";
        Student1.Average = 15.67;
    }
    void Print()
    {
        cout << "Information for Student 1 is below :" << endl;
        cout << "FirstName : " << Student1.FirstName << endl;
        cout << "LastName : " << Student1.LastName << endl;
        cout << "Average : " << Student1.Average << endl;
    }
};

int main()
{
    clsStudent Student1;
    Student1.Print();    
    system("pause>0");
}


