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

        public IStack<T> CreateStack<T> (int i = 0)
        {
            /* Below If statments will be used when different types of Stacks have been implemented */
            //if(i == 0)
            //{
            //}
            //else if(i == 1)
            //{
            //}
            
            return new Stack<T>();
        }

        public IQueue<T> CreateQueue<T> (int i = 0)
        {
            /* Below If statments will be used when different types of Queues have been implemented */
            //if(i == 0)
            //{
            //}
            //else if(i == 1)
            //{
            //}

            return new Queue<T>();

        }

        public IHeap<T> CreateHeap<T> (int i = 0) where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            /* Below If statments will be used for different types of Heaps */

            //Default to Max Heap
            if (i == 0)
                return new MaxHeap<T>();
            else
                return new MinHeap<T>();

        }

    }
}
