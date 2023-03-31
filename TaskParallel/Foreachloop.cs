using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallel
{
    class Foreachloop
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 67, 29, 30};

            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            foreach (int i in arr)
            {
                Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}; i value: {i}");
            }
            sw1.Stop();

            Console.WriteLine();

            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            Parallel.ForEach(arr, i => {
                Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}; i value: {i}");
            });
            sw2.Stop();

            Console.WriteLine("Time taken to execute code by using sequential foreach loop: " + sw1.ElapsedMilliseconds);
            Console.WriteLine("Time taken to execute code by using parallel foreach loop: " + sw2.ElapsedMilliseconds);
        }
    }

}

