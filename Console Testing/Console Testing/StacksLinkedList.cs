using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Testing
{
    public class StacksLinkedList
    {
        LLNode top;
        LLNode tail;
        int size;

        public StacksLinkedList()
        {
        }
        public StacksLinkedList(LLNode head, LLNode tail)
        {
            top = head;
            tail = tail;
            //size = 0;  // initially, the list will be empty (until a node is added)
        }

        public void Push(int e) // no loops, time complexity = O(1)
        {
            var newest = new LLNode(e, null);

            if (IsEmpty())
            {
                top = newest;
                tail = newest;                
            }
            else
            {
                newest.next = top;
                top = newest;
            }

            size++;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                return -1;
            }
            else
            {
                // remove top item
                var element = top.element;
                top = top.next;
                size--;

                // return the top item.
                return element;
            }
        }

        public bool IsEmpty()
        {
            return size == 0;
        }
    }

    public class LLNode
    {
        public int element;
        public LLNode next;

        StacksLinkedList data = null;

        public LLNode(int e, LLNode n)
        {
            element = e;    
            next = n;
        }
    }
}
