using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSInterfaces
{
    public interface IStack {

        void Clear();
        void Push(object value);

        int GetSize();

        bool IsEmpty();

        object Pop();
        object Peek();

    }
}
