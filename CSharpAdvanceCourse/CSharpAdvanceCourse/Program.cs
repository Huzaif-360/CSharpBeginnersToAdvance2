//using System;
//using System.Collections.Generic;
//using System.Threading;
using System.Linq;

namespace CSharpAdvanceCourse
{

    class program
    {
        static void Main(string[] args)
        {
            /*
             * Lecture 11
             * LINQ
             *  Language Integrated Query
             *  LINQ gives the capability to query objects
             *  
             *  
             *  
             *  You can query:
             *  Object in memory, eg collections (LINQ to Objects)
             *  Databases (LINQ to Entities)
             *  XML (LINQ to XML)
             *  ADO.NET Data Sets (LINQ to Data Sets)
             */

            //LINQ Helps in reducing the lines of code.

            //LINQ usage
            var cheapbook = books.Where(b => b.Price < 10);
            /*
             * LINQ Methods:
             * Where(............Use Lambda Expression..........)
             * Orderby(............Use Lambda Expression..........)
             * Single.(...........)  .........Single only works where the object must exists.
             * if we are not sure that we must use SigleorDefault()
             */


        }
    }
    //public class 

}
