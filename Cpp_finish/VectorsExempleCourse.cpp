#include<vector>
#include <iostream>
#include "FctToApplyOnVectors.h";

using namespace std;

int main()
{
    vector <int> Vector1;
    FctToApplyOnVectors::ReadNumber(Vector1);
    FctToApplyOnVectors::PrintVectorElement(Vector1); 
    FctToApplyOnVectors::SortInTheOpposeSense(Vector1); 

  
    return 0;
}