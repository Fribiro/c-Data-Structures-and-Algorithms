using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructuresAndAlgorithms.LinkedList;

namespace DataStructuresAndAlgorithms
{
    //this class represents a node in the linkedlist
    public class Program
    {
        static void Main(string[] args)
        {
            //less efficient due to the looping in attempt to reach the tail O(n)
            SimpleLinkedList lnk =  new SimpleLinkedList();
            lnk.Addlast("One");
            lnk.Addlast("Two");
            lnk.Addlast("3");
            lnk.Addlast("4");
            lnk.AddFirst("First");
            lnk.ReadAll();

            //more efficient O(1)
            SimpleLinkedListTail lnkTail =  new SimpleLinkedListTail();
            lnkTail.Addlast("One");
            lnkTail.Addlast("Two");
            lnkTail.Addlast("3");
            lnkTail.Addlast("4");
            lnkTail.AddFirst("First");
            lnkTail.ReadAll();

        }
    }
}