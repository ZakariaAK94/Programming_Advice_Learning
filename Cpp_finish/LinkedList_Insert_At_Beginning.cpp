#include <iostream>
using namespace std;

class Node
{
public:
    int Value;
    Node* next;
};

void InsertAtBeginning(Node* &head, int Value)
{
    //allocate memory to a node
    Node* new_node = new Node();
    // insert the data
    new_node->Value = Value;
    new_node->next = head;  // current node take head previous node 
    //Mode head to new node
    head = new_node; // here the head take this node which will be previous in the next step

}

Node* Find(Node* head, int Value)
{
    while (head != NULL)
    {
        if (head->Value == Value)
            return head;
        head = head->next;
    }
    return NULL;
}

void PrintList(Node* head)
{
    while (head != NULL)
    {
        cout << head->Value << " ";
        head = head->next;
    }
}




int main()
{
    Node* head = NULL;

    /*Node* Node1 = new Node();

    Node1->Value = 100;
    Node1->next = NULL;

    head = Node1;*/

    InsertAtBeginning(head, 100);
    InsertAtBeginning(head, 2);
    InsertAtBeginning(head, 4);
    InsertAtBeginning(head, 5);
    InsertAtBeginning(head, 9);

    PrintList(head);

    Node* Node1;

    Node1 = Find(head,4);
    if (Node1 != NULL)
        cout << "\nValue is found :-) ";
    else
        cout << "\nValue is not found :-( ";
    
    system("pause>0");

    return 0;

}
