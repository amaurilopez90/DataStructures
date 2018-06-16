using System.Diagnostics;

namespace DataStructures.StacksAndQueues
{
    public class Queue
    {
        //Set up a Node class
        public class Node
        {
            private object _data;
            private Node _next;

            public object Data { get { return this._data; } set { this._data = value; } }
            public Node Next { get { return this._next; } set { this._next = value; } }

            public Node(object data = null, Node next = null)
            {
                this._data = data;
                this._next = next;
            }
        }

        //Start Queue class
        private Node front;
        private Node rear;
        private int size;

        public Queue()
        {
            this.front = this.rear = null;
            this.size = 0;
        }

        public void Enqueue(object data)
        {
            //Make a new node to hold the data
            Node temp = new Node(data);

            /*If queue is empty, set this new node as both the front and rear of the queue
             *If not, just attach the new node to the rear of the queue*/
            if (this.IsEmpty())
            {
                this.front = this.rear = temp;
            }
            else
            {
                this.rear.Next = temp;
                this.rear = this.rear.Next;
            }

            //Increment the size of the queue
            this.size++;
            
        }

        public object Dequeue()
        {
            object value = null;

            //If queue is empty, don't dequeue anything and let the user know
            if (this.IsEmpty())
            {
                Debug.WriteLine("Nothing to Dequeue.");
            }
            else
            {
                value = this.front.Data;
                this.front = this.front.Next;
                this.size--;
            }

            return value;

        }

        public int GetSize()
        {
            return this.size;
        }

        public bool IsEmpty()
        {
            return this.size == 0;
        }

        public void Clear()
        {
            this.front = this.rear = null;
            this.size = 0;
        }

    }
}
