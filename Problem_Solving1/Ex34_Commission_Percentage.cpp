#include <iostream>
using namespace std;

int ReadTotalSales()
{
    int TotalSales;
    cout << "Please enter your TotalSales :" << endl;
    cin >> TotalSales;
    return TotalSales;
}
float GetCommissionPercentage(int TotalSales)
{
    if (TotalSales > 1000000)
        return 0.01;
    else if (TotalSales <= 1000000 || TotalSales > 500000)
        return 0.02;
    else if (TotalSales <= 500000 || TotalSales > 100000)
        return 0.03;
    else if (TotalSales <= 100000 || TotalSales > 50000)
        return 0.05;
    else
        return  0.00;
}
float CalculateCommission(float TotalSales)
{
        return float (GetCommissionPercentage(TotalSales) * TotalSales);
    
}


int main()
{
    int TotalSales = ReadTotalSales();
    cout << "Comission percentage = " << GetCommissionPercentage(TotalSales) << endl;
    cout << "Total Comission = " << CalculateCommission(TotalSales) << endl;
    return 0;
}


