using System;
//using System.Runtime.CompilerServices;
//using System.Collections.Generic;

namespace CSharpIntermediateToAdvance
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Console.WriteLine("This section is exercise section and 1 example done and 2nd is completed logically");
        }

        //Lecture 16
        //Exercise

        //Question 1
        public class Stopwatch
        {
            public static int Count = 0;
            private static DateTime _start;
            private static DateTime _end;


            public static TimeSpan Duration
            {
                get => _end - _start;
            }

            public static void Start()
            {
                if (Count < 1)
                {
                    _start = DateTime.Now;
                    Count++;
                }
                else
                {
                    throw new InvalidOperationException("Error!");
                }
            }

            public static void End()
            {
                _end = DateTime.Now;
                Count = 0;
            }
        }
    }
}


