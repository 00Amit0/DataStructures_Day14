using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresDemo
{
    internal class LinkedList
    {
        public Node head;
        //Method to Add Node in Linked List
        public void Add(int data)
        {
            Node newnode = new Node(data);
            //condition to Check head and add first Node.
            if (this.head == null)
            {
                this.head = newnode;
            }
            else
            {
                //Temp Node to reference to iterate through nodes & not lose or break node
                Node temp = head;
                //Loop to check next address in Node.
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newnode;
            }
            Console.WriteLine("inserted into node: " + newnode.data);
        }

        //Display Method to display the items from linked list
        public void Display()
        {
            Console.WriteLine("Display nodes of Linked List");
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine("Nodes are : " + temp.data);
                    temp = temp.next;
                }
            }
        }
        //Method to Add Node at First in Linked List
        public void AddFirst(int data)
        {
            Node newnode = new Node(data);
            newnode.next = head;
            head = newnode;
            Console.WriteLine("{0} : Nodes inserted in Linked list ", newnode.data);
        }

    }
}
