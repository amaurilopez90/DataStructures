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
            #region Stacks
            StackFactory stackFactory = new StackFactory();

            IStack<int> myIntStack = stackFactory.CreateStack<int>();
            IStack<string> myStringStack = stackFactory.CreateStack<string>();

            //int stack
            myIntStack.Push(5);
            Debug.WriteLine(myIntStack.Pop());
            myIntStack.Push(4);
            myIntStack.Push(15);
            Debug.WriteLine(myIntStack.Peek());
            myIntStack.Pop();
            Debug.WriteLine(myIntStack.Pop());
            Debug.WriteLine(myIntStack.GetSize());

            //string stack
            myStringStack.Push("hello.");
            Debug.WriteLine(myStringStack.Pop());
            myStringStack.Push("goodbye.");
            myStringStack.Push("please.");
            Debug.WriteLine(myStringStack.Peek());
            myStringStack.Pop();
            Debug.WriteLine(myStringStack.Pop());
            Debug.WriteLine(myStringStack.GetSize());
            #endregion

        }
    }
}
