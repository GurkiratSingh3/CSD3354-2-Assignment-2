using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateExercises o = new DelegateExercises();
            o.Method2();
        }
    }
    public class DelegateExercises
    {
        //Name : Gurkirat Singh (C0731779)
        //Name : Robindeep Singh (C0723381)
        public delegate void MyDelegate();

        void Method1()
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }

        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }
}
