using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallel
{
    class Chaining
    {
        static void Method1(int x, int ub)
        {
            for (int i = 1; i <= ub; i++)
                Console.WriteLine($"{x} * {i} = {x * i}");
        }
        static void Method2(int x, int ub)
        {
            for (int i = ub; i > 0; i--)
                Console.WriteLine($"{x} * {i} = {x * i}");
        }
        static void Main()
        {
            Task t = Task.Factory.StartNew(() => Method1(5, 12)).ContinueWith((antecedent) =>
        Console.WriteLine()).ContinueWith((antecedent) => Method2(5, 12));
            t.Wait();
            Console.ReadLine();
        }
    }

}

