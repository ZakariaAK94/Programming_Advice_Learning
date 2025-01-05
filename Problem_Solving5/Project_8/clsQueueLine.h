#pragma once
#include<iostream>
#include"clsDate.h"
#include"queue"
#include"stack"
using namespace std;

class clsQueueLine
{
private:
	string _Prefix = "";
	short _AverageServeTime = 0;
	short _TotalTickets = 0;
	class clsTicket
	{
	protected:

		short _Number = 0;
		string _Prefix;
		string _TicketTime;
		short _WaitingClients =0;
		short _AverageServeTime =0;
		short _ExpectedServeTime = 0;

	public:

		clsTicket(string Prefix, short Number, short WaitingClients, short AverageServeTime)
		{
			_Prefix = Prefix;
			_TicketTime = clsDate::GetSystemDateTimeString();
			_Number = Number;
			_WaitingClients = WaitingClients;
			_AverageServeTime = AverageServeTime;
			_ExpectedServeTime = _AverageServeTime * _WaitingClients;

		}

		string Prefix()
		{
			return _Prefix;
		}
		short Number()
		{
			return _Number;
		}
		string TicketTime()
		{
			return _TicketTime;
		}

		string FullNumber()
		{
			return _Prefix + to_string(_Number);
		}

		short WaitingClients()
		{
			return _WaitingClients;
		}

		short AverageSereTime()
		{
			return _AverageServeTime;
		}

		int ExpectedServeTime()
		{
			return _ExpectedServeTime;
		}

		void Print()
		{
			cout << "\n\t\t\t________________________________\n";
			cout << "\n\t\t\t\t    " << FullNumber() << "\n";
			cout << "\n\t\t\t    " << _TicketTime << "\n";
			cout << "\n\t\t\t   Waiting Client = " << _WaitingClients ;
			cout << "\n\t\t\t    Serve time In  ";
			cout << "\n\t\t\t     " << ExpectedServeTime() << " Minutes";
			cout << "\n\t\t\t________________________________\n";
		}

	};  
		
public:

	queue<clsTicket> QueueLine;

	clsQueueLine(string Prefix, int AverageServeTime)
	{
		_Prefix = Prefix;
		_AverageServeTime = AverageServeTime;
		_TotalTickets = 0;
	}

	void IssueTicket()
	{
		_TotalTickets++;
		clsTicket Ticket(_Prefix,_TotalTickets,WaitingClients(),_AverageServeTime);
		QueueLine.push(Ticket);
		
	}

	int WaitingClients()
	{
		return QueueLine.size();
	}

	string WhoIsNext()
	{
		if (QueueLine.empty())
			return "No Client Left.";
		else
			return QueueLine.front().FullNumber();
	}

	bool ServedNextClient()
	{
		if (QueueLine.empty())
			return false;
		QueueLine.pop();	
		return true;
	}

	short ServedClients()
	{
		return _TotalTickets - WaitingClients();
	}

	void PrintInfo()
	{
		cout << "\n\t\t\t__________________________________\n";	
		cout << "\n\t\t\t\tQueue Info \n";
		cout << "\n\t\t\t__________________________________\n";
		cout << "\n\t\t\t   Prefix  = " << _Prefix << "\n";
		cout << "\n\t\t\t   Total Tickets   = " << _TotalTickets ;
		cout << "\n\t\t\t   Served Clients  = " << ServedClients() ;
		cout << "\n\t\t\t   Waiting Clients = "  << WaitingClients() ;
		cout << "\n\t\t\t__________________________________\n\n";
		cout << "\n";
	}


	void PrintTicketLineRTL()
	{
		if (QueueLine.empty())
		{
			cout << "\n\t\tTickets: No ticket.";
		}	
		else
			cout << "\n\t\tTickets: ";
		
		//we copy the queue in order not to  lose the  original data
		queue<clsTicket> TempQueueLine = QueueLine;
		while (!TempQueueLine.empty())
		{
			cout << TempQueueLine.front().FullNumber() << "<--";
			TempQueueLine.pop();
		}
		cout << "\n";
	
	}

	void PrintTicketLineLTR()
	{
		if (QueueLine.empty())
		{
			cout << "\n\t\tTickets: No ticket.";
		}
		else
			cout << "\n\t\tTickets.";
		
		queue<clsTicket> TempQueueLine = QueueLine;
		stack<clsTicket> TempStackLine;
		while (!TempQueueLine.empty())
		{
			TempStackLine.push(TempQueueLine.front());
			TempQueueLine.pop();
		}
		while (!TempStackLine.empty())
		{
			cout << TempStackLine.top().FullNumber() << "-->";
			TempStackLine.pop();
		}
		cout << "\n";
	}

	void PrintAllTickets()
	{
		cout << "\n\n\t\t\t      --Tickets---";
		if (QueueLine.empty())
		{
			cout << "\n\n\t\t\t    ---No Tickets --- \n";
		}
		//we copy the queue in order not to  lose the original data
		queue <clsTicket> TempQueueLine = QueueLine;	

		while (!TempQueueLine.empty())
		{
			TempQueueLine.front().Print();
			TempQueueLine.pop();
		}

	}

	


};

