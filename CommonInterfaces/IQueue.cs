using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterfaces
{
    public interface IQueue<T>
    {
        //Enqueue
        void Enqueue(T value);

        //Dequeue
        T Dequeue();
    }

}
