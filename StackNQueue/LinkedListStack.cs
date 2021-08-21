using System;
using System.Collections.Generic;
using System.Text;

namespace StackNQueue
{
    class LinkedListStack
    {
        private Node top;
        public LinkedListStack()
        {
            this.top = null;
        }
        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack", value);
        }
        internal void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty !");
                return;
            }
            Console.WriteLine("{0} is in the top of the Stack : ", this.top.data);
        }


        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty, Deletion is not Possible !");
                return;
            }
            Console.WriteLine("Popped value : {0}", this.top.data);

            this.top = this.top.next;
        }

        internal void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }
        internal void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
