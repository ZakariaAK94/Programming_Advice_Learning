#include <iostream>
#include<stack>
using namespace std;



int main()
{
    stack <int> stacTest1;
    stack <int> stacTest2;

    stacTest1.push(10);
    stacTest1.push(20);
    stacTest1.push(30);
    stacTest1.push(40);

    stacTest2.push(150);
    stacTest2.push(250);
    stacTest2.push(350);
    stacTest2.push(450);

    stacTest1.swap(stacTest2);



    cout << "Elements of StacTest1 after swaping : \n";
    while (!stacTest1.empty())
    {
        cout << stacTest1.top() <<endl;
        stacTest1.pop();
    }

    cout << "\nElements of StacTest2 after swaping : \n";
    while (!stacTest2.empty())
    {      
        cout << stacTest2.top() << endl;
        stacTest2.pop();
    }

}


