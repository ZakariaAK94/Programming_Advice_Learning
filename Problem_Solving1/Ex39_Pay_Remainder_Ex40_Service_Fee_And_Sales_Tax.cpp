#include <iostream>
using namespace std;

int main()
{
	int TotalBill, CashPaid;
	cout << "Please enter the TotalBill and CashPaid :" << endl;
	cin >> TotalBill;
	cin >> CashPaid;
	cout << "the remainder to be paid back is :" << TotalBill - CashPaid << endl;

	/*************************************************************************/

	int BillValue;
	cout << "Please enter the BillValue to calculate the TotalBill :" << endl;
	cin >> BillValue;
	cout << "The TotalBill is :" << (BillValue * 1.1)*1.16 << endl ;

	return 0;

}
