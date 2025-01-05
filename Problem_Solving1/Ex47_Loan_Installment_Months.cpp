#include <iostream>
using namespace std;

enum enChoiceTypeOfPayment{OnMonths = 1, OnMonthlyPayment = 2};

enChoiceTypeOfPayment ChoiceOfUser()
{
    int Choice = 0;
    cout << "Please enter which method would you like to use :" << endl;
    cout << "(1) payment based on number of months you want to use." << endl;
    cout << "(2) payment based on amount of money paid each month." << endl;
    cin >> Choice;
    return enChoiceTypeOfPayment(Choice);

}

struct strSettleTheLoan {
    float LoanAmount;
  float MonthlyPayment;   
   float NbrOfMonths;
};

float ReadNumber(string Message)
{
    float Number=0;
    do
    {
        cout << Message << endl;
        cin >> Number;

    } while (Number < 0);
    return Number;
}

float CalculateNbrOfMonthsToSettleLoan(enChoiceTypeOfPayment Choice)
{
    strSettleTheLoan SettleLoan;
    SettleLoan.LoanAmount = ReadNumber("Please enter LoanAmount :");
    if (Choice == enChoiceTypeOfPayment::OnMonthlyPayment)
    {
        SettleLoan.MonthlyPayment = ReadNumber("Please enter MonthlyPayment :");
        return float(SettleLoan.LoanAmount / SettleLoan.MonthlyPayment);
    }
    else
    {
        SettleLoan.NbrOfMonths = ReadNumber("Please enter how many months would you like to complete payment :");
        return float(SettleLoan.LoanAmount / SettleLoan.NbrOfMonths);
    }
    
    

    
}

void PrintResult(float Result, enChoiceTypeOfPayment Choice)
{
    
    if (Choice == enChoiceTypeOfPayment::OnMonthlyPayment)
    {
        cout << "you need to pay " << Result << " dollars each month " << endl;
    }
    else
    {
        cout << "you need " << Result << " Months to settle the loan." << endl;
    }

    
}
int main()
{
    enChoiceTypeOfPayment Choice = ChoiceOfUser();
    PrintResult(CalculateNbrOfMonthsToSettleLoan(Choice),Choice);
}
