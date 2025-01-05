#include <iostream>
using namespace std;

enum MyFavoriteTeam {REAL=1, BARCA=2, PSG=3, ROMA=4, CITY=5, LIVERPOOL=6};

int main()
{
    int c;
    MyFavoriteTeam choice;
    cout << "(1) : Real" << endl;
    cout << "(2) : BARCA" << endl;
    cout << "(3) : PSG" << endl;
    cout << "(4) : ROMA" << endl;
    cout << "(5) : CITY" << endl;
    cout << "(6) : LIVERPOOL" << endl;
    cout << "What is your favorite football club ?" << endl;
    cin >> c;
    choice = (MyFavoriteTeam)c;
    if (choice == MyFavoriteTeam::REAL)
    {
        cout << "You have chose Real good luck" << endl;
        system("color 1F");
    }
    else if (choice == MyFavoriteTeam::BARCA)
    {
        cout << "You have chose Barça good luck" << endl;
    }
    else if (choice == MyFavoriteTeam::PSG)
    {
        cout << "You have chose PSG good luck" << endl;
    }
    else if (choice == MyFavoriteTeam::ROMA)
    {
        cout << "You have chose Roma good luck" << endl;
    }
    else if (choice == MyFavoriteTeam::CITY)
    {
        cout << "You have chose City good luck" << endl;
    }
    else
    {
        cout << "You have chose lIVERPOOL good luck" << endl;
    }

    return 0;
}