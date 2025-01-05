#include <iostream>
#include <map>
#include <vector>
#include <string>
using namespace std;

int main()
{
    //Declare map with keys string and int values
    map<string, int> StudentGrades;

    //inserting grades for three students
    StudentGrades["Ziko"] = 20;
    StudentGrades["Ahmed"] = 50;
    StudentGrades["Maryam"] = 70;

    cout << "\nPrinting all map values..\n\n";

    // iterating over the map
    for ( auto& pair : StudentGrades)
    {
         cout << "Student: " << pair.first << ", Grade: " << pair.second << endl;
    }

    // Finding the grade for a specific student
    string studentName = "Fadi";
    if (StudentGrades.find(studentName) != StudentGrades.end()) {
        cout << studentName << "'s grade: " << StudentGrades[studentName] << endl;
    }
    else {
        cout << "Grade not found for " << studentName << endl;
    }


}
