namespace Console_Testing
{    
    internal class QueuesLinkedList
    {
        QNode front;
        QNode end;
        int size;

        public QueuesLinkedList()
        {

        }
        public QueuesLinkedList(QNode head, QNode tail)
        {
            front = head;
            end = tail;
            size = 0;
        }

        public bool IsEmpty() // we can keep "adding", we dont need to check if it's full. this isnt an immutable array.
        {
            return size == 0;
        }

        public int Length() // we can keep "adding", we dont need to check if it's full. this isnt an immutable array.
        {
            return size;
        }

        public void Enqueue(int e) // add to end O(1)
        {
            var newest = new QNode(e, null);

            if (IsEmpty())
            {
                front = newest;
                end = newest;
            }
            else
            {
                end.next = newest; // assign the NEXT property of last node to point to the new node.
                end = newest;      // now assing the END QNode to our newest node.
            }
            
            size++;
        }
        public int Dequeue() // remove at front         O(1)
        {
            if (IsEmpty())
                return - 1;            
            
            var temp = front.element;
            front = front.next;
            size--;

            if (IsEmpty())
                end = null; // if we remove the last element of the queue and it's empty, we want the end QNode to equal null. without this assignment, end would still be pointing to this element.

            return temp;
        }

        public int First() //   O(1)
        {
            if (IsEmpty())
            {
                return -1;
            }
            // enqueue = adding to end
            // dequeue = removing first

            return front.element;
        }
    }

    internal class QNode
    {
        public int element;
        public QNode next;

        public QNode(int e, QNode n)
        {
            element = e;
            next = n;
        }
    }
}
