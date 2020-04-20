using System;
//using System.Collections.Generic;


namespace CSharpBeginners
{

    
    class Program
    {
        
        static void Main(string[] args)
        {
            /*Section 7 Date and Time
            Lecture 59
            Completed Lecture 58
            Introduction*/

            //Time Check
            var dateTime = new DateTime(2020, 04, 21);
            Console.WriteLine(dateTime);

            //Now
            var now = DateTime.Now;
            Console.WriteLine(now);

            //Day
            var day = DateTime.DaysInMonth(2020, 10);
            Console.WriteLine("days in 10th month"+ day);

            Console.WriteLine("Year "+ now.Year);
            Console.WriteLine("Month "+now.Month);
            Console.WriteLine("Day "+now.Day);
            Console.WriteLine("Minute "+now.Minute);
            Console.WriteLine("Hour "+now.Hour);


        }
  
    }
}
