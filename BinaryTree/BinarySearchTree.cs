using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
   public class BinarySearchTree
    {
        //member variables
       public Node root;
       private bool isNodeFound;

        public bool IsNodeFound
        {
            get
            {
                return isNodeFound;
            }
        }

        //constructor
        public BinarySearchTree()
        {

        }

        //member methods
        public void Add(Node node)
        {
            node = new Node(node.value);

            if(root == null)
            {
                root = node;
            }
            else
            {
                Node current;
                Node temp;
                bool isValid = true;
               
                while(isValid)
                {
                    current = root;
                    temp = current;

                    if(node.value < current.value)
                    {
                        current = current.leftChild;
                        if(current == null)
                        {
                            temp.leftChild = node;
                            break;
                        }
                        else
                        {
                            current = current.rightChild;
                            if (current == null)
                            {
                                temp.rightChild = node;
                                break;
                            }   
                        }
                    }

                    
                }

            }
                 
        }
        public bool Search(int value, Node root)
        {
            if(root == null)
            {
                Console.WriteLine("Error");
            }
             if(value == root.value)
            {
                isNodeFound = true;
                return isNodeFound;
            }
             if(value < root.value)
            {
                return Search(value, root.leftChild);
            }
             else if(value > root.value)
            {
                return Search(value, root.rightChild);
            }
            else
            {
                return false;
            }
            


        }

    }
}
