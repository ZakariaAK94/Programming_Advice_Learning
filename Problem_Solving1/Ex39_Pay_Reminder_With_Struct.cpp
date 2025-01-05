#include <iostream>
#include <string>
using namespace std;

struct stPayment
{
    int TotalBill;
    int CashPaid;
};

stPayment ReadInforOfPay()
{
    stPayment Payment;
    cout << "Please entre the TotalBill ?" << endl;
    cin >> Payment.TotalBill;
    cout << "Please entre the CashPaid ?" << endl;
    cin >> Payment.CashPaid;

    return Payment;
}

int calculateremainderPay(stPayment Payment)
{
    return Payment.TotalBill - Payment.CashPaid;
}

void ShowRemainderTopay(stPayment Payment)
{
    cout << "\n";
    cout << " TotalBill = " + to_string(Payment.TotalBill) << endl;
    cout << " CashPaid = " + to_string(Payment.CashPaid) << endl;
    cout << " ******************************************** " << endl;
    cout << "The remainder to be paid back is " << calculateremainderPay(Payment) << endl;
}


int main()
{
    ShowRemainderTopay(ReadInforOfPay());
    return 0;
}


