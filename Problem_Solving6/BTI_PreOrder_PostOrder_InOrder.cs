using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeImplemetationExample
{
    public class BinaryTreeNode<T>
    {
        public T Value { get; set; }  

        public BinaryTreeNode<T> left { get; set; } 
        public BinaryTreeNode<T> rigth { get; set; }

        public BinaryTreeNode(T value)
        {
            Value = value;
            left = null;
            rigth = null;
        
        }
    }

    public class BinaryTree<T> 
    {

        public BinaryTreeNode<T> Root { get; private  set; }

        public BinaryTree()
        {
            Root = null;
        }

        public void insert(T value)
        {

            var newNode = new BinaryTreeNode<T>(value);
            if (Root == null)
            {
                Root = newNode;
                return;
            }

            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(Root);
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                if (current.left == null)
                {
                    current.left = newNode;
                    break;
                }
                else
                {
                    queue.Enqueue(current.left);
                }

                if (current.rigth == null)
                {
                    current.rigth = newNode;
                    break;
                }
                else
                {
                    queue.Enqueue(current.rigth);
                }
            }
        }
         private void PrintTree(BinaryTreeNode<T> root, int space)
         {
            if (root == null) return;

            int count = 10;
            space += count;
            PrintTree(root.rigth, space);
            Console.WriteLine();
            for (int i = count; i < space; i++)
                Console.Write(" ");

            Console.WriteLine(root.Value);

            PrintTree(root.left, space);
         
         }

        public void PrintTree()
        {
            PrintTree(Root, 0);
        }

        private void PreOrderTraversal(BinaryTreeNode<T> node)
        {
            /* Current - Left - Right  */

            if(node == null) return;
            Console.Write(node.Value+" ");
            PreOrderTraversal(node.left);
            PreOrderTraversal(node.rigth);
        }

        public void PreOrderTraversal()
        {
            PreOrderTraversal(Root);
        }

        private void PostOrderTraversal(BinaryTreeNode<T> node)
        {
            /* Left-Right-Current  */
            if (node == null) return;
            PostOrderTraversal(node.left);
            PostOrderTraversal(node.rigth);
            Console.Write(node.Value + " ");
            

        }

        public void PostOrderTraversal()
        {
            PostOrderTraversal(Root);
        }

        private void InOrderTraversal(BinaryTreeNode<T> node)
        {
            /* Left - Current - Right */
            if (node == null) return;
            InOrderTraversal(node.left);
            Console.Write(node.Value + " ");
            InOrderTraversal(node.rigth);            

        }

        public void InOrderTraversal()
        {
            InOrderTraversal(Root);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var binaryTree = new BinaryTree<int>();
            Console.WriteLine("Values to be inserted: 5,3,8,1,4,6,9\n");

            binaryTree.insert(5);
            binaryTree.insert(3);
            binaryTree.insert(8);
            binaryTree.insert(1);
            binaryTree.insert(4);
            binaryTree.insert(6);
            binaryTree.insert(9);

            binaryTree.PrintTree();
            Console.WriteLine("PreOrderTraversal method: ");
            binaryTree.PreOrderTraversal();
            Console.WriteLine("\nPostOrderTraversal method: ");
            binaryTree.PostOrderTraversal();
            Console.WriteLine("\nInOrderTraversal method: ");
            binaryTree.InOrderTraversal();

            Console.ReadKey();
        }
    }
}
