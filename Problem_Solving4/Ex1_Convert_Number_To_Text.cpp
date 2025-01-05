#include <iostream>
#include<string>
#include<vector>
#include<math.h>
using namespace std;

int PowerOfNumber(int Number);

int ReadNumber()
{
    int Num;
    cout << "Enter a number ?";
    cin >> Num;

    return Num;
}

string FindstringfromOneToNineteen(int Number, vector <string> NbrOneToNineteen)
{
    switch (Number)
    {
    case 1:
        return NbrOneToNineteen[0];
    case 2:
        return NbrOneToNineteen[1];
    case 3:
        return NbrOneToNineteen[2];
    case 4:
        return NbrOneToNineteen[3];
    case 5:
        return NbrOneToNineteen[4];
    case 6:
        return NbrOneToNineteen[5];
    case 7:
        return NbrOneToNineteen[6]; 
    case 8:
        return NbrOneToNineteen[7]; 
    case 9:
        return NbrOneToNineteen[8];
    case 10:
        return NbrOneToNineteen[9];
    case 11:
        return NbrOneToNineteen[10];
    case 12:
        return NbrOneToNineteen[11];
    case 13:
        return NbrOneToNineteen[12];
    case 14:
        return NbrOneToNineteen[13];
    case 15:
        return NbrOneToNineteen[14];
    case 16:
        return NbrOneToNineteen[15];
    case 17:
        return NbrOneToNineteen[16];
    case 18:
        return NbrOneToNineteen[17];
    case 19:
        return NbrOneToNineteen[18];
    default:
        return " ";
    }
}

string FindstringfromTwentyToNinety(int Number, vector <string> NbrTwentyToNinety)
{
    switch (Number)
    {
    case 2:
        return NbrTwentyToNinety[0];
    case 3:
        return NbrTwentyToNinety[1];
    case 4:
        return NbrTwentyToNinety[2];
    case 5:
        return NbrTwentyToNinety[3];
    case 6:
        return NbrTwentyToNinety[4];
    case 7:
        return NbrTwentyToNinety[5];
    case 8:
        return NbrTwentyToNinety[6];
    case 9:
        return NbrTwentyToNinety[7];
    }
}

string FindstringforNumbers(int power, int Number)
{
    string TextNbr = " ";
    vector <string> OneToNineteen = { "One","Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten", "Eleven","Tweleve","Thorteen","Fourteen","Fifteen","Sixteen","Seventeen","Eighteen","Nineteen" };
    vector <string> TwentyToNinety = { "Twenty","Thirty","Forty","Fifty","Sixty","Seventy","Eighty","Ninety" };
    vector <string> HundToBills = { "Hundred","Thousand","Million","Milliar","Billions" };
    int Rest, power1, power2;

    if(power == 0)
        return TextNbr += FindstringfromOneToNineteen(Number, OneToNineteen);
    else if (power == 1) // multiplication of Ten
    {
       
        if (Number < 20)
        {
            return TextNbr += FindstringfromOneToNineteen(Number, OneToNineteen);
        }
        else
        {
            return TextNbr += FindstringfromTwentyToNinety(Number / 10, TwentyToNinety) + " " 
                           += FindstringforNumbers(power - 1, Number % 10);
        }
    }
    else if (power == 2)//multiplication of Hundred
    {
        return TextNbr += FindstringfromOneToNineteen(Number / 100, OneToNineteen) + " " 
                       += "Hundred" + FindstringforNumbers(power - 1, Number % 100);
    }
    else if (power >= 3 && power <= 5)//multiplication of thousand
    {
        Rest = Number % 1000;
        Number = Number / 1000;
        power1 = PowerOfNumber(Number) - 1;
        power2 = PowerOfNumber(Rest) - 1;
        return TextNbr += FindstringforNumbers(power1, Number) + " " 
                       += "Thousand" + FindstringforNumbers(power2, Rest);
    }
    else if (power >= 6 && power <= 8)
    {
        Rest = Number % 1000000;
        Number = Number / 1000000;
        power1 = PowerOfNumber(Number) - 1;
        power2 = PowerOfNumber(Rest) - 1;
        return TextNbr += FindstringforNumbers(power1, Number) + " " 
                       += "Million" + FindstringforNumbers(power2, Rest);
    }
    else if(power >= 9 && power <= 12)
    {
        Rest = Number % 1000000000;
        Number = Number / 1000000000;
        power1 = PowerOfNumber(Number) - 1;
        power2 = PowerOfNumber(Rest) - 1;
        return TextNbr += FindstringforNumbers(power1, Number) + " " 
                       += "Billion" + FindstringforNumbers(power2, Rest);
    }
    
}


int PowerOfNumber(int Number)
{
    int Rest;
    int power = 0;
    do
    {
        Rest = Number % 10;
        Number = (Number - Rest) / 10;
        power++;
    } while (Number != 0);

    return power;
}



int main()
{
    
    char Answer = 'n';
    do {
        system("cls");
        int Number = ReadNumber();
        cout << FindstringforNumbers(PowerOfNumber(Number) - 1, Number);
        cout << "\n\n Do you wanna enter another number ? y/n?"<<endl;
        cin >> Answer;
    } while (tolower(Answer) == 'y');
    
    system("pause>0");
}


//string FindstringfromHundrToBill(int power, vector <string> NbrHundToBill)
//{
//
//    if(power ==2)
//        return NbrHundToBill[0];
//    else if(power >=3 && power <=5)
//        return NbrHundToBill[1];
//    else if(power >=6 && power <=8)
//        return NbrHundToBill[2];
//    else if(power >= 9 && power <= 11)
//        return NbrHundToBill[3];
//    else
//        return NbrHundToBill[4];
//}