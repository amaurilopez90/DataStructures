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

            IStack myStack = stackFactory.CreateStack();

            myStack.Push(5);
            Debug.WriteLine(myStack.Pop());
            myStack.Push(4);
            myStack.Push(15);
            Debug.WriteLine(myStack.Peek());
            myStack.Pop();
            Debug.WriteLine(myStack.Pop());
            Debug.WriteLine(myStack.GetSize());

            #endregion

        }
    }
}
