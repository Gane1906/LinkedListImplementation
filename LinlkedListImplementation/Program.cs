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
            linkedList.Display();
            linkedList.DeleteFirstNode();
            linkedList.Display();
        }
    }
}