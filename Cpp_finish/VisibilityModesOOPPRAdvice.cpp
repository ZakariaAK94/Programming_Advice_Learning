#include <iostream>
using namespace std;

class clsA
{
private:
    int _V1=1;
    int Funct1()
    {
        return _V1;
    }
protected:
    int V2=2;
    int Funct2()
    {
        return V2;
    }
public:
    int V3 =3;
    int Funct3()
    {
        return V3;
    }
};


class clsB : private clsA
{
public:
    int V4;
    int Funct4()
    {
       return Funct2() * 2 + Funct3() * 3;
    }
};

class clsC : private clsB
{
public:
    int V5 = V4 + Funct4() * 5;
};

int main()
{
    
    clsC C1;
 
    

    system("pause>0");
    return 0;
}