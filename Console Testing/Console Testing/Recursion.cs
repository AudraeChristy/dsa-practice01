using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Testing
{
    public class Recursion
    {
        public void CalculateHead(int n)
        {
            // Base Case
            if (n > 0)
            {
                CalculateHead(n - 1); // 4 -- 3 -- 2 -- 1  -- 0 -- goes back and processes the rest of the function. 
                var k = n * n;
                Console.WriteLine(k); // print out: 1, 4, 9, 16
            }
        }
        public void CalculateTail(int n)
        {
            // Base Case
            if (n > 0)
            {
                var k = n * n;
                Console.WriteLine(k);  // 16, 9 , 4 , 1

                CalculateTail(n - 1);
            }
        }

        public int CalculateSumRecursively(int n, int m)
        {
            int sum = n;
            if (n < m)
            {
                n++;
                return sum += CalculateSumRecursively(n, m);    // 1, 2, 3   -- 
            }
            return sum;
        }
        public int BinarySearchRecursion(int[] a, int key, int left, int right)
        {
            // L = 0
            // R = 4      [0][1][2][3][4]  
            // int[] a = { 1, 2, 4, 6, 10 };

            // sort array.
            Array.Sort(a);

            if (left > right) // key is not found.
            {
                return -1;
            }

            if (a.Length <= 0)
            {
                return -1;
            }

            // get middle of array (4)
            var middleIndex = (left + right) / 2;

            if (a[middleIndex] == key)
                return middleIndex;
            else if (key < a[middleIndex])
                return BinarySearchRecursion(a, key, left, middleIndex - 1);
            else if (key > a[middleIndex])
                return BinarySearchRecursion(a, key, middleIndex + 1, right);

            return -1;
        }

        public void ReverseString(char[] s)
        {
            // h e l l o 
            // 0 1 2 3 4
            Helper(0, s);
        }

        public void Helper(int index, char[] s) //    0   1   2   3   4 
        {
            if (s == null || index > s.Length - 1) // 4
                return;


            Helper(index + 1, s);
            Console.Write(s[index]);
        }
    }
}
