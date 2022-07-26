using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Testing
{
    public class Sorting
    {
        internal int[] SelectionSort(int[] array, int n)
        {
            // we select the first element in the array, and beginning at the second, we compare it to each other element in the array
            // int[] a = { 3, 2, 8, 9, 5, 2 };

            for (var i = 0; i < n; i++)
            {
                var smallest = i;

                for (var j = i + 1; j < n; j++)
                {
                    if (array[smallest] > array[j])
                    {
                        // SWAP
                        var temp = array[i]; // 3
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }

        public void Display(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + "");
            }

            Console.WriteLine();
        }

        internal void InsertionSort1(int[] a, int n)
        {
            // int[] a = { 3, 5, 9, 6, 8, 2 };
            // insertion sort is simply checking the number LEFT to the current number, and if left number is greater, then swap. 

            for (int i = 1; i < n; i++)
            {
                var temp = a[i]; // save current number in the temp variable. 
                var position = i; // save current index position in the position variable. 

                while
                    (position > 0 && a[position - 1] > temp) 
                    // while the current index > 0 AND the number to the left of the current number we're checking is greater than the number we're checking
                {
                    // swap

                    a[position] = a[position - 1]; // we get the value one left of the current value and assign it to that current position. 
                    position = position - 1; //  simply move the index over to the left.
                }

                a[position] = temp; // we take the original value we wanted to swap, and stick that in the new position value (previous)
            }
        }

        internal void InsertionSort2(int[] a, int n)
        {
            // 0  1   2  3  4  5
            // int[] a = { 3, 5, 9, 6, 8, 2 };
            //                <------------
            for (int i = 1; i < n; i++)
            {
                // create our variables.

                var currentValue = a[i]; // Current value that needs to be inserted into its proper position.
                var index = i; // current index in the array

                while (index > 0 && a[index - 1] > currentValue)
                {
                    // swap the current value with the previous.
                    a[index] = a[index - 1]; // { 3, 5, 9, 9, 8, 2 };          currentValue = 6;
                    index = index - 1;
                }

                a[index] = currentValue;
            }

        }

        internal void InsertionSort3(int[] a, int n)
        {
            //  0  1  2  3  4   5
            // int[] a = { 7, 5, 2, 9, 10, 3 };

            for (int i = 0; i < n; i++)
            {
                var currentValue = a[i];
                var position = i;

                while (position > 0 && a[position - 1] > currentValue)
                {
                    // swap current value with position
                    a[position] = a[position - 1];
                    position = position - 1;
                }

                a[position] = currentValue;
            }
        }

        public void HR_InsertionSort(int[] a, int n)
        {
            for (var i = 1; i < n; i++)
            {
                var temp = a[i];
                var index = i;

                while (index > 0 && a[index - 1] > temp)
                {
                    a[i] = a[index - 1];
                    index = index - 1;
                }

                a[index] = temp;
            }
        }

        public void BubbleSort(int[] a, int n)
        {
            // [ 0 2 5 21 5 ]
            // beginning at index 0, we compare the next number value (j+1), if the left (j) number is bigger, we swap.

            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        var temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }

        public void ShellSort(int[] a, int n)
        {
            // 0  1  2  3   4       first gap = 5/2 = 2
            // int[] a = { 3, 5, 8, 9, 6, 2 };

            // we start with the array and find the gap (middle)
            // 


            //initial gap is n/2 = HALF of the array.
            int rightNumberGap = n / 2;

            // Base case.
            while (rightNumberGap > 0) // 2 > 0
            {
                // we need another loop to compare one element with another
                int currentIndex = rightNumberGap; // 2     gap & i are the same here.

                while (currentIndex < n) // 2 < 5
                {
                    var
                        temp = a[currentIndex]; // we can compare and swap the elements with this variable. get current value at index gap                           temp = 3
                    var leftNumber =
                        currentIndex -
                        rightNumberGap; // used to compare the element at index 0 with the temp.                               (ex: j = 3-2 = 1) // simply looking back at the first number (round 1)
                    while
                        (leftNumber >= 0 &&
                         a[leftNumber] >
                         temp) // temp is holding the element that needs to be inserted at its proper position.  // if left number is greater than the temp (index gap) number
                    {
                        // If these conditions are true, we assign the element to the right.
                        a[leftNumber + rightNumberGap] = a[leftNumber];
                        leftNumber = leftNumber - rightNumberGap; // right number
                    }

                    a[leftNumber + currentIndex] = temp; // insert temp element in proper position
                    currentIndex = rightNumberGap / 2;
                }
            }
        }

        public void MergeSort(int[] a, int left, int right)
        {
            // because we're calling this recursively, we need to assign left and right variables in the calling method.
            //left = 0;
            //right = a.Length - 1; // we want the index, not the length.

            // 0  1  2  3   4       first gap = 5/2 = 2
            // int[] a = { 3, 5, 8, 9, 6, 2 };

            if (left > right)
            {
                var middle = (left + right) / 2;   // ex: L = 0, R = 5      

                MergeSort(a, left, middle); // recursively calling again, cutting the array in half every time.
            }

        }

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int p1 = m - 1;
            int p2 = n - 1;
            int i = m + n - 1;

            while (p2 >= 0)
            {
                if (p1 >= 0 && nums1[p1] > nums2[p2])
                {
                    nums1[i--] = nums1[p1--];
                }
                else
                {
                    nums1[i--] = nums2[p2--];
                }
            }

            for (int a = 0; a < nums1.Length; a++)
            {
                Console.WriteLine(nums1[a]);
            }
        }

        //public void QuickSort(int[] A, int low, int high)
        //{
        //    if(low < high)
        //    {
        //        int pi = partition;
        //    }
        //}
    }
}
