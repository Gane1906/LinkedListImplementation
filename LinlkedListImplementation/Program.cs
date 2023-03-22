using LinlkedListImplementation;
using System;
namespace LinkedListImnplementation
{
    public class Program
    {
        static void Main(String[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddNode(56);
            linkedList.AddNode(70);
            linkedList.Display();
            linkedList.InsertAtPosition(1, 30);
            linkedList.Display();
        }
    }
}