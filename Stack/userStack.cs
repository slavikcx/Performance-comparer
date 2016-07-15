using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonInterfaces;
using BufferImplementation;

namespace Buffer
{
    public class UserStack<T> : IStack<T>, IPrintable<T>
    {

        public DynamicArray<T> userStack;

        public UserStack(int maxArrayLenght)
        {
            userStack = new DynamicArray<T>();
        }

        //Push
        public void Push(T value)
        {
            userStack.Add(value);
        }

        //Pop
        public T Pop()
        {
            T value = userStack.Get(userStack.logicalSize - 1);
            userStack.Remove(userStack.logicalSize - 1);
            return value;
        }
        
        //Peek
        public T Peek()
        {
            T value = userStack.Get(userStack.logicalSize - 1);
            return value;
        }

        //Print 

        public List<T> Print()
        {
            List<T> ListForPrinting = new List<T>();

            for (int i = 0; i <= userStack.logicalSize - 1; i++)
            {
                ListForPrinting.Add(userStack.Get(i));
            }
            return ListForPrinting;
        }
        
    }
}
