#include <iostream>
using namespace std;

class clsStudent
{
private:
    string _FullName;
    float _Average;
public:
    clsStudent()
    {
        cout << "Hey, I am the constructor, this is the initialize values :" << endl;
        _FullName = "ZAKARIA AKIL";
        _Average = 18.5;
        cout << _FullName << endl;
        cout << _Average << endl;
    }
    ~clsStudent()
    {
        cout << "Hi, you call destructor for this class" << endl;
    }
};

void Funct1()
{
    clsStudent Student1;
}

void Funct2()
{
    clsStudent* Student2 = new clsStudent;
    delete Student2;
}
int main()
{
    Funct1();
    Funct2();
    

    system("pause>0");
}