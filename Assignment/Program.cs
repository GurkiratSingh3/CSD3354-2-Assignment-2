using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateExercises a = new DelegateExercises();
            a.Method2();
        }
    }
    public class DelegateExercises
    {
        //Name : Gurkirat Singh (C0731779)
        //Name : Robindeep Singh (C0723381)
        public delegate void MyDelegate();

        void Method1(int i)
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }

        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate(50);
        }
    }
}
