using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallel
{
    class ValueReturning  // by using tasks
    {
        static int GetLength1()
        {
            string str = "";
            for (int i = 1; i <= 10000; i++)
            {
                str += i;
            }
            return str.Length;
        }
        static string GetLength2()
        {
            string str = "HIII GUYS";
            return str.ToUpper();
        }
        static void Main()
        {
            Task<int> t1 = new Task<int>(GetLength1);
            Task<string> t2 = new Task<string>(GetLength2);
            t1.Start(); t2.Start();
           // OR
         // Task<int> t1 = Task.Factory.StartNew(GetLength1);
           // Task<string> t2 = Task.Factory.StartNew(GetLength2);

            int Result1 = t1.Result;
            string Result2 = t2.Result;
            Console.WriteLine($"Value of Result1 is: {Result1}");
            Console.WriteLine($"Value of Result2 is: {Result2}");
        }
    }



}

