#include <iostream>
using namespace std;

int main()
{
	short LoanAmount, MonthlyPayment, MonthlyInsallmentAmount;
	cout << "Please enter the values of LoanAmount and MonthlyPayment to calculate how many months you need to settle the loan :" << endl;
	cin >> LoanAmount;
	cin >> MonthlyPayment;
	cout << " You need " << LoanAmount / MonthlyPayment << " months to settle the loan.\n\n";
	cout << "Please enter the values of LoanAmount and how many months you need to settle the loan, then I will calculate the monthly installment amount:" << endl;
	cin >> LoanAmount;
	cin >> MonthlyInsallmentAmount;
	cout << " You need to pay " << LoanAmount / MonthlyInsallmentAmount << " of your country'currency per months to settle the loan.\n\n";

	return 0;

}