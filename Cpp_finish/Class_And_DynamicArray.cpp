#include <iostream>
#include <vector>
using namespace std;

class clsA
{
public:
    int x;
    //dummy constructor
    clsA() 
    {
    };
    //Parametarized Constructor
    clsA(int value)
    {
        x = value;
    }
    void print()
    {
        cout << "The value of x=" << x << endl;
    }
};

int main()
{
    int NbrOfObject;
    cout << "Please enter a number of Object you wanna create : ";
    cin >> NbrOfObject;
    // allocating dynamic array// of Size NumberOfObjects using new keyword     

    clsA* test = new clsA[NbrOfObject];
    // calling constructor// for each index of array
    for (int i = 0; i < NbrOfObject; i++)
    {
        test[i] = clsA(i);
    }
    // printing contents of array
    for (int i = 0; i < NbrOfObject; i++)
    {
        test[i].print();
    }
    delete[] test;
    //Initializing 3 array Objects with function calls of
    // parameterized constructor as elements of that array
    clsA obj[] = { clsA(10),clsA(20),clsA(30) };
    for (int i = 0; i < 3; i++)
        obj[i].print();


    return 0;
    

}


