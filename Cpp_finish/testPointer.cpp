#include <iostream>
using namespace std;

int main()
{
    int number = 42;  // Declare an integer variable
    int* pointer;     // Declare a pointer variable

    //pointer = &number; // Assign the memory address of 'number' to the pointer

    //printf("Value of number: %d\n", number);
    printf("Address of number: %p\n", &number);
    printf("Address of number: %p\n", &pointer);

    //printf("Value stored at pointer: %d\n", *pointer); // Access the value using the pointer

    system("pause>0");
   
}


