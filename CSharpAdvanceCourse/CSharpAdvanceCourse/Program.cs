//using System;
//using System.Collections.Generic;
//using System.Threading;
//using System.Linq;

using System;

namespace CSharpAdvanceCourse
{

    class program
    {
        static void Main(string[] args)
        {
            /*
             * Lecture 12
             * Nullable Types
             * 
             * We Know:
             * A value type can never have NULL
             * i.e. Bool hasAssess= true; or false 
            bool hasAssess = true; //or false
            DataBase :
            Customers.Birthday(datetime NULL)
            */

            //if (date != null)
            //    date2 = date.GetValueOrDefault();
            //else
            //    date2 = DateTime.Today;
            //var d3 = DateTime.Now;
            //Console.WriteLine(date);
            //Console.WriteLine(date2);
            //Console.WriteLine(d3);

            //We can make code smallers by using null colsealing operator;
            DateTime? date = null;
            DateTime date2 = date ?? DateTime.Today;
            
            //Also we can use tertiart operators
            DateTime date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;

            Console.WriteLine(date2);










        }
    }
    

}
