#include <iostream>
#include<string>
#include<iomanip>

using namespace std;

string TrimLeft(string S1)
{
    short Len = S1.size();
    for (int i = 0; i < Len; i++)
    {
        if (S1[i] != ' ')
          return S1.erase(0, i);
    }
    return "";   
}

string TrimRight(string S1)
{
    short Len = S1.size();
    for (int i = Len-1; i >= 0; i--)
    {
        if (S1[i] != ' ')
            return S1.erase(i+1, Len);
    }
   return "";
}

string Trim(string S1)
{
    return TrimRight(TrimLeft(S1));
}

/* solution of teacher

string TrimLeftProf(string S1)
{
    for (short i = 0; i < S1.length(); i++)
    {
        if (S1[i] != ' ') 
        {
            return S1.substr(i, S1.length() - i); 
        }
    } 
    return""; 
}

string TrimRightProf(string S1)
{
    for (short i = S1.length() - 1; i >= 0; i--) 
    {
        if (S1[i] != ' ')
        {
            return S1.substr(0, i + 1);
        }
    }
    return"";
}

string TrimProf(string S1)
{
    return (TrimLeftProf(TrimRightProf(S1)));
}

int main() 
{
    string S1 = "      Mohammed Abu-Hahdoud      ";  
    cout << "\nString     = " << S1;     
    cout << "\n\nTrim Left  = " << TrimLeft(S1);  
    cout << "\nTrim Right = " << TrimRight(S1);   
    cout << "\nTrim       = " << Trim(S1);    
    system("pause>0"); 
}
*/


int main()
{
    string S = "o    Zakaria AKIL best programmer    ";
    cout <<"Trim Left  =" << TrimLeft(S);
    cout <<"\nTrim Right =" << TrimRight(S);
    cout <<"\nTrim       =" << Trim(S);
    system("pause>0");
}


