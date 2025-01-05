#include <iostream>
using namespace std;

int ReadNumberInRange(int N, int From, int To)
{
    do {
        cout << "Please enter a number in range 0 to 100 :" << endl;
        cin >> N;
    } while (N < From || N > To);
    
    return N;
}

char GetGradeLetter(int Grade)
{
    if (Grade <= 100 && Grade > 90)
        return 'A';
    else if (Grade <= 90 && Grade > 80)
        return 'B';
    else if (Grade <= 80 && Grade > 70)
        return 'C';
    else if (Grade <= 70 && Grade > 60)
        return 'D';
    else if (Grade <= 60 && Grade > 50)
        return 'E';
    else 
        return 'F';

}


int main()
{
    int N=0;
    cout << "Your grade is: " << GetGradeLetter(ReadNumberInRange(N, 0, 100));
    return 0;
}
