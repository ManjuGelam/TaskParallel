using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace TaskParallel
{
    class valuereturning2 // by usinf with paramerts by tasks
    {
        static int GetLength1(int ub)
        {
            string str = "";
            for (int i = 1; i <= ub; i++)
                str += i;
            return str.Length;
        }
        static string GetLength2(string str)
        {
            return str.ToUpper();
        }
        static void Main()
        {
            Task<int> t1 = new Task<int>(() => GetLength1(50000));
            Task<string> t2 = new Task<string>(() => GetLength2("Hello India"));
            t1.Start(); t2.Start();
          //  OR
          //Task<int> t1 = Task.Factory.StartNew(() => GetLength1(50000));
            //Task<string> t2 = Task.Factory.StartNew(() => GetLength2("Hello India"));

            int Result1 = t1.Result;
            string Result2 = t2.Result;

            Console.WriteLine($"Value of Result1 is: {Result1}");
            Console.WriteLine($"Value of Result2 is: {Result2}");
        }
    }

}

