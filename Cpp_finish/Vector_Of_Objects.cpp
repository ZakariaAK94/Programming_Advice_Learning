#include <iostream>
#include<vector>
using namespace std;

class clsA
{
public:
    int x;
    clsA(int value)
    {
        x = value;
    }

    void print()
    {
        cout << "The value of x = " << x << endl;
    }
};

int main()
{
    vector <clsA> v1;
    
    short NbreOfClsA = 5;
    // inserting object at the end of vector
    for (int i = 0; i < NbreOfClsA; i++)
    {
        v1.push_back(clsA(i));
    }
    // printing object content
    for (int i = 0; i < NbreOfClsA; i++)
    {
        v1[i].print();
    }

    system("pause>0");
}