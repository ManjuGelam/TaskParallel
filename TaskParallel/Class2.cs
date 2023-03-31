using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallel
{
    class Class2
    {
        static void Print1()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}; Print1 Method: {i}");
            }
        }
        static void Print2()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}; Print2 Method: {i}");
            }
        }
        static void Print3()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}; Print3 Method: {i}");
            }
        }
        static void Main()
        {
            Task t1 = new Task(Print1);
            Task t2 = new Task(Print2);
            Task t3 = new Task(Print3);
            t1.Start(); t2.Start(); t3.Start();
            t1.Wait(); t2.Wait(); t3.Wait();
            Console.WriteLine($"Main thread with Id: {Thread.CurrentThread.ManagedThreadId} is exiting.");
        }
    }

}

