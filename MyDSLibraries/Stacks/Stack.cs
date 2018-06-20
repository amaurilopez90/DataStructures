using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;
using DSInterfaces;

namespace Stacks
{
    /*Note to self 
     
         When you want to implement other Stacks
         create classes for them just like you did here
         under the Stacks namespace
         */

    public class Stack<T> : IStack<T> {

        //Set up a Node class
        public class Node {

            private T _data;
            private Node _next;

            //Getters and setters for both data and next node
            public T Data { get { return this._data; } set { this._data = value; } }
            public Node Next { get { return this._next; } set { this._next = value; } }

            //Constructor
            public Node(T value, Node next = null)
            {
                this._data = value;
                this._next = next;
            }
        }

        //Start Stack class
        private Node top;
        private int _size;

        public Stack()
        {
            this.top = null;
            this._size = 0;
        }

        public int GetSize()
        {
            return this._size;
        }

        public void Push(T value)
        {
            Node temp = new Node(value, this.top);
            this.top = temp;
            this._size++;
        }

        public T Pop()
        {
            T value = default(T);
            if (!this.IsEmpty())
            {
                value = this.top.Data;
                this.top = this.top.Next;
                this._size--;
            }
            else
            {
                Debug.WriteLine("Nothing to pop.");

            }

            return value;
        }

        public bool IsEmpty()
        {
            return this._size == 0;
        }

        public T Peek()
        {

            if (!this.IsEmpty())
                return this.top.Data;
            else
            {
                Debug.WriteLine("Nothing to peek.");
                return default(T);
            }
        }

        public void Clear()
        {
            //Lose the reference to the top node
            this.top = null;
            this._size = 0;
        }

    }
}
