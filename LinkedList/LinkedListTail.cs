using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.LinkedList
{
    //this class will connect the node objects to create a linkedlist structure
    public class SimpleLinkedListTail
    {
        //start of the linked list
        Node head = null;
        Node tail = null;
        public void Addlast(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            if ( head == null)
            {
               
                head = newItem;
                tail = newItem;
            } else 
            {
               tail.next =  newItem;
               tail = newItem;
            }
        }
        public void AddFirst(object data)
        {
            Node newItem = new Node();
            newItem.data = data;

            if ( head == null)
            {
               
                head = newItem;
                tail = newItem;
            } else 
            {
               newItem.next = head;
               head = newItem;
            }
            
        }
        public void ReadAll()
        {
            Node current = head;
            
            while (current.next != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
                
            }
            Console.WriteLine(current.data);
        }
    }
}