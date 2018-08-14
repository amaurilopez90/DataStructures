using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSInterfaces 
{
    //There doesn't seem to be a proper constraint for strictly numeric type values, so we'll try to get as close as possible
    public interface IHeap<T> {

        void Add(T value);

        int GetSize();

        bool IsEmpty();

        T Poll();
        T Peek();

    }

}
