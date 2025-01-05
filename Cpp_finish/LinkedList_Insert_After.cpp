#include <iostream>
using namespace std;

class Node
{
public:
    int Value;
    Node* next;
  
};

void PrintList(Node* head)
{
    while (head != NULL)
    {
        cout << head->Value << " ";
        head = head->next;
    }
}

void InsertAtBeginning(Node*& head, int Value)
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
        {
            return head;
        }
        head = head->next;        
    }
    return NULL;
}

//insert node after a node
void InsertAfter(Node* prev_node, int NewValue)
{
    if (prev_node == NULL)
    {
        cout << "the given previous node cannot be NULL";
        return;
    }
    Node* NewNode = new Node();

    NewNode->Value = NewValue;
    NewNode->next = prev_node->next;
    prev_node->next = NewNode;
   
}

int main()
{
    Node* head = NULL;

    InsertAtBeginning(head, 100);
    InsertAtBeginning(head, 2);
    InsertAtBeginning(head, 4);
    InsertAtBeginning(head, 5);
    InsertAtBeginning(head, 9);

    PrintList(head);

    Node* Node1 = Find(head,2);

    InsertAfter(head, 13);

    cout << "\nList after changing: " << endl;

    PrintList(head);

    system("pause>0");

    return 0;

}
