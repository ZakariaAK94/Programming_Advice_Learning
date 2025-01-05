#include <iostream>
using namespace  std;

enum enChoiceBtwMethods{ LetterfromyourNumber = 1, AllLetters = 2 };

enChoiceBtwMethods ChoiceOfUser()
{
    int Choice;
    cout << "Please choose which method would you like to use :" << endl;
    cout << " (1) : See capitale letter base on the number you enter." << endl;
    cout << " (2) : See  all capitaleletter ." << endl;
    cin >> Choice;

    return enChoiceBtwMethods(Choice);
}

int ReadNumber(string Message)
{
    int Number=0;
    do {
        cout << Message << endl;
        cin >> Number;
    } while (Number < 65 || Number >90);
    return Number;
}

char TransformNmToLetters(int N)
{
    return char(N);
}
void PrintLetterBasedOnNumber(char Letter, int N)
{
    cout << N << " is correspodant to : " << Letter << endl;

}

void PrintAllLetters()
{
    for (int i = 65; i <= 90; i++)
    {
        cout << char(i) << endl;
    }
}


int main()
{
    enChoiceBtwMethods Choice = ChoiceOfUser();
    if (Choice == enChoiceBtwMethods::AllLetters)
        PrintAllLetters();
    else
    {
        int N = ReadNumber("Please enter number in range (65;90) :");
        PrintLetterBasedOnNumber(TransformNmToLetters(N),N);
    }
        
    return 0;
}

