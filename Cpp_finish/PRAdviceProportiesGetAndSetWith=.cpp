#include <iostream>
using namespace std;

class clsStudent
{
private:
    int _ID = 20;
    int _X;
    int _Y;
    int _Z;

public:

    void SetValuesX(int x)
    {
        _X = x;
    }
    void SetValuesY(int y)
    {
        _Y = y;        
    }
    void SetValuesZ(int z)
    {
        _Z = z;
    }

    int GetID()
    {
        return _ID;
    }
    int GetSumOfValues()
    {
        return (_X + _Y + _Z);
    }

    float GetAverage(float sum)
    {
        return (sum / 3);
    }
    /* __declspec( property( get=get_func_name, put=put_func_name ) ) declarator */

    __declspec (property (get = GetID)) int ID;
    __declspec (property (put=SetValuesX)) int X;
    __declspec (property (put=SetValuesY)) int Y;
    __declspec (property (put=SetValuesZ)) int Z;
    __declspec (property (get = GetSumOfValues)) int Sum;

};


int main()
{
    clsStudent Student1;

    /*Student1.SetValuesX(12);
    Student1.SetValuesY(14);
    Student1.SetValuesZ(10);*/

    Student1.X = 12;
    Student1.Y = 14;
    Student1.Z = 10;
     
    cout << "Your ID is :" << Student1.ID << endl;

    cout << "Your averge is : " << Student1.GetAverage(Student1.Sum) << endl;

    system("pause >0 ");

}
