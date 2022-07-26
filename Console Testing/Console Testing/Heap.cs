using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Testing
{
    internal class Heap
    {
        int[] data;
        int maxSize;
        int cSize;

        public Heap()
        {
            maxSize = 10;
            data = new int[maxSize]; // data array will be initialized the same size as max size.
            cSize = 0;

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = -1;
            }
        }

        public int Length()
        {
            return cSize;
        }
        
        public bool IsEmpty()
        {
            return cSize == 0;
        }

        
        public void Insert(int element)
        {
            // insert an element in the heap
            // heap = complete binary tree meaning no gaps. must meet the relational and structural requirements.

            int currentIndex = cSize;

            // to find parent: currentIndex/cSize / 2
            if (cSize == maxSize)
                Console.WriteLine("Heap is full.");

            while (currentIndex > 1 && element > data[cSize / 2])
            {
                var parentNode = data[currentIndex / 2];

                // save the parent node value into the 'current index' value.
                data[currentIndex] = data[parentNode];

                // update the current index we now want to insert our new element into to the parent node INDEX.
                currentIndex = parentNode;
            }
            
            // save new element in the parent node.
            data[currentIndex] = element;
            cSize++;
        }

        public int DeleteMax()
        {

            if (IsEmpty())
            {
                Console.WriteLine("Heap is empty.");
                return -1;
            }
            // delete root of heap. 
            var e = data[1]; // saving first/root element into the variable e.

            // assigning the last element of the heap into the root of the binary tree.
            data[1] = data[cSize];

            // removing the value of the last element
            data[cSize] = -1;  // dont write 0, do -1 instead.

            // update size of heap.
            cSize--;

            // get index of the parent node.
            int i = 1;

            // get index of their ^ child node
            int child = i * 2;

            // while

            while(child < cSize) // while the child node index is LESS than the length of the heap.
            {
                if(data[child] < data[child + 1]) // checking which child is greater. if this is true, that means the right child > left child.
                {
                    child = child + 1; // right child is greater than the left child.
                }

                if (data[i] < data[child]) // if the value of the parent node is less than the child *which will now be the larger child because of the above logic. we are swapping to maintain the relational property in the heaps.
                {
                    var temp = data[i];
                    data[i] = data[child];
                    data[child] = temp;

                    /// These statements are used to move to the next level of indices in the binary tree.
                    i = child; // assign the new parent to the child index.
                    child = child * 2;
                }
                else
                {
                    break; // if the parent node > child node, we dont need to perform down heap bubbling.
                }
            }

            return e;
        }

        public void HeapSort(int[] arr, int n)
        {
            var heap = new Heap();

            for(var i = 0; i < n; i++)
            {
                heap.Insert(arr[i]); // insert all elements into the heap.
            }

            var k = n - 1; // k will be the index of the array, we will traverse this backwards.

            // add the elements from the heap into the array.

            for (int i = 0; i < heap.cSize; i++) 
            {
                arr[k] = heap.DeleteMax(); // we will delete the largest element from the heap, and save it into the last spot (going left) into the array.
                k = k - 1; // keep moving left.
            }
        }
    }
}
