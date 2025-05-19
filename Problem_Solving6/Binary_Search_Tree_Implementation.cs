using System;
using System.Collections.Generic;

namespace BinaryTreeImplemetationExample
{
    public class BinarySearchTreeNode<T>
    {
        public T Value { get; set; }  

        public BinarySearchTreeNode<T> left { get; set; } 
        public BinarySearchTreeNode<T> right { get; set; }

        public BinarySearchTreeNode(T value)
        {
            Value = value;
            left = null;
            right = null;
        
        }
    }

    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public BinarySearchTreeNode<T> Root { get; private  set; }

        public BinarySearchTree() =>   Root = null;
        private void PrintBinaryTree(BinarySearchTreeNode<T> root, int space)
         {
            if (root == null) return;

            int count = 10;
            space += count;
            PrintBinaryTree(root.right, space);
            Console.WriteLine();
            for (int i = count; i < space; i++)
                Console.Write(" ");

            Console.WriteLine(root.Value);

            PrintBinaryTree(root.left, space);
         
         }

        public void PrintBinaryTree() => PrintBinaryTree(Root, 0);
        
        private void PreOrderTraversal(BinarySearchTreeNode<T> node)
        {
            /* Current - Left - Right  */

            if(node == null) return;
            Console.Write(node.Value+" ");
            PreOrderTraversal(node.left);
            PreOrderTraversal(node.right);
        }

        public void PreOrderTraversal()=>  PreOrderTraversal(Root);
        
        private void PostOrderTraversal(BinarySearchTreeNode<T> node)
        {
            /* Left-Right-Current  */
            if (node != null) return;
            PostOrderTraversal(node.left);
            PostOrderTraversal(node.right);
            Console.Write(node.Value + " ");
            

        }

        public void PostOrderTraversal() =>   PostOrderTraversal(Root);        

        private void InOrderTraversal(BinarySearchTreeNode<T> node)
        {
            /* Left - Current - Right */
            if (node == null) return;
            InOrderTraversal(node.left);
            Console.Write(node.Value + " ");
            InOrderTraversal(node.right);            

        }

        public void InOrderTraversal() => InOrderTraversal(Root);
        

        public bool IsGreater(T a, T b) => a.CompareTo(b) > 0;
        

        public void InsertBST(T value) =>  Root = InsertBST(Root, value);
        private BinarySearchTreeNode<T> InsertBST(BinarySearchTreeNode<T> root, T value)
        {
            if(root== null)
            {
                return new BinarySearchTreeNode<T>(value);

            }else if(IsGreater(value,root.Value))
            {
                root.right = InsertBST(root.right, value);

            }else if(IsGreater(root.Value, value))
            {
                root.left = InsertBST(root.left, value);
            }

            return root;
        }

        public bool Find(T value) => Find(Root, value);
        private bool Find(BinarySearchTreeNode<T> root, T value)
        {
            if(root == null ) 
                return false;
            if(root.Value.Equals(value)) 
                return true;
            bool isFound = false;
            if(IsGreater(value,root.Value)) 
                isFound = Find(root.right,value);
            else if(IsGreater(root.Value, value))  
                isFound = Find(root.left,value);

            return isFound;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {        
            var binarySearchTree = new BinarySearchTree<int>();
            Console.WriteLine("\nValues to be inserted: 45,15,79, 90, 10,55,12,20,50\n");

            binarySearchTree.InsertBST(45);
            binarySearchTree.InsertBST(15);
            binarySearchTree.InsertBST(79);
            binarySearchTree.InsertBST(90);
            binarySearchTree.InsertBST(10);
            binarySearchTree.InsertBST(55);
            binarySearchTree.InsertBST(12);
            binarySearchTree.InsertBST(20);
            binarySearchTree.InsertBST(50);
            binarySearchTree.PrintBinaryTree();
            Console.WriteLine("\nBST method: ");
            binarySearchTree.InOrderTraversal();

            Console.WriteLine();
            var SearchValue = 50;
            if (binarySearchTree.Find(SearchValue))
                Console.WriteLine($"the value {SearchValue} exist in the BinaryTree ");
            else
                Console.WriteLine($"the value {SearchValue} doesn't exist in the BinaryTree ");
            SearchValue = 35;
            if (binarySearchTree.Find(SearchValue))
                Console.WriteLine($"the value {SearchValue} exist in the BinaryTree ");
            else
                Console.WriteLine($"the value {SearchValue} doesn't exist in the BinaryTree ");

            Console.ReadKey();
        }
    }
}
