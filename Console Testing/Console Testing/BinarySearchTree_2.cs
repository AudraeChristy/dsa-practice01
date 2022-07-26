using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Testing
{
    public class BNode
    {
        public int element;
        public BNode left;
        public BNode right;

        public BNode(int e, BNode l, BNode r)
        {
            element = e;
            left = l;
            right = r;
        }
    }
    public class BinarySearchTree_2
    {
        // Every BST has a root.
        BNode root;

        public BinarySearchTree_2()
        {
            root = null; // when we create a BST, we have to set the root to null.
        }

        public void Insert(BNode tempRoot, int e) // Iterative.
        {
            BNode temp = null;
            // traverse the tree in order to find out where to insert. 
            while (tempRoot != null)
            {
                temp = tempRoot;
                if (e == tempRoot.element)
                    return;
                if (e < tempRoot.element)
                {
                    tempRoot = temp.left;
                }
                if (e > tempRoot.element)
                {
                    tempRoot = tempRoot.right;
                }
            }
            BNode n = new BNode(e, null, null);
            if (root != null)
            {
                if (e < temp.element)
                {
                    temp.left = n;
                }
                else
                {
                    temp.right = n;
                }
            }
            else
            {
                root = n;
            }
        }

        public void InOrder(BNode tempRoot)  //  a+b        5   4   3         
        {
            if (tempRoot != null)
            {
                InOrder(tempRoot.left);  // calling to print left root below   6   8    
                Console.Write(tempRoot.element); // element here is the root value.
                InOrder(tempRoot.right); // once the left is called, 
            }
        }

        public void PreOrder(BNode tempRoot) // +ab
        {
            if (tempRoot != null)
            {
                Console.WriteLine(tempRoot.element + " "); // print root // then it will pritn left, then it will print right
                PreOrder(tempRoot.left);
                PreOrder(tempRoot.right);   
            }
        }

        public void PostOrder(BNode tempRoot) // ab+
        {
            if (tempRoot != null)
            {
                PostOrder(tempRoot.left);
                PostOrder(tempRoot.right);
                Console.WriteLine(tempRoot.element + " "); 
            }
        }

        public void LevelOrder(BNode temp) // a
        {
            // create queue.
            var q = new Queue<BNode>();

            // save root in temp variable.
            var tempRoot = temp; // a
            Console.Write(temp.element); // a
            q.Enqueue(temp);

            while(q.Count > 0) // everything we print, we add to the queue right after.
            {
                // | - | - | - | - | - | g |
                tempRoot = q.Dequeue(); // grab queued item. = d                                       a  b  c  d  f  g                            
                // check for left child
                if (tempRoot.left != null) // null
                {
                    Console.WriteLine(tempRoot.left.element);  // f
                    q.Enqueue(tempRoot.left); // 
                }
                if (tempRoot.right != null)  // null
                {
                    Console.Write(tempRoot.right.element);
                    q.Enqueue (tempRoot.right);
                }

                IList<int> rootList = new List<int>
                {
                    tempRoot.element
                };


        }
    }
    }
}
