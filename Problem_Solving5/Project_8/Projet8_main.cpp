#include <iostream>
#include"clsQueueLine.h"
using namespace std;

int main()
{
    clsQueueLine PayBillsQueue("A0", 10);

    PayBillsQueue.IssueTicket();
    PayBillsQueue.IssueTicket();
    PayBillsQueue.IssueTicket();
    PayBillsQueue.IssueTicket();
    PayBillsQueue.IssueTicket();

    cout << "\nPay Bills Queue Info:\n";
    PayBillsQueue.PrintInfo();

    PayBillsQueue.PrintTicketLineRTL();
    PayBillsQueue.PrintTicketLineLTR();

    PayBillsQueue.PrintAllTickets();

    PayBillsQueue.ServedNextClient();
    cout << "\nPay Bills Queue After serving one client:\n";
    PayBillsQueue.PrintInfo();

    PayBillsQueue.PrintAllTickets();

    system("pause>0");

}

