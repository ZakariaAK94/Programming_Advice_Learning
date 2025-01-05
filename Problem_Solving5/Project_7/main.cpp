//ProgrammingAdvices.com
//Mohammed Abu-Hadhoud

#include <iostream>
#include "clsMyString.h"

using namespace std;

int main()
{
    cout << "\n\n\t\t\tUndo / Redo project \n\n";
    clsMyString S1;
    cout << "S1   = " << S1.Value << endl;
    S1.Value = "Mohamed";
    cout << "S1   = " << S1.Value << endl;
    S1.Value = "Mohamed2";
    cout << "S1   = " << S1.Value << endl;
    S1.Value = "Mohamed3";
    cout << "S1   = " << S1.Value << endl;
    cout << "\n Undo: ";
    cout << "\n___________\n";
    S1.Undo();
    cout << "\n S1 after undo = " << S1.Value << "\n";
    S1.Undo();
    cout << "\n S1 after undo = " << S1.Value << "\n"; 
    S1.Undo();
    cout << "\n S1 after undo = " << S1.Value << "\n";
   
    cout << "\n Redo: ";
    cout << "\n___________\n";
    S1.Redo();
    cout << "\n S1 after Redo = " << S1.Value << "\n";
    S1.Redo();
    cout << "\n S1 after Redo = " << S1.Value << "\n";
    S1.Redo();
    cout << "\n S1 after Redo = " << S1.Value << "\n";
    
    system("pause>0");

}