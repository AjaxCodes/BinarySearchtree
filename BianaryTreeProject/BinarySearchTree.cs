using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BianaryTreeProject
{
    public class BinarySearchTree
    {

        public Node rootNode;
        public int value;


        public void Add(Node leftNode, Node rightNode, Node newNode)
        {
            Node node = new Node();
            node.value = value;


            if (rootNode == null)
            {
                rootNode = node;
            }
            else
            {
                if (rootNode != null && node.value >= rootNode.value)
                {
                    node = leftNode;
                }
                else if (rootNode != null && node.value <= rootNode.value)
                {
                    node = rightNode;
                }

            }


            //create new node
            //check if rootNode is null. If so, make initial node the root
        }
        public Node Find(int value) 
        {

            Console.ReadLine();
            
            return this.Find(value);
            
        }
       
      


            





        



    }   
    
    
    
}
