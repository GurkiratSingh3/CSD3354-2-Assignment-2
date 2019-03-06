using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents
//Student Name:- Gurkirat Singh Student Id:-C0731779
//student Name:-Robindeep Singh  Student Id:- C0723381
// CSD 3354 Section 2
//Assignment 2
//March 6-2019
{
    using System;
    delegate void ExampleDelegate(string xyz);
    public class Program
    {
        public static void Method1(string xyz)
        {
            Console.WriteLine(xyz + " Method1");
        }
        public static void Method2(string xyz)
        {
            Console.WriteLine(xyz + " Method2");
        }
        public static void Main()
        {
            ExampleDelegate ex1Delegate, ex2Delegate, ex3Delegate, myDelegate;

            ex1Delegate = new ExampleDelegate(Method1);
            ex2Delegate = new ExampleDelegate(Method2);
            ex3Delegate = ex1Delegate + ex2Delegate;
            myDelegate = ex1Delegate = ex2Delegate;
            ex1Delegate("AAA");
            ex2Delegate("BBB");
            ex3Delegate("CCC");
            myDelegate("DDD");
            myDelegate = ex3Delegate - ex1Delegate;
            myDelegate("EEE");
            myDelegate = ex3Delegate - ex2Delegate;
            myDelegate("FFF");
            Console.ReadLine();
            
        }
    }
}
