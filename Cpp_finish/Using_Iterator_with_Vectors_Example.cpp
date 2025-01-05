#include <iostream>
#include <vector>
using namespace std;

int main()
{
    vector <string> vEmploye { "Zakarie", "Otmane", "Amal", "Reda", "Yassine"};
    
    //declare iterator
    vector <string>::iterator iter;
    
    // use iterator with for loop
    
    for (iter = vEmploye.begin(); iter!= vEmploye.end(); iter++)
    {
        cout << *iter << " ";
    }



    return 0;
}

