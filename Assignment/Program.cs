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
    public class Program
    {
        public static void Main()
        {
           DelegateExercises delegateExercises = new DelegateExercises();
            try    
            {
                delegateExercises.Method3();
              Console.ReadLine();
            }
        catch(System.Exception ex)
        {
            System.Console.WriteLine("Exception Occurred.");
                Console.ReadLine();
        }
        }
    }
    public delegate void MyDelegate(out int i);

    public class DelegateExercises
        {
        void Method1()
            {
              throw new System.Exception();
            }          
        public void Method3()
            {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }
}
