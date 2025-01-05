#include <iostream>
#include<cctype>
using namespace std;



int main()
{
    char X,
    char W;

    X = toupper('a');
    W = tolower('A');
    cout << "converting a to A: " << X << endl;
    cout << "converting A to a: " << W << endl;
    // Digits (A to Z ) returns zero if not, and non zero of yes
    cout << "isupper ('A')" << isupper('A') << endl;
    // lower case (a to z) returns zero if not, and non zero of yes 
    cout << "islower('A') " << islower('A') << endl;
    // Digits (0 to 9) returns zero if not, and non zero of yes
    cout << "isdigit('A') " << isdigit ('A') << endl;
    // punctuation characters are !"#$%&'()*+,-./:;<=>?@[\]^_`{|}~
    // returns zero if not, and non zero of yes  
    cout << "ispunct('A') " << ispunct('A') << endl; 

    return 0;




}


