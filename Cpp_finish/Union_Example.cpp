#include <iostream>

union MyUnion {
    int intValue;
    float floatValue;
    char charValue;
    // all members share the same memory location ,and the memory size of the union is equal to the size of its largest member
    // only one member of the union can hold a value at any given time
};

int main() {
    MyUnion myUnion;

    myUnion.intValue = 42;
    std::cout << "Integer value: " << myUnion.intValue << std::endl;

    myUnion.floatValue = 3.14f;
    std::cout << "Float value: " << myUnion.floatValue << std::endl;

    myUnion.charValue = 'A';
    std::cout << "Char value: " << myUnion.charValue << std::endl;

    return 0;
}