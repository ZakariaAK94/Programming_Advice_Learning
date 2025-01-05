#include <iostream>
using namespace std;

enum enPassFail { Pass = 1, Fail = 2 };

void ReadNumbersWithTable(int T[])
{
    for (int i = 0; i < 3; i++)
    {
        cout << "Please enter Number " <<i+1<< " :  ";
        cin >> T[i];
    }

}

int CalculateAverageOfnote(int T[])
{
    int sum = 0;
    ReadNumbersWithTable(T);
    for (int i = 0; i < 3; i++)
    {
        sum += T[i];
    }
    cout << "You average is : " << (float)sum / 3 << endl;
    return (float) sum/3;
}

enPassFail CheckMark(int Mark)
{
    if (Mark >= 50)
        return enPassFail::Pass;
    else
        return enPassFail::Fail;
}

void PrintResult(int Number)
{
    
    if (CheckMark(Number) == enPassFail::Pass)
        cout << "You passed !!";
    else
        cout << "You failed !!";
}

int main()
{
    int T[10];
    PrintResult(CalculateAverageOfnote(T));
    return 0;
}


//void PrintResult2(int T[])
//{
//    int Sum;
//    float Average;
//    Sum = CalculateAverageOfnote(T);
//    Average = (float) (Sum / 3);
//    cout << "The sum of the three Numbers is : " << Sum << endl;
//    cout << "The average of the three Numbers is : " << Average << endl;
//    
//}

//int ReadMark()
//{
//    int Mark;
//    cout << "Please enter a Mark" << endl;
//    cin >> Mark;
//    return Mark;
//}

//int CalculateSumOfNumbers(stNumbers Numbers)
//{
//    return (Numbers.Number1 + Numbers.Number2 + Numbers.Number3);
//}

//
//void PrintResults(enPassFail Mark)
//{
//	if (Mark == enPassFail::Pass)
//		cout << "You passed !!";
//	else
//		cout << "You failed !!";
//}
//struct stNumbers {
//    int Number1;
//    int Number2;
//    int Number3;
//};

//stNumbers ReadNumbers()
//{
//    stNumbers Numbers;
//    cout << "Please enter Number1 :" << endl;
//    cin >> Numbers.Number1;
//    cout << "Please enter Number2 :" << endl;
//    cin >> Numbers.Number2;
//    cout << "Please enter Number3 :" << endl;
//    cin >> Numbers.Number3;
//
//    return Numbers;
//}

//void PrintResult()
//{
//  
//    cout << "The sum of the three Numbers is : " << CalculateSumOfNumbers(ReadNumbers()) << endl;
//}