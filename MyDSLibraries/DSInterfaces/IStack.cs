using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DSInterfaces
{
    public interface IStack<T> {

        void Clear();
        void Push(T value);

        int GetSize();

        bool IsEmpty();

        object Pop();
        object Peek();

    }
}
