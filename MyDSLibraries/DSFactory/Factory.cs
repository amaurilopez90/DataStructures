using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Below usage will be expanded upon once I have implemented more data structures */ 
using DSInterfaces;
using Stacks;
using Queues;
using Heaps;

/* 
 using Trees;
 */

namespace DSFactory
{
    public class Factory {

        public IStack<T> CreateStack<T> (string type = "Linked")
        {
            /* Below If statments will be used when different types of Stacks have been implemented */
            //if(type == "Linked")
            //{
            //}
            //else if(type == "Array")
            //{
            //}
            
            return new LinkedStack<T>();
        }

        public IQueue<T> CreateQueue<T> (string type = "Linked")
        {
            /* Below If statments will be used when different types of Queues have been implemented */
            //if(type == "Linked")
            //{
            //}
            //else if(type == "Array")
            //{
            //}
            //else if(type == "CircularLinked")
            //{
            //}
            //else if(type == "CircularArray")
            //{
            //}

            return new LinkedQueue<T>();

        }

        public IHeap<T> CreateHeap<T> (string type = "Max") where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            /* Below If statments will be used for different types of Heaps */

            //Default to Max Heap
            if (type == "Max")
                return new MaxHeap<T>();
            else if (type == "Min")
                return new MinHeap<T>();
            else
                throw new ArgumentException("Parameter must specify a valid type.\nSupported types: 'Max(default)', 'Min'");
        }

    }
}
