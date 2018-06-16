using System.Diagnostics;

namespace DataStructures.StacksAndQueues
{

    public class Stack
    {
        //Set up a Node class
        public class Node
        {
            private object _data;
            private Node _next;
        
            //Getters and setters for both data and next node
            public object Data { get { return this._data; } set { this._data = value; } }
            public Node Next { get { return this._next; } set { this._next = value; } }

            //Constructor
            public Node(object value = null, Node next = null)
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

        public void Push(object value)
        {
            Node temp = new Node(value, this.top);
            this.top = temp;
            this._size++;
        }

        public object Pop()
        {
            object value = null;
            if (!this.IsEmpty())
            {
                value = this.top.Data;
                this.top = this.top.Next;
            }
            else { Debug.WriteLine("Nothing to pop."); }

            this._size--;
            return value;
        }

        public bool IsEmpty()
        {
            return this._size == 0;
        }

        public object Peek()
        {
        
            if (!this.IsEmpty())
                return this.top.Data;
            else
            {
                Debug.WriteLine("Nothing to peek.");
                return null;
            }
        }

        public void Clear()
        {
            //Lose the reference to the top node
            this.top = null;
            this._size = 0;
        }

    }

    //This is just a test program
    public class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push(5);
            Debug.WriteLine(myStack.Peek());

            myStack.Push(6);
            Debug.WriteLine(myStack.Peek());

            object value = myStack.Pop();
            Debug.WriteLine(value + " was popped.");
            Debug.WriteLine(myStack.Peek());
        
        
        }
    }

}