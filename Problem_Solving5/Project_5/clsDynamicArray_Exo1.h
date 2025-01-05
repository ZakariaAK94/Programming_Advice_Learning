#pragma once
#include<iostream>
#include"clsMyQueue.h"
using namespace std;

template<class T>
class clsDynamicArray 
{
protected:
	int _Size=0;
	T* _TempArray;
public:

	T* OriginalArray;

	clsDynamicArray(int Size =0)
	{
		if (Size<0)
			Size =0;
		_Size = 0;

		OriginalArray = new T[_Size];
	
	}
	 // it is important to save space in your program
	~clsDynamicArray()
	{
		delete[] OriginalArray;
	}

	bool SetItem(int Index, T Value)
	{
		if (Index >= _Size || _Size < 0)
			return false;

		OriginalArray[Index] = Value;
		return true;
	}

	T GetItem(int index)
	{
		return OriginalArray[index];

	}

	void Reverse()
	{
		_TempArray = new T[_Size];
		for (int i = _Size - 1; i >= 0; i--)
		{
			_TempArray[i] = OriginalArray[_Size - 1 - i];
		}

		delete[] OriginalArray;
		OriginalArray = _TempArray;
	}

	bool DeleteItemAt(int Index)
	{
		if (Index >= _Size || Index < 0)
		{
			return false;
		}

		_Size--;
		_TempArray = new T[_Size];

		// copy all before index
		for (int i = 0; i<Index; i++)
		{
			_TempArray[i] = OriginalArray[i];	
		}

		//copy all after Index
		for (int i = Index+1; i < _Size+1; i++)
		{
			_TempArray[i-1] = OriginalArray[i];
		}
		delete[] OriginalArray;
		OriginalArray = _TempArray;
		
	}

	void DeleteFirstItem()
	{
		// My solution repeat coding
		//_Size--;
		//_TempArray = new T[_Size];
		//// copy all before index
		//for (int i = 1; i <= _Size; i++)
		//{
		//	_TempArray[i-1] = OriginalArray[i];
		//}
		//delete[] OriginalArray;
		//OriginalArray = _TempArray;

		DeleteItemAt(0);
	}

	void DeleteLastItem()
	{
		 //this my long solution
		//_Size--;
		//_TempArray = new T[_Size];
		//// copy all before index
		//for (int i = 0; i < _Size; i++)
		//{
		//	_TempArray[i] = OriginalArray[i];
		//}
		//delete[] OriginalArray;
		//OriginalArray = _TempArray;
		DeleteItemAt(_Size - 1);
	}

	int Find(T Value)
	{
		if (_Size == 0)
			return -1;
		for (int i = 0; i < _Size; i++)
		{
			if (OriginalArray[i] == Value)
				return i;
		}

		return -1;
	}

	bool DeleteItem(T Value)
	{
		int Index = Find(Value);
		if (Index == -1)
			return false;

		DeleteItemAt(Index);
		return true;
	}

	bool InsertAt(int Index, T Value)
	{
		/*if (Index >= _Size || Index < 0)
		{
			return false;
		}*/

		_Size++;
		_TempArray = new T[_Size];

		// copy all before index
		for (int i = 0; i < Index; i++)
		{
			_TempArray[i] = OriginalArray[i];
		}
		_TempArray[Index] = Value;
		//copy all after Index
		for (int i = Index; i < _Size-1 ; i++)
		{
			_TempArray[i+1] = OriginalArray[i];
		}
		
		delete[] OriginalArray;
		OriginalArray = _TempArray;

		return true;
	}

	bool InsertAtBeginning(T Value)
	{
		return InsertAt(0, Value);
	}

	bool InsertAtEnd(T Value)
	{
		return InsertAt(_Size, Value);
	}

	bool InsertBefore(int Index,T Value)
	{
		if (Index < 1)
			return InsertAt(0, Value);
		else
			return InsertAt(Index-1, Value);
	}

	bool InsertAfter(int Index, T Value)
	{
		if (Index > _Size - 1)
			return InsertAt(_Size - 1,Value);
		else
			return InsertAt(Index + 1, Value);
	}

	void Clear()
	{
		_Size = 0;
		_TempArray = new T[0];
		delete[] OriginalArray;
		OriginalArray = _TempArray;
	}

	void PrintList()
	{
		for (int i = 0; i < _Size; i++)
		{
			cout << OriginalArray[i] << " ";
		}
		
		cout << "\n";
	}

	int Size()
	{
		return _Size;
	}

	bool IsEmpty()
	{
		return _Size == 0 ? true:false;
	}

	void Resize(int NewSize)
	{
		// My solution
		/*if (NewSize <0)
			NewSize =0 ;
		else if(NewSize < _Size)
		{
			
			_TempArray = new T[NewSize - 1];
			for (int i = 0; i < NewSize; i++)
			{
				_TempArray[i] = OriginalArray[i];
			}
			_Size = NewSize;
			delete[] OriginalArray;
			OriginalArray = _TempArray;
		}
		else
		{
			_TempArray = new T[NewSize - 1];
			for (int i = 0; i < _Size; i++)
			{
				_TempArray[i] = OriginalArray[i];
			}
			_Size = NewSize;
			delete[] OriginalArray;
			OriginalArray = _TempArray;
		}*/

		 //teacher solution
		if (NewSize < 0)
		{
			NewSize = 0;
		}

		_TempArray = new T[NewSize];
		//limit the original size to the new size if it is less.
		if (NewSize < _Size)
			_Size = NewSize;

		//copy all data from original array until the size
		for (int i = 0; i < _Size; i++)
		{
			_TempArray[i] = OriginalArray[i];
		}

		_Size = NewSize;

		delete[] OriginalArray;
		OriginalArray = _TempArray;
		
    }

};

