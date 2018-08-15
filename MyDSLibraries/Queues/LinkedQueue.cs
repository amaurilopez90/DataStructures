using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using DSInterfaces;

namespace Queues
{
    /*Note to self 
     
         When you want to implement other Queues
         create classes for them just like you did here
         under the Queues namespace
         */

    public class LinkedQueue<T> : IQueue<T>
    {
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

        //Queue class starts here
        private Node front;
        private Node rear;
        private int size;

        public LinkedQueue()
        {
            this.front = this.rear = null;
            this.size = 0;
        }

        public int GetSize()
        {
            return this.size;
        }

        public void Clear()
        {
            this.front = this.rear = null;
            this.size = 0;
        }

        public bool IsEmpty()
        {
            return this.size == 0;
        }

        public T Peek()
        {
            if (!this.IsEmpty())
                return this.front.Data;
            else
            {
                Debug.WriteLine("Nothing to peek.");
                return default(T);
            }
        }

        public void Enqueue(T data)
        {
            //Create a Node for the data
            Node temp = new Node(data);
            if (this.IsEmpty())
                this.front = this.rear = temp;
            else
            {
                this.rear.Next = temp;
                this.rear = this.rear.Next;
            }

            this.size++;
        }

        public T Dequeue()
        {
            T value = default(T);
            if (!this.IsEmpty())
            {
                value = this.front.Data;
                this.front = this.front.Next;
                this.size--;
            }
            else
                Debug.WriteLine("Nothing to Dequeue.");

            return value;
        }

    }
}
