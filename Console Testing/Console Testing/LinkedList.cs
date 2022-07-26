using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Testing
{
    public class LinkedList
    {
        private Node head; // stores reference of first node.
        private Node tail; // stores reference of last node.
        private int size; // number of nodes in list.

        public LinkedList()
        {

        }

        public LinkedList(Node head, Node tail, int size)
        {
            head = null;
            tail = null;
            size = 0; // initially, the list will be empty (until a node is added)
        }

        public int Length()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        // Add element to list.
        public void AddLast(int e)
        {
            Node newest = new Node(e, null);

            if (IsEmpty())
            {
                head = newest; // if LL is empty, this will be the first node.
            }
            else
            {
                tail.next = newest;
            }

            tail = newest;
            size++;
        }

        public void AddFirst(int e)
        {
            Node newest = new Node(e, null);

            if (IsEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                newest.next = head; // memory address is now HEAD (remember, head holds the node / memory address)
                tail = newest;
            }

            size++;
        }

        public void AddAnywhere(int e, int position)
        {
            if (position <= 0 && position >= size)
            {
                Console.WriteLine("Invalid Position.");
                return;
            }

            Node newest = new Node(e, null);
            Node p = head;
            var i = 0;

            while (i < position - 1)
            {
                p = p.next; // assign head to the next node 0 --> 0 --> 0
                i++; // where we will be inserting the node in the linked list.
            }

            newest.next = p.next;  // adding the following (b) next/address to the NEXT of the new node.
            p.next = newest; // adding the value of the previous (a) node NEXT/address to the new node.
            size++;
        }

        public int RemoveLast()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty.");
                return -1;
            }

            // save the last node value in a variable so we can return it           
            Node p = head;
            var i = 0;

            // traverse the linked list to get to the last node.
            while (i < size - 1)
            {
                p = p.next;
                i++;
            }

            tail = p;

            // get element at the end of the list (now referenced with p)
            p = p.next;
            int e = p.element;
            tail.next = null;
            size--;

            return e;
        }

        public int RemoveAtPosition(int position)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty.");
                return -1;
            }

            // save the last node value in a variable so we can return it           
            Node p = head;
            var i = 1; // holds the count of how many nodes we will traverse.

            // traverse the linked list to get to the last node.
            while (i < position - 1)// we use position - 1 because we will be traversing until we hit this node.
            {
                p = p.next; //move head to the next node. we want object p to point to the node before the node we are deleting.
                i++; // increase the index of 'nodes' we're at.                 
            }

            // the previous node needs to point to p.next.next
            var e = p.next.element; // returning the removed node.
            p.next = p.next.next;
            size--;

            return e;
        }
        public int SearchElement(int element)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty.");
                return -1;
            }

            Node p = head;
            var i = 0;

            while (i < size - 1)
            {
                if (p.element == element)
                {
                    return i;
                }

                p = p.next;
                i++;
            }

            return -1;
        }

        public void InsertSorted(int element)
        {
            Node newest = new Node(element, null);

            if (IsEmpty())
            {
                head = newest;
            }
            else
            {
                Node p = head;
                Node q = head;

                while (p != null && p.element < element) // we're using this to search for the position that the element has to be inserted.
                {
                    q = p;
                    p = p.next;
                }
                // once its false, we've found the position.

                if (p == head) // if this is true, then the element we are inserting is smaller than all the elements in the linked list.
                {
                    newest.next = head;
                    head = newest;
                }
                else
                {
                    newest.next = q.next;
                    q.next = newest;
                }
            }

            size++;
        }


        public void Display()
        {
            Node p = head;

            while (p != null)
            {
                Console.Write(p.element + " --> ");
                p = p.next; // then move p to the next node so we can display it.
            }

            Console.WriteLine(); // this is to have the output on a separate line.
        }
    }

    public class Node
    {
        public int element;
        public Node next;
        public Node left;
        public Node right;

        public Node(int e, Node n)
        {
            element = e;
            next = n;
        }
    }
}
