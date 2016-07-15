using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BufferImplementation;
using CommonInterfaces;

namespace Buffer
{
    public class UserQueue<T> : IQueue<T>, IPrintable<T>
    {
        public DynamicArray<T> userQueue;
        private int head = 0;

        public UserQueue(int maxArrayLenght)
        {
            userQueue = new DynamicArray<T>();
        }
        
        //Enqueue
        public void Enqueue(T value)
        {
            userQueue.Add(value);
        }

        //Dequeue
        public T Dequeue()
        {
            T value = userQueue.Get(head);
            userQueue.Remove(head);
            return value;
        }
        
        //Print 

        public List<T> Print()
        {
            List<T> ListForPrinting = new List<T>();

            for (int i = 0; i <= userQueue.logicalSize - 1; i++)
            {
                ListForPrinting.Add(userQueue.Get(i));
            }
            return ListForPrinting;
        }
    }
}





