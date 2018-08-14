using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using DSInterfaces;
using DSFactory;

namespace DSProgram
{
    class Program {

        static void Main(string[] args)
        {
            Factory factory = new Factory();

            //#region Stacks

            //IStack<int> myIntStack = factory.CreateStack<int>();
            //IStack<string> myStringStack = factory.CreateStack<string>();

            ////int stack
            //myIntStack.Push(5);
            //Debug.WriteLine(myIntStack.Pop());
            //myIntStack.Push(4);
            //myIntStack.Push(15);
            //Debug.WriteLine(myIntStack.Peek());
            //myIntStack.Pop();
            //Debug.WriteLine(myIntStack.Pop());
            //Debug.WriteLine(myIntStack.GetSize());

            ////string stack
            //myStringStack.Push("hello.");
            //Debug.WriteLine(myStringStack.Pop());
            //myStringStack.Push("goodbye.");
            //myStringStack.Push("please.");
            //Debug.WriteLine(myStringStack.Peek());
            //myStringStack.Pop();
            //Debug.WriteLine(myStringStack.Pop());
            //Debug.WriteLine(myStringStack.GetSize());
            //#endregion

            //#region Queues

            //IQueue<int> myIntQueue = factory.CreateQueue<int>();
            //IQueue<string> myStringQueue = factory.CreateQueue<string>();

            ////int queue
            //myIntQueue.Enqueue(5);
            //Debug.WriteLine(myIntQueue.Dequeue());
            //myIntQueue.Enqueue(4);
            //myIntQueue.Enqueue(15);
            //Debug.WriteLine(myIntQueue.Peek());
            //myIntQueue.Dequeue();
            //Debug.WriteLine(myIntQueue.Dequeue());
            //Debug.WriteLine(myIntQueue.GetSize());

            ////string queue
            //myStringQueue.Enqueue("hello.");
            //Debug.WriteLine(myStringQueue.Dequeue());
            //myStringQueue.Enqueue("goodbye.");
            //myStringQueue.Enqueue("please.");
            //Debug.WriteLine(myStringQueue.Peek());
            //myStringQueue.Dequeue();
            //Debug.WriteLine(myStringQueue.Dequeue());
            //Debug.WriteLine(myStringQueue.GetSize());

            //#endregion

            //#region Heaps

            //IHeap<int> MaxIntHeap = factory.CreateHeap<int>();
            //MaxIntHeap.Add(5);
            //MaxIntHeap.Add(6);
            //MaxIntHeap.Poll();
            //Debug.WriteLine(MaxIntHeap.Peek());

            //#endregion

        }
    }
}
