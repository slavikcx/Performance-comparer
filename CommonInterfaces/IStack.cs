using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterfaces
{
    public interface IStack<T>
    {
        //Push
        void Push(T valua);

        //Pop
        T Pop();

        //Peek
        T Peek();
    }
}
