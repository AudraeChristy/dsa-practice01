using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Testing
{
    internal class DEQueueLinkedList
    {
        public DEQueueNode front;
        public DEQueueNode back;
        private int size;

        public DEQueueLinkedList()
        {
            front = null;
            back = null;
            size = 0;
        }

        public int Length()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void AddLast(int e)
        {
            DEQueueNode newest = new DEQueueNode(e, null);

            if (IsEmpty())
            {
                front = newest;
                back = newest;
            }
            else
            {
                back.next = newest;
                back = newest;
            }

            //back = newest;
            size++;
        }

        public int RemoveFirst()
        {
            if (IsEmpty())
            {
                return -1;
            }

            var element = front.element;
            front = front.next;

            if (IsEmpty()) // since we removed an element, we need to check if its empty again so we can also update the tail to null. (both are set when we create one node)
            {
                back = null;
            }

            size--;
            return element;
        }

        public int RemoveLast()
        {
            if (IsEmpty())
            {
                return -1;
            }
            // we have to get to the node before the last to now set that as back.

            DEQueueNode p = front;
            int i = 0;

            while (i < size - 1)
            {                
                p = p.next;
                i++;
            }

            back = p;
            p = p.next; // gets the actual end node so we can save it into an element to return.

            int e = p.element;

            back.next = null; // make the NEW back node point to null.
            size--;

            return e;
        }
    }

    internal class DEQueueNode
    {
        public int element;
        public DEQueueNode next;

        public DEQueueNode(int e, DEQueueNode n)
        {
            element = e;
            next = n;
        }
    }
}
