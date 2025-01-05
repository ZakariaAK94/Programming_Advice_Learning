#include <iostream>
#include<queue>
using namespace std;

int main()
{

    queue <int> QueTest1;
    queue <int> QueTest2;

    QueTest1.push(10);
    QueTest1.push(20);
    QueTest1.push(30);
    QueTest1.push(40);

    cout << "Count : " << QueTest1.size() << endl;
    cout << "First Element : " << QueTest1.front() << endl;
    cout << "Last Element : " << QueTest1.back() << endl;

    /*cout << " the Elements of QueTest1 = ";
    while (!QueTest1.empty())
    {
        cout << QueTest1.front() << " ";
        QueTest1.pop();
    }*/
    QueTest2.push(170);
    QueTest2.push(270);
    QueTest2.push(370);
    QueTest2.push(470);

    QueTest1.swap(QueTest2);

    cout << "\nthe Elements of QueTest1 after swaping = ";
    while (!QueTest1.empty())
    {
        cout << QueTest1.front() << " ";
        QueTest1.pop();
    }

    cout << "\nthe Elements of QueTest2 after swaping = ";
    while (!QueTest2.empty())
    {
        cout << QueTest2.front() << " ";
        QueTest2.pop();
    }

    system("pause > 0");

    return 0;

}

