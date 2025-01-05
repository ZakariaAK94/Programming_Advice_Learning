#pragma once
#include<iostream>
#include"clsDblLinkedList.h"
#include"clsMyQueueArr.h"
using namespace std;

template <class T>
class clsMyStackArr : public clsMyQueueArr<T>
{
public:

	void Push(T Item)
	{
		// My solution
		//InsertAtBack(Item);
		// the teacher solution
		clsMyQueueArr<T>::_MyList.InsertAtBeginning(Item);

	}

	T Bottom()
	{
		return clsMyQueueArr<T>::Back();

	}

	T Top()
	{
		return clsMyQueueArr<T>::Front();

	}

};

