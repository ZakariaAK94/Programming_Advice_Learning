#include <iostream>
using namespace std;


int main()
{
    int sum;
    cout << "Please enter number of students ?" << endl;
    cin >> sum;

    float* ptr;
    //memory allocation of num  number of floats

    ptr = new float[sum];
    
    cout << "Enter grades of students." << endl;

    for (int i = 0; i < sum; i++)
    {
        cout << "Student " << i + 1 << endl;
        cin >> *(ptr + i);
    }
    cout << "Displaying grades of students :";
    for (int i = 0; i < sum; i++)
    {
        cout << "\nStudent " << i + 1 << " : " << * (ptr + i); 
    }
    //ptr memory is released
    delete[] ptr;

    system("pause>0");
}


