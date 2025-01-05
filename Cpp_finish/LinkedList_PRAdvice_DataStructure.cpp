#include <iostream>
using namespace std;

class Node
{
public:
    int value;
    Node* Next;
};

int main()
{
    Node* head;

    Node* Node1 = NULL;
    Node* Node2 = NULL;
    Node* Node3 = NULL;

    //allocate 3 nodes in the Heap
    Node1 = new Node();
    Node2 = new Node();
    Node3 = new Node();

    // Assign value values
    Node1->value = 1;
    Node2->value = 2;
    Node3->value = 3;

    //connect nodes
    Node1->Next = Node2;
    Node2->Next = Node3;
    Node3->Next = NULL;

    //print the linked list value
    head = Node1;

    while (head != NULL)
    {
        cout << head->value <<endl;
        head = head->Next;
    }

    delete Node1;
    delete Node2;
    delete Node3;

    system("pause>0");
    return 0;
}



