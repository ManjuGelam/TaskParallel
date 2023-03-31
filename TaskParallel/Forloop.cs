using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallel
{
    class Forloop
    {
        static void Main()
        {
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            string str1 = "";
            for (int i = 1; i < 100000; i++)
            {
                str1 = str1 + i;
            }
            sw1.Stop();
            Console.WriteLine("Time taken to execute the code by using sequential for loop: " + sw1.ElapsedMilliseconds);

            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            string str2 = "";
            Parallel.For(1, 100000, i =>
            {
                str2 = str2 + i;
            });
            sw2.Stop();
            Console.WriteLine("Time taken to execute the code by using parallel for loop: " + sw2.ElapsedMilliseconds);
        }
    }


}

