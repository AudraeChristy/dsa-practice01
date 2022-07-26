using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Testing
{
    internal class QueuesArray
    {
        int[] data;
        int front;
        int back;
        int size;

        public QueuesArray(int n)
        {
            data = new int[n];
            front = 0;
            back = 0;
            size = 0;  // when created, index begins at 0
        }

        public int Length()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public bool IsFull()
        {
            return size == data.Length;
        }
        public void Enqueue(int e) // add to end
        {
            if (IsFull())
            {
               // print full
            }
            else
            {
                //add element to end.
                data[back] = e;
                back++;
                size++;
            }
        }

        public int Dequeue(int e) // remove front 
        {
            if (IsEmpty())
            {
                return -1;
            }
            else
            {
                var element = data[front];
                front = front + 1; // increment the front of the queue.
                size--;
                return element; 
            }
        }

        public int First()
        {
            if (IsEmpty())
            {
                return -1;
            }
            else
            {
                return data[front];
            }
        }
    }
}
