using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindOperationInTreeExample
{
    
    public class KokoNode<T>
    {
        public T NodeValue { get; set; }

        public List<KokoNode<T>> children { get; set; }

        public KokoNode(T value) 
        {
            this.NodeValue = value;
            this.children = new List<KokoNode<T>>();
        }

        public void AddChild(KokoNode<T> child)
        { 
            this.children.Add(child); 
        }

        public KokoNode<T> Find(T value)
        {
            if (EqualityComparer<T>.Default.Equals(this.NodeValue, value))
                return this;

            foreach (var node in this.children)
            {
                var found = node.Find(value);
                if (found != null)
                    return found;
            }

            return null;

        }

    }

    public class kokoRoot<T>
    {
        public KokoNode<T> Root { get; set; }

        public kokoRoot(T RootValue)
        {
            this.Root = new KokoNode<T>(RootValue);
        }

        public void Print(string indet="")
        {
            Print(Root, indet);
        }

        private void Print(KokoNode<T> currentNode, string indet="")
        {
            Console.WriteLine(indet+currentNode.NodeValue);

            foreach (var child in currentNode.children)
            {
                Print(child,indet+"  ");
            }
        }

        public KokoNode<T> Find(T value)
        {
           return Root?.Find(value);
        }

    }
    
    
    internal class Program
    {
        static void Main(string[] args)
        {

            // Creating the tree
            var CompanyTree = new kokoRoot<string>("CEO");
            var Finance = new KokoNode<string>("CFO");
            var Tech = new KokoNode<string>("CTO");
            var Marketing = new KokoNode<string>("CMO");

            // Adding departments to the CEO node
            CompanyTree.Root.AddChild(Finance);
            CompanyTree.Root.AddChild(Tech);
            CompanyTree.Root.AddChild(Marketing);

            // Adding employees to departments
            Finance.AddChild(new KokoNode<string>("Accountant"));
            Tech.AddChild(new KokoNode<string>("Developer"));
            Tech.AddChild(new KokoNode<string>("UX Designer"));
            Marketing.AddChild(new KokoNode<string>("Social Media Manager"));

            // Printing the tree
            CompanyTree.Print();

            Console.WriteLine("\nFinding Developer...");
            if (CompanyTree.Find("Developer") == null)
                Console.WriteLine("Not Found :-(");
            else
                Console.WriteLine("Found :-)");

            Console.WriteLine("\nFinding DBA...");
            if (CompanyTree.Find("DBA") == null)
                Console.WriteLine("Not Found :-(");
            else
                Console.WriteLine("Found :-)");

            Console.ReadKey();



        }
    }
}

/*
 
 public class TreeNode<T>
    {
        public T NodeValue { get; set; }
        public List<TreeNode<T>> Children { get; set; }

        public TreeNode(T nodevalue)
        {
            this.NodeValue = nodevalue;
            this.Children = new List<TreeNode<T>>();
        }

        public void AddChild(TreeNode<T> node)
        {
            this.Children.Add(node);
        }

        public TreeNode<T> Find(T value)
        {
            if (EqualityComparer<T>.Default.Equals(this.NodeValue,value))
                return this;

            foreach (var child in Children)
            {
                var found = child.Find(value);
                if (found != null) return found;
            }

            return null;

        }
    }

     public class Tree<T>
        {
            public TreeNode<T> Root { get; set; } 
            public Tree(T Rootvalue)
            {
                this.Root = new TreeNode<T> ( Rootvalue);
            }

            public void PrintTree(string indet=" ")
            {
                printNode(this.Root,indet);
            }
            private void printNode(TreeNode<T> node,string indet="") 
            {
                Console.WriteLine(indet + node.NodeValue);
                foreach(var child in node.Children)
                {
                    printNode(child, indet+" ");
                }
            }

            public TreeNode<T> Find(T value)
            {
                return Root?.Find(value);
            }


        }
 */