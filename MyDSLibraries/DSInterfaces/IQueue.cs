using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSInterfaces {

    public interface IQueue<T> {

        void Clear();

        void Enqueue(T value);

        int GetSize();

        bool IsEmpty();

        T Dequeue();
        T Peek();
    }
}
