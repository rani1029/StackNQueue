using System;

namespace StackNQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack list = new LinkedListStack();
            list.Push(70);
            list.Push(30);
            list.Push(56);
            list.Display();
            list.IsEmpty();
        }
    }
}
