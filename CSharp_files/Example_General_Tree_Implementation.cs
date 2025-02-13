using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralTreeImplementationExample
{

    public class TreeNode<T>
    {
        public T value { get; set; }

        public List<TreeNode<T>> children { get; set; }

        public TreeNode(T value)
        {
            this.value = value;
            this.children = new List<TreeNode<T>>();

        }

        public void addChild(TreeNode<T> child)
        {
            this.children.Add(child);
        }
    }

    public class Tree<T>
    {
        public TreeNode<T> Root { get; private set; }

        public Tree(T value)
        {
            this.Root = new TreeNode<T>(value);
        }
    }
    
    public class Program
    {
        static void Main(string[] args)
        {
            var companyTree = new Tree<string>("CEO");
            var finance = new TreeNode<string>("CFO");
            var tech = new TreeNode<string>("CTO");
            var sales = new TreeNode<string>("CMO");

            companyTree.Root.addChild(finance);
            companyTree.Root.addChild(tech);
            companyTree.Root.addChild(sales);

            finance.addChild(new TreeNode<string>("Account"));
            tech.addChild(new TreeNode<string>("Develpper"));
            tech.addChild(new TreeNode<string>("Designer UI"));
            sales.addChild(new TreeNode<string>("sales"));

            Print(companyTree.Root);            

            Console.ReadLine();

        }

        private static void Print(TreeNode<string> root, string indet ="")
        {
            Console.WriteLine(indet+root.value) ;
            foreach (var node in root.children)
            {
                Print(node, indet + " ");
            }
        }
    }
}
