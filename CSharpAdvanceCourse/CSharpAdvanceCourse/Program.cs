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


            //DateTime date = null; Error bcoz datetime is not nullable
            //we can make DateTime a nullable by using as following:

            //Nullable<DateTime> date = null;    //No Error
            ////Aslo we can write a nullable as:
            //DateTime? date1 = null;
            //int? num = null;



            //Console.WriteLine(date.GetValueOrDefault());
            //Console.WriteLine(date.HasValue);
            //Console.WriteLine(date.Value);

            DateTime? date = new DateTime(2020, 1, 1);
            DateTime Date2 = date.GetValueOrDefault();
            DateTime? date3 = Date2;
            Console.WriteLine(date3.GetValueOrDefault());




        }
    }
    

}
