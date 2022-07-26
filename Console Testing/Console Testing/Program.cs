using System;
using Console_Testing;

namespace ConsoleTesting // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        
            public static void ReverseString(char[] s)
            {
                // h e l l o 
                // 0 1 2 3 4
                Helper(0, s);
            }

            public static void Helper(int index, char[] s) // hello ---> 
            {
                if (s.Length <= 1 || index > s.Length - 1)
                {
                    return;
                }
                //Console.Write(s[index]); // 0 = h
                index++; // index = 1
                Helper(index, s); // 0, "h e l l o"   h   e   l   l   o         
                Console.Write(s[index - 1]);  // print out current index (0) of string / char[]. - H
            }
        

        /*
        we get passed a string into our array

        our base case: if the string < 1 character, return/end.

        else
        print one character (h) or length - 1 (o)
        recurivecall() 
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var send = new char[] { 'h', 'e', 'l', 'l', 'o' };
            ReverseString(send);

        /*
        we get passed a string into our array

        our base case: if the string < 1 character, return/end.

        else
        print one character (h) or length - 1 (o)
        recurivecall() 
        */

        #region Recursion
        //var r = new Recursion();
        //r.CalculateHead(4); 
        //r.CalculateTail(4);
        //Console.ReadLine();

        //int[] a = { 1, 4, 2, 6, 10 };
        //var indexOfKey = r.BinarySearchRecursion(a, 2, 0, a.Length - 1);

        //int sum = r.CalculateSumRecursively(1, 3);
        //Console.WriteLine(sum);
        #endregion

        #region Sorting
        //int[] a = { 3, 5, 8, 9, 5, 2 };
        //int n = a.Length;
        //var sorting = new Sorting();
        //Console.WriteLine("Original Array: ");
        //sorting.Display(a, n);
        //sorting.SelectionSort(a, n);
        //Console.WriteLine("Sorted Array: ");
        //sorting.Display(a, n);

        //int[] a = { 3, 5, 9, 6, 8, 2 };
        //int[] a = { 3, 5, 9, 6, 8, 2 };
        //int n = a.Length;
        //var sorting = new Sorting();
        //Console.WriteLine("Original Array: ");
        //sorting.Display(a, n);
        //sorting.HR_InsertionSort(a, n);
        //Console.WriteLine("Sorted Array: ");
        //sorting.Display(a, n);


        //int n = 5;

        //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        //Result.insertionSort1(n, arr);



        //// Bubble Sort
        //var sorting = new Sorting();
        //int[] a = {2, 5, 3, 30, 20};
        //sorting.Display(a, a.Length);
        //sorting.BubbleSort(a, a.Length);
        //Console.WriteLine("Sorted Array: ");
        //sorting.Display(a, a.Length);


        // Shell Sort
        //var sorting = new Sorting();
        //int[] a = { 3, 5, 8, 9, 6, 2 };
        //sorting.Display(a, a.Length);
        //sorting.ShellSort(a, a.Length);
        //Console.WriteLine("Sorted Array: ");
        //sorting.Display(a, a.Length);


        //var sorting = new Sorting();
        ////int[] a = { 1,2,3,0,0,0};
        ////int[] b = { 2,5,6 };
        //////sorting.Display(a, a.Length);

        ////sorting.Merge(a, a.Length, b, 3);
        ////Console.WriteLine("Sorted Array: ");

        ////sorting.Merge(a, a.Length, b, 3);


        //int[] a = {1, 2, 3, 0, 0, 0};
        //var m = 3;
        //int[] b = { 2, 5, 6 };
        //var n = 3;

        //sorting.Merge(a, m, b, n);

        #endregion

        #region LinkedList
        LinkedList l = new LinkedList();
            l.AddLast(7);
            l.AddLast(4);
            l.AddLast(12);
            l.Display();
            #endregion

            #region Binary Search Tree

            BinarySearchTree binarySearchTree = new BinarySearchTree();

            // Iterative
            binarySearchTree.Insert(binarySearchTree.root, 50);
            binarySearchTree.Insert(binarySearchTree.root, 40);
            binarySearchTree.Insert(binarySearchTree.root, 10);
            binarySearchTree.Insert(binarySearchTree.root, 60);
            binarySearchTree.Insert(binarySearchTree.root, 80);
            binarySearchTree.Insert(binarySearchTree.root, 30);
            binarySearchTree.Insert(binarySearchTree.root, 20);
            Console.WriteLine("Inorder Traversal");
            binarySearchTree.InOrder(binarySearchTree.root);
            Console.WriteLine();


            // Recursive

            #endregion
            //CompareStringConstants();

            //var random = new Random();
            //var result = random.LengthOfLongestSubstring("abcabcbb");

            //int[] int1 = { 2 };
            ////int[] int2 = { 3, 4 };
            //int[] int2 = { };
            //var dbl = random.FindMedianSortedArrays(int1, int2);

            // var recursion = new Recursion();
            //var charArray = new char[] { 'h', 'e', 'l', 'l', 'o' };
            //recursion.ReverseString(charArray);

            var leetCode = new RandomLeetCode();
            var s = "bb";
            var t = "ahbgdc";
            leetCode.IsSubsequence(s, t);

            Console.ReadKey();


            var ex = new Extra();
            ex.IsHappy(19);
        }

        //public static void CompareStringConstants()
        //{
        //    string str1 = "";
        //    string str2 = string.Empty;
        //    string str3 = String.Empty;
        //    string str4 = null;

        //    Console.WriteLine(object.ReferenceEquals(str1, str2)); //prints True
        //    Console.WriteLine(object.ReferenceEquals(str2, str3)); //prints True

        //    Console.WriteLine(object.ReferenceEquals(str2, str4)); //prints True

        //     str4 = "hello";

        //    Console.WriteLine(str4); //prints True


        //    try
        //    {
        //        var token = _binaryReader.ReadByte();

        //        switch ((Types)token.Value)
        //        {
        //            case Types.kBeginDenseJSArray:
        //            case Types.kBeginJSObject:
        //                node = GetNode(parent, token);
        //                break;
        //            case Types.kOneByteString:
        //            case Types.kTwoByteString:
        //            case Types.kDouble:
        //            case Types.kFalse:
        //            case Types.kTrue:
        //            case Types.kInt32:
        //            case Types.kVersion:
        //            case Types.kObjectReference:
        //            case Types.kUndefined:
        //                var valueSource = GetValueSource(token);
        //                if (valueSource == null)
        //                {
        //                    return parent;
        //                }

        //                if (isKey)
        //                {
        //                    node.SetKey(valueSource.Value.ToString());
        //                    node.SetKeySource(valueSource.Source);
        //                }
        //                else
        //                {
        //                    node.SetValueAndSource(valueSource);
        //                }

        //                break;
        //            case Types.kEndJSObject:
        //                _binaryReader.ReadVarint();
        //                return new V8ValuesDeserializerNode(Types.kEndJSObject, null, "end_js");
        //            case Types.kPadding:
        //                return BuildTree(parent, isKey);
        //        }

        //        return node;
        //    }
        //    catch (DataFormatParserException)
        //    {
        //        return node;
        //    }


        //}
    }
}

public class Extra
{
    public bool IsHappy(int n)
    {
        List<int> seen = new List<int>();

        while (n != 1 && !seen.Contains(n))
        {
            seen.Add(n);
            n = getNext(n);
        }

        return n == 1;
    }

    private int getNext(int n)
    {
        int totalSum = 0;
        while (n > 0)
        {
            int d = n % 10;
            n = n / 10;
            totalSum += d * d;
        }
        return totalSum;
    }
}


 public class ListNode
{
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
             }
  }

public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        // first traverse the list to find the end.
        //var temp = head;
        //ListNode tail;

        while (head != null)
        {
            // this will get each head node.
            ReverseList(head.next);

            if (head.next == null)
            {
                return head;
            }
        }

        return head;
    }
}

public class TestingMore
{
    public int BinarySearch()
    {
        int[] arrayInts = new int[] { 1, 3, 6, 8, 9, 10 };
        var key = 3;

        int recursive = BinarySearchHelper(arrayInts, key, 0, arrayInts.Length - 1);
        
        // Iterative
        var left = 0;
        var right = arrayInts.Length - 1;

        while (left < right)
        {
            var mid = (left + right) / 2;

            if (key == mid)
            {
                return mid;
            }
            else if (key < arrayInts[mid])
            {
                right = mid - 1;
            }
            else if (key > arrayInts[mid])
            {
                left = mid + 1;
            }
        }

        return -1;
    }

    private int BinarySearchHelper(int[] A, int key, int left, int right)
    {
        if (left > right)
        {
            return -1;
        }
        // cut array in half and check if key is less than or greater than middle.
        var mid = (left + right) / 2;

        if (key == mid)
            return A[mid];
        if (key < A[mid])
        {
            return BinarySearchHelper(A, key, left, mid - 1);
        }

        if (key > A[mid])
        {
            return BinarySearchHelper(A, key, mid + 1, right);
        }

        return -1;
    }
}