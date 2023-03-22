using LinlkedListImplementation;
using System;
namespace LinkedListImnplementation
{
    public class Program
    {
        static void Main(String[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddReverseOrder(70);
            linkedList.AddReverseOrder(30);
            linkedList.AddReverseOrder(56);
            linkedList.Display();
        }
    }
}