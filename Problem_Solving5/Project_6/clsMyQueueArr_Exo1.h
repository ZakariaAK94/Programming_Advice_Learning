#pragma once
#include<iostream>
#include"clsDblLinkedList.h"
#include"clsDynamicArray.h"
using namespace std;

template <class T>
class clsMyQueueArr
{
protected:

	clsDynamicArray<T> _MyList;

public:

	void Push(T Item)
	{
		_MyList.InsertAtEnd(Item);
	}

	void Pop()
	{
		_MyList.DeleteFirstItem();
	}

	T Back()
	{
		return _MyList.GetItem(Size()-1);
	}

	T Front()
	{
		return _MyList.GetItem(0);
	}

	short Size()
	{
		return _MyList.Size();
	}

	bool IsEmpty()
	{
		return _MyList.IsEmpty();
	}

	void Print()
	{
		_MyList.PrintList();
	}

	T GetItem(int Item)
	{
		return _MyList.GetItem(Item);
	}

	void Reverse()
	{
		_MyList.Reverse();
	}

	void UpdateItem(T Item, T value)
	{
		_MyList.SetItem(Item, value);
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

