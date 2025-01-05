#include <iostream>
#include "clsUniversity.h"

using namespace std;

int main()
{
    clsUniversity University("Zakaria","AKIL",16,18,13.65,"S2");
    cout << "Result of " << University.GetModul() << endl;
    cout << "your grade in Math is: " << University.Student.GetMath() << endl;
    cout << "your grade in Physic is: " << University.Student.GetPhysic() << endl;
    cout << "your grade in French is: " << University.Student.GetFrench() << endl;
    University.Student.printResult();
    system("pause>0");
}