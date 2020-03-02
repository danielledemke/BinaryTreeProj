using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            Node masterNode = new Node(7);
            Node littleNode = new Node(5);
            tree.Add(masterNode);
            tree.Add(littleNode);
            Console.WriteLine(tree.root.value);
            bool test;
            test = tree.Search(5, tree.root);
            Console.WriteLine(test);
            Console.ReadLine();
        }
    }
}
