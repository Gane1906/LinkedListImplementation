﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinlkedListImplementation
{
    public class LinkedList
    {
        internal Node head;
        internal void AddNode(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        public void AddReverseOrder(int data)
        {
            Node head;
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                this.head = newNode;
                this.head.next = temp;
            }
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();

        }
        public void InsertAtPosition(int position, int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
                this.head = newNode;
            if (position == 0)
            {
                newNode.next = head;
                head = newNode;
                return;
            }
            Node prev = null;
            Node current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newNode.next = prev.next;
            prev.next = newNode;
        }
        public void DeleteFirstNode()
        {
            if (this.head == null)
                Console.WriteLine("Linked list is empty");
            this.head = this.head.next;
        }
        public void DeleteLastNode()
        {
            if (this.head == null)
                Console.WriteLine("Linked list is empty");
            if (head.next == null)
                this.head = null;
            Node temp = this.head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            temp.next = null;
        }
        public int SearchElement(int data)
        {
            Node node = this.head;
            int position = 0, c = 0;
            while (node != null)
            {
                if (node.data.Equals(data))
                {
                    Console.WriteLine("The element " + data + " is found at " + position + " position");
                    return position;
                }
                node = node.next;
                position++;
            }
            return position;
        }
        public void DeleteParticularPosition(int position)
        {
            Node temp = this.head;
            if (position == 0)
            {
                this.head = temp.next;
                return;
            }
            for (int i = 0; i < position - 1 && temp.next != null; i++)
            {
                temp = temp.next;
            }
            if (temp == null || temp.next == null)
                return;
            Node next = temp.next.next;
            temp.next = next;
            Size();
        }
        public void Size()
        {
            int count = 0;
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine("The size of linkedlist is: " + count); 
        }
    }
}
