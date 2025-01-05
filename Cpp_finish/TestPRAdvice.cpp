#pragma warning (disable:4996)


#include <iostream>
#include <ctime>
using namespace std;

int main()
{
    time_t t2 = time(0);

    struct tm* currentlocaldate = localtime(&t2);
    struct tm* currentUTCdate = gmtime(&t2);

    string datenow1 = asctime(currentlocaldate); 
    string datenow2 = asctime(currentUTCdate);
    cout << "local current date is : " << datenow1 << endl;
    cout << "UTC current date is : " << datenow2 << endl;

    time_t t1 = time(NULL);
    char* ptr = ctime(&t1);
    cout << "Local date with function ctime is : " << ptr << endl;

    return 0;
}


