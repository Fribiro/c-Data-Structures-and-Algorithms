using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.LinkedList
{
    //this class will connect the node objects to create a linkedlist structure
    public class SimpleLinkedList
    {
        //start of the linked list
        Node head = null;
        public void Addlast(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            if ( head == null)
            {
               
                head = newItem;
                head.next = null;
            } else 
            {
                Node current =  head;

                //loop and find last elemnt then add after it
                while (current.next != null)
                {
                    current = current.next;
                }
                //if null then this is the last element
                current.next = newItem;
                newItem.next = null;
            }
        }
        public void AddFirst(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            //since this is the first item the current head becomes the next item
            // and this newItem becomes the head
            newItem.next = head;
            //this new item becomes h
            head = newItem;
        }
        public void ReadAll()
        {
            Node current = head;
            //loop until the last node
            while (current.next != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
                
            }
            Console.WriteLine(current.data);
        }
    }
}