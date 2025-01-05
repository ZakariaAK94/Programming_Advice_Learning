#pragma once
#include<iostream>
#include"clsDblLinkedList.h"
#include"clsMyQueue.h"
using namespace std;

template <class T>
class clsMyStack : public clsMyQueue<T>
{
public:

	void Push(T Item)
	{
		// My solution
		//InsertAtBack(Item);
		// the teacher solution
		clsMyQueue<T>::_MyList.InsertAtBeginning(Item);

	}

	T Bottom()
	{
		return clsMyQueue<T>::Back();
		
	}
	
	T Top()
	{
		return clsMyQueue<T>::Front();

	}

};

