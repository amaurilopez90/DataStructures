using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using DSInterfaces;

namespace Heaps
{
    /*Note to self 
     
         When you want to implement other Heaps
         create classes for them just like you did here
         under the Heaps namespace
         */

    public class MaxHeap<T> : IHeap<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T> {

        private int size;
        private List<T> items;

        //Constructor
        public MaxHeap(int _size = 0)
        {
            this.size = _size;
            this.items = new List<T>();
        }

        #region Helper Methods

        //Determining if any "node" has left, right, or parent values
        private bool HasLeftChild(int index) { return this.GetLeftChildIndex(index) < this.size; }
        private bool HasRightChild(int index) { return this.GetRightChildIndex(index) < this.size; }
        private bool HasParent(int index) { return this.GetParentIndex(index) >= 0; }

        //Getting left, right, and parent locations in array (the Array is meant to represent a tree-like structure)
        private int GetLeftChildIndex(int index) { return 2 * index + 1; }
        private int GetRightChildIndex(int index) { return 2 * index + 2; }
        private int GetParentIndex(int index) { return (index - 1) / 2; }

        //Getting left, right, and parent values
        private T Left(int index) { return this.items[this.GetLeftChildIndex(index)]; }
        private T Right(int index) { return this.items[this.GetRightChildIndex(index)]; }
        private T Parent(int index) { return this.items[this.GetParentIndex(index)]; }

        private void Swap(int firstIndex, int secondIndex)
        {
            T temp = this.items[firstIndex];
            this.items[firstIndex] = this.items[secondIndex];
            this.items[secondIndex] = temp;
        }

        private void HeapifyUp()
        {
            //Start at the bottom of the Heap
            int index = this.size - 1;

            //If we have a "node" whos parent is less than it's value, then we want to swap these two
            //and continue up the Heap until everything is in correct position
            while (this.HasParent(index) && this.Parent(index).CompareTo(this.items[index]) < 0)
            {
                this.Swap(index, this.GetParentIndex(index));
                index = this.GetParentIndex(index);
            }
        }

        private void HeapifyDown()
        {
            //start at the top of the Heap
            int index = 0;

            while (this.HasLeftChild(index))
            {
                //get the greater of the left and right children for this index
                int largerIndex = this.GetLeftChildIndex(index);
                if (this.HasRightChild(index) && this.Right(index).CompareTo(this.items[largerIndex]) > 0)
                    largerIndex = this.GetRightChildIndex(index);

                //If parent is less than the child than swap them
                if (this.items[index].CompareTo(this.items[largerIndex]) > 0)
                    break;
                else
                    this.Swap(index, largerIndex);

                //Move down the Heap
                index = largerIndex;
            }

        }
        #endregion

        public void Add(T value)
        {
            this.items.Add(value);
            this.size++;

            //Order the new value correctly within the heap
            this.HeapifyUp();
        }

        public T Poll()
        {
            if (this.IsEmpty())
            {
                Debug.WriteLine("Cannot poll from empty Heap.");
                return default(T);
            }

            //Get the top element in the Heap
            T temp = this.items[0];

            //Replace it with the bottom element and heapify down
            this.items[0] = this.items[this.size - 1];
            this.size--;

            this.HeapifyDown();
            return temp;
        }

        public T Peek()
        {
            if (this.IsEmpty())
            {
                Debug.WriteLine("Cannot peek from empty Heap.");
                return default(T);
            }

            return this.items[0];
        }

        public int GetSize()
        {
            return 0;
        }

        public bool IsEmpty()
        {
            return this.size == 0;
        }


    }
}
