using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
   public class Node
    {
        //member variables
      public int value;
      public  Node rightChild;
      public  Node leftChild;
        public Node parent;

        //constructor
        public Node(int value)
        {
            this.value = value;
        }

        //member methods

       
    }
}
