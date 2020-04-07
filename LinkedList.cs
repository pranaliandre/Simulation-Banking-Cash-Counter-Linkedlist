using System;
using System.Collections.Generic;
namespace SimulateBaking
{
    /// <summary>
    /// Create a node
    /// </summary>
    public class Node
    {
        public int data;// declaring a variable
        public Node next;// referance to next node
    }

    public class LinkedList
    {
        Node head; // reference to first node

        /// <summary>
        /// Method to balance store in linkedlist 
        /// </summary>
        /// <param name="balance">balance deposit</param>
        public void insert(int balance)
        {
            Node newNode = new Node();
            newNode.data = balance;
            newNode.next = null;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }

        /// <summary>
        /// Method to remove the balance from linklist
        /// </summary>
        public void remove()
        {
            Node temp = head.next;

            head = temp;
        }

        /// <summary>
        /// Method to display the cash in linklist
        /// </summary>
        public void displayLinkedlist()
        {
            Node n = head;
            while (n.next != null)
            {
                Console.WriteLine(n.data);
                n = n.next;
            }
            Console.WriteLine(n.data);
        }
    }
}
