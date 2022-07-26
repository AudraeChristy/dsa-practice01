using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Console_Testing
{
    public class HashChain
    {
        public int HashTableSize;

        // each element of the array of the hash table will be a linked list.
        public LinkedList[] HashTable;

        public HashChain()
        {
            HashTableSize = 10; 
            HashTable = new LinkedList[HashTableSize];

            for (int i = 0; i < HashTableSize; i++)
            {
                HashTable[i] = new LinkedList(); // we are allocating memory here for the linked list/chains for each element of the has table.
            }
        }

        public int HashCode(int key)
        {
            // we will be computing the hashcode of this key.
            return key % HashTableSize; // compression hashing. where to insert this element into the hash table (linked list array)
        }

        public void Insert(int element)
        {
            int key = HashCode(element); // getting the index/key where to insert this element.
            HashTable[key].InsertSorted(element);
        }

        public bool Search(int key)
        {
            int i = HashCode(key); // the index of the hashtable that is storing the key or element we are trying to search.
            return HashTable[i].SearchElement(key) != -1; // search method of the linked list will return -1 if the element is not found.
        }

        public void Display()
        {
            for (int i = 0; i < HashTableSize; i++)
            {
                Console.WriteLine(HashTable[i]);
            }
        }
    }
}
