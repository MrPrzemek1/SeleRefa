using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp
{
    class Program
    {
        protected List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

        static void Main(string[] args)
        {
            MessageService ms = new MessageService("lala", 23);
            MessageService ms1 = new MessageService("1ala", 123);
            MessageService ms2 = new MessageService("aala", 423);
            MessageService ms3 = new MessageService("bala", 263);
            List<MessageService> msList = new List<MessageService>();
            msList.Add(ms);
            msList.Add(ms1); msList.Add(ms2); msList.Add(ms3);
            foreach (var item in msList)
            {
                msList.Sort();
                Console.WriteLine(item);
            }
            Console.ReadLine();

            //    try
            //    {
            //        DivineByZero(5,0);
            //    }

            //    catch (DivideByZeroException ex)
            //    {
            //        Console.WriteLine("HelpLink {0}",ex.HelpLink);
            //        Console.WriteLine("HResult {0}", ex.HResult);
            //        Console.WriteLine("InnerException {0}", ex.InnerException);
            //        Console.WriteLine("Message {0}", ex.Message);
            //        Console.WriteLine("Source {0}", ex.Source);
            //        Console.WriteLine("StackTrace {0}", ex.StackTrace);
            //        Console.WriteLine("TargetSite {0}", ex.TargetSite);
            //        Console.WriteLine("Data {0}", ex.Data);
            //        Console.WriteLine("BaseException {0}", ex.GetBaseException());
            //        Console.WriteLine("HashCode {0}", ex.GetHashCode());
            //    }

            //    dynamic a = 1.22;
            //    int b = a;
            //    Console.WriteLine(b);
            //    Console.ReadLine();
            //}
            //public static double DivineByZero(int a , int b)
            //{
            //    return a / b;
            //}
        }
    }
}
