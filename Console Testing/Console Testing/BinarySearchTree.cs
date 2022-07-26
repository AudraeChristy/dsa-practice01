using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Testing
{
    public class iNode
    {
        public int element;
        public iNode left;
        public iNode right;

        public iNode(int e, iNode l, iNode r)
        {
            element = e;
            left = l;
            right = r;
        }
    }

    public class BinarySearchTree
    {
        public iNode root;

        public BinarySearchTree()
        {
            root = null; // initially the BST will be empty.
        }

        public void Insert(iNode tempRoot, int e)
        {
            iNode temp = null;

            while(tempRoot != null)
            {
                temp = tempRoot;

                if (e == tempRoot.element)
                {
                     // return: we cannot have duplicate elements in the binary search tree.
                }
                else if (e < tempRoot.element)
                {
                    tempRoot = tempRoot.left;
                }
                else if (e > tempRoot.element)
                {
                    tempRoot = tempRoot.right;
                }
            }

            // once while loop is done with execution, we have found the place to insert our element.

            // we create our new node
            var n = new iNode(e, null, null);

            if(root != null)
            {
                if (e < temp.element) // if element we want to insert is less that the current element, we add it to the left child. otherwise, add it to right child.
                {
                    temp.left = n;
                }
                else
                {
                    temp.right = n;
                }
            }
            // if the root is null = binary search tree is empty. so we create a new node.
            else
            {
                root = n;
            }
        }

        public void InOrder(iNode tempRoot) // Binary Search Tree Recursive Search.
        {
            if (tempRoot != null) // if true, this means the subtree has nodes.
            {
                InOrder(tempRoot.left);
                Console.WriteLine(tempRoot.element + " ");
                InOrder(tempRoot.right);
            }
        }

        public iNode InsertRecursively(iNode tempRoot, int e)
        {
            if (tempRoot != null)
            {
                if (e < tempRoot.element)
                {
                    tempRoot.left = InsertRecursively(tempRoot.left, e);
                }
                else if (e > tempRoot.element)
                {
                    tempRoot.right = InsertRecursively(tempRoot.right, e);
                }
            }
            else
            {
                var n = new iNode(e, null, null);
                tempRoot = n; // assigning the new node to the tempRoot
            }

            return tempRoot;// return the reference of the new node.
        }
    }
}
