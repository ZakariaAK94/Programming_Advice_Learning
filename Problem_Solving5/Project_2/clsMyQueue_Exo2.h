#pragma once
#include<iostream>
#include"clsDblLinkedList.h"
using namespace std;

template <class T>
class clsMyQueue
{
protected:

	clsDblLinkedList<T> _MyList;

public:

	void Push(T Item)
	{
		//My Stupid solution, what makes one programer best than other		
		////creation of a nex Queue
		//Queue* NewQueue = new Queue();
		//NewQueue->value = value;
		//NewQueue->Next = NULL;
		////Check if the fisrt Queue is empty or not
		//if (head == NULL)
		//{
		//	head = NewQueue;
		//	_Size++;
		//	FrontQueue = head; 
		//	BackQueue = head;
		//	return;
		//}
		////if the Queue is not empty
		//else
		//{
		//	Queue* Current = head;
		//	while (Current->Next != NULL)
		//	{
		//		Current = Current->Next;
		//	}
		//	Current->Next = NewQueue;
		//	BackQueue = NewQueue;
		//}		
		//_Size++;

		_MyList.InsertAtEnd(Item);

	}

	void Pop()
	{
		_MyList.DeleteFirstNode();
		//My Stupid List
		//if (_Size < 0)
		//{
		//	_Size = 0;
		//	return;
		//}
		//if (head== NULL)
		//{
		//	_Size--;
		//	return;
		//}
		//if (head->Next == NULL)
		//{
		//	delete head;
		//	head = NULL;
		//	_Size--;
		//	return;
		//}
		////if the Queue is not empty
		//Queue* Current = head;
		//
		//while (Current->Next->Next != NULL)
		//{
		//		Current = Current->Next;
		//}
		//Queue* PrevQueue = Current->Next;
		//Current->Next = NULL;
		//delete PrevQueue;
		//BackQueue = Current;
		//_Size--;
	}

	T Back()
	{
		return _MyList.GetItems(Size() - 1);
		//My stupid solution
		//return _Size<=0 ? -1: BackQueue->value;
	}

	T Front()
	{
		return _MyList.GetItems(0);
		//My stupid solution
		//return _Size <= 0 ? -1:FrontQueue->value;
	}

	short Size()
	{
		return _MyList.size();
	}

	bool IsEmpty()
	{
		return _MyList.IsEmpty();
	}	
	
	void Print()
	{

		_MyList.PrintList();
		//My Stupid solution
		/*Queue* Current = head;
		while (Current != NULL)
		{
			cout << Current->value << " ";
			Current = Current->Next;
		}*/
	}

	T GetItem(int Item)
	{
		return _MyList.GetItems(Item);
	}

	void Reverse()
	{
		_MyList.Reverse();
	}

	void UpdateItem(T Item, T value)
	{
		_MyList.UpdateItem(Item, value);
	}

	void InsertAfter(T Item, T value)
	{
		_MyList.InsertAfter(Item, value);
	}

	void InsertAtFront(T value)
	{
		_MyList.InsertAtBeginning(value);
	}

	void InsertAtBack(T value)
	{
		_MyList.InsertAtEnd(value);
	}

	void Clear()
	{
		_MyList.Clear();
	}



};

