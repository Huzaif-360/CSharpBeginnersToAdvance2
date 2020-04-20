using System;
//using System.Collections.Generic;


namespace CSharpBeginners
{

    
    class Program
    {
        
        static void Main(string[] args)
        {
            //Section 7 Date and Time
            //Lecture 60

            //New Time Span
            var timespam = new TimeSpan(3, 5, 7);
            Console.WriteLine(timespam);

            //............................
            var now = DateTime.Now;
            Console.WriteLine(now);
            var start = DateTime.Now.AddMinutes(1);
            var dif = now - start;

            //diff is Time Span
            Console.WriteLine("diff"+ dif);

            

        }

    }
}
