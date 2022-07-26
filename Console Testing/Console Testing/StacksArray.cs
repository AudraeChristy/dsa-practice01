using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Testing
{
    internal class StacksArray
    {
        // Need a stucture to represent Stacks data.
        int[] data;
        int top;

        public StacksArray(int n)
        {
            data = new int[n]; // 3:6  2:1  0:7 (top)
            top = 0; // top number always increases with the new element in the stack.
        }

        // Implement primitive methods of stacks ADT
        public int Length()
        {
            return top;
        }

        public bool IsEmpty()
        {
            return top == 0;
        }

        public bool IsFull()
        {
            return top ==  data.Length; // remember we initialize the length when we create array.
        }

        public void Push(int e)
        {
            if (IsFull())
                Console.WriteLine("Stack is Full.");
            else
            {
                data[top] = e;
                top++;
            }
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                return -1;
            }
            else
            {
                int e = data[top - 1]; // get the top element
                top = top - 1; // decrement the top index
                return e;
            }
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return data[top - 1];
        }


    }
}
