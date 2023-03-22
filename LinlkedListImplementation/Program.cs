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
            linkedList.AddNode(30);
            linkedList.AddNode(70);
            int position=linkedList.SearchElement(30);
            linkedList.InsertAtPosition(position+1, 40);
            linkedList.Display();
        }
    }
}