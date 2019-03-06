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
        static void Main(string[] args)
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
            Console.ReadLine();
        }
    }
    public delegate void MyDelegate();
    public class DelegateExercises : MyDelegate
    {
      
    }
}
