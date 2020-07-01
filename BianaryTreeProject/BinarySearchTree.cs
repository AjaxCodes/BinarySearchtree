using System;
using System.Collections.Generic;
using System.ComponentModel;
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


        public void Add(int value) //100 -- 110 -- 115
        {
            Node node = new Node();
            node.value = value;


            if (rootNode == null)
            {
                rootNode = node;
            }
            else
            {
                Node temporaryNode = rootNode;
                while (true)
                {
                    if (rootNode != null && node.value >= temporaryNode.value)
                    {
                        if (temporaryNode.rightNode == null)
                        {
                            temporaryNode.rightNode = node;
                            break;
                        }
                        else
                        {

                            temporaryNode = temporaryNode.rightNode;
                        }
                    }
                    else if (temporaryNode.rightNode != null && rootNode.value <= temporaryNode.value)
                    {
                        if (temporaryNode.leftNode == null)
                        {
                            temporaryNode.leftNode = node;
                            break;
                        }
                        else
                        {
                            temporaryNode = temporaryNode.leftNode;

                        }

                    }

                }


            }



        }
        public void Search(int value)
        {
            Node node = new Node();
            node.value = value;
            Node currentNode = rootNode;

            while (true)
            {
                if (currentNode.rightNode.value == value)
                {
                    currentNode.rightNode = node;
                }
                else if (currentNode.leftNode.value == value)
                {
                    currentNode.leftNode = node;
                }
            }
            



             








            
        }
    }
}




            

                

             
                   
                     

                
                

            

       
