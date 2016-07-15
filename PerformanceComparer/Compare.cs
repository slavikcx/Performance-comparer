using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Buffer;

namespace PerformanceComparer
{
    public class Compare<T>
    {
        private List<int> ListForPrint;
        
        public void StackPushCompare(int amountOfValues, out long timeElapsedStandardStack, out long timeElapsedUserStack)
        {
            //amountOfValues = amountOfValues - 1;
            Stopwatch time = new Stopwatch();
            Random rnd = new Random();
            Stack<int> netStack = new Stack<int>();
            UserStack<int> userStack = new UserStack<int>(amountOfValues);
            
            time.Start();
            for (int i=0; i< amountOfValues; i++)
            {
                netStack.Push(rnd.Next(100));
            }
            time.Stop();

            timeElapsedStandardStack = time.ElapsedMilliseconds;

            time.Reset();

            time.Start();
            for (int i = 0; i < amountOfValues; i++)
            {
                userStack.Push(rnd.Next(100));
            }
            time.Stop();
            timeElapsedUserStack = time.ElapsedMilliseconds;

            ListForPrint = userStack.Print();
        }

        public void StackPopCompare(int amountOfValues, out long timeElapsedStandardStack, out long timeElapsedUserStack)
        {
            Stopwatch time = new Stopwatch();
            Random rnd = new Random();
            Stack<int> netStack = new Stack<int>();
            UserStack<int> userStack = new UserStack<int>(amountOfValues);

            for (int i = 0; i < amountOfValues; i++)
            {
                netStack.Push(rnd.Next(100));
            }

            time.Start();
            for (int i = 0; i < amountOfValues; i++)
            {
                netStack.Pop();
            }
            time.Stop();

            timeElapsedStandardStack = time.ElapsedMilliseconds;

            time.Reset();

            for (int i = 0; i < amountOfValues; i++)
            {
                userStack.Push(rnd.Next(100));
            }

            time.Start();
            for (int i = 0; i < amountOfValues; i++)
            {
                userStack.Pop();
            }
            time.Stop();

            timeElapsedUserStack = time.ElapsedMilliseconds;

            ListForPrint = userStack.Print();
        }

        public void QueueEnqueueCompare(int amountOfValues, out long timeElapsedStandardStack, out long timeElapsedUserStack)
        {
            Stopwatch time = new Stopwatch();
            Random rnd = new Random();
            Queue<int> netQueue = new Queue<int>();
            UserQueue<int> userQueue = new UserQueue<int>(amountOfValues);

            time.Start();
            for (int i = 0; i < amountOfValues; i++)
            {
                netQueue.Enqueue(rnd.Next(100));
            }
            time.Stop();

            timeElapsedStandardStack = time.ElapsedMilliseconds;

            time.Reset();

            time.Start();
            for (int i = 0; i < amountOfValues; i++)
            {
                userQueue.Enqueue(rnd.Next(100));
            }
            time.Stop();
            timeElapsedUserStack = time.ElapsedMilliseconds;

            ListForPrint = userQueue.Print();
        }

        public void QueueDequeueCompare(int amountOfValues, out long timeElapsedStandardStack, out long timeElapsedUserStack)
        {
            Stopwatch time = new Stopwatch();
            Random rnd = new Random();
            Queue<int> netQueue = new Queue<int>();
            UserQueue<int> userQueue = new UserQueue<int>(amountOfValues);

            for (int i = 0; i < amountOfValues; i++)
            {
                netQueue.Enqueue(rnd.Next(100));
            }

            time.Start();
            for (int i = 0; i < amountOfValues; i++)
            {
                netQueue.Dequeue();
            }
            time.Stop();

            timeElapsedStandardStack = time.ElapsedMilliseconds;

            time.Reset();

            for (int i = 0; i < amountOfValues; i++)
            {
                userQueue.Enqueue(rnd.Next(100));
            }

            time.Start();
            for (int i = 0; i < amountOfValues; i++)
            {
                userQueue.Dequeue();
            }
            time.Stop();
            timeElapsedUserStack = time.ElapsedMilliseconds;

            ListForPrint = userQueue.Print();
        }
        
        public List<int> Print ()
        {
            return ListForPrint;
        }
    }
}
