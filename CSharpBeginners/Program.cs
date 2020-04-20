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

            var timespan = new TimeSpan(3, 5, 7);
            Console.WriteLine(timespan);

            /*
             * /............................
            var now = DateTime.Now;
            Console.WriteLine(now);
            var start = DateTime.Now.AddMinutes(1);
            var dif = now - start;

            //diff is Time Span
            Console.WriteLine("diff"+ dif);
            */


            //Add
            Console.WriteLine("Add Example: " + timespan.Add(TimeSpan.FromMinutes(10)));

            //del hours
            Console.WriteLine("less hours: " + timespan.Subtract(TimeSpan.FromHours(6)));

            //Write this time in string
            Console.WriteLine("To String:- "+ timespan.ToString());
            Console.WriteLine("To Pasre "+ TimeSpan.Parse("10:08:19:59"));
            //Console.WriteLine("To Pasre " + TimeSpan.C("10:08:19:59"));


        }

    }
}
