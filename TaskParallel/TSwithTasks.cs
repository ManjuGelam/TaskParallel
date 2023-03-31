using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallel
{
    class TSwithTasks
    {
        public static void Print()
        {
            lock (typeof(TSwithTasks))
            {
                Console.Write("[CSharp Is ");
                Task.Delay(5000).Wait();
                Console.WriteLine("Object Oriented]");
            }
        }
        static void Main()
        {
            Task t1 = new Task(Print);
            Task t2 = new Task(Print);
            Task t3 = new Task(Print);
            t1.Start(); t2.Start(); t3.Start();
           // OR
              //  Task t1 = Task.Factory.StartNew(Print);
          //  Task t2 = Task.Factory.StartNew(Print);
           // Task t3 = Task.Factory.StartNew(Print);
           // Task.WaitAll(t1, t2, t3);
        }
    }


}

