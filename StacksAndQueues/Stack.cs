using System.Collections.Generic;
using System.Diagnostics;

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
        public Node(object value, Node next)
        {
            this._data = value;
            this._next = next;
        }
    }

    //Start Stack class
    private Node top;
    public Stack() => this.top = null;

    public void Push(object value)
    {
        Node temp = new Node(value, this.top);
        this.top = temp;
    }

    public object Pop()
    {
        object value = this.top.Data;
        this.top = this.top.Next;

        return value;
    }

    static void Main(string []args)
    {
        
    }




}