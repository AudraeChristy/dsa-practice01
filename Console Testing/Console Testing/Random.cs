using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleTesting
{
    public class RandomLeetCode
    {
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

            public ListNode MergeTwoLists(ListNode list1, ListNode list2)
            {
                if (list1 == null) return list2;
                if (list2 == null) return list1;

                if (list1.val <= list2.val)
                {
                    list1.next = MergeTwoLists(list1.next, list2);
                    return list1;
                }
                if (list2.val < list1.val)
                {
                    list2.next = MergeTwoLists(list1, list2.next);
                    return list2;
                }

                return null;
            }
            public bool IsSubsequence(string s, string t)
            {
                /*
                 var s = "abc";
                var t = "ajblci";
                */

                //var isSub = false;
                var temp = 0;
                var i = 0;
                var amountNeededToMatch = s.Length; // need to match 3 letters.
                var amountMatched = 0;

                if (s[0] != t[0] && s.Length == t.Length)
                {
                    return false;
                }

                for (i = 0; i < s.Length; i++)
                {
                    for (var j = temp; j < t.Length; j++)
                    {
                        if (s[i] == t[j])
                        {
                            temp = ++j; // save the current j when it got into the loop so we can start indexing from there.
                            amountMatched++;
                            break;
                        }
                    }
                }

                if (amountNeededToMatch == amountMatched)
                {
                    return true;
                }

                return false;
            }
        }
        public class NotesStore
        {
            public IList<Note> NoteList { get; set; }

            private List<string> validStateList = new List<string>
            {
                "completed",
                "active",
                "others"
            };

            public NotesStore()
            {
                NoteList = new List<Note>();
            }

            public void AddNote(String state, String name)
            {

                if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }

                if (!validStateList.Contains(state))
                {
                    throw new ArgumentNullException($"Invalid state {state}");
                }

                var note = new Note(state, name);
                NoteList.Add(note);
            }

            public List<String> GetNotes(String state)
            {
                if (!validStateList.Contains(state))
                {
                    throw new ArgumentNullException($"Invalid state {state}");
                }

                var item = NoteList.Select(x => x.State == state).ToList();
                return null;
            }
        }

        public class Note
        {
            internal string State { get; set; }
            internal string Name { get; set; }

            public Note(string state, string name)
            {
                State = state;
                Name = name;
            }
        }

        //public class Solution

        //{
        //    public static void Main()
        //    {
        //        var notesStoreObj = new NotesStore();
        //        var n = int.Parse(Console.ReadLine());
        //        for (var i = 0; i < n; i++)
        //        {
        //            var operationInfo = Console.ReadLine().Split(' ');
        //            try
        //            {
        //                if (operationInfo[0] == "AddNote")
        //                    notesStoreObj.AddNote(operationInfo[1], operationInfo.Length == 2 ? "" : operationInfo[2]);
        //                else if (operationInfo[0] == "GetNotes")
        //                {
        //                    var result = notesStoreObj.GetNotes(operationInfo[1]);
        //                    if (result.Count == 0)
        //                        Console.WriteLine("No Notes");
        //                    else
        //                        Console.WriteLine(string.Join(",", result));
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Invalid Parameter");
        //                }
        //            }
        //            catch (Exception e)
        //            {
        //                Console.WriteLine("Error: " + e.Message);
        //            }
        //        }
        //    }
        //}
    }