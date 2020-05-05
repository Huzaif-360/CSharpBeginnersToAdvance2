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
             * Lecture 15
             * Asynchronous Programming
                with Async / Await

            1. Synchronous Programming Execution:
            Program i executed line by line, one at a time.
            when a function is called, program execution has to wait unlil the function returns.


                     1:......
                     2:Function  //this need time and then it would continue
                     3:......
                     4:.....


            2. ASynchronous Programming Execution:
            When a function is called, program execution continues to next line.
            Withoud waiting for the function to complete.

                     1:......
                     2:Function  //this need time and then it would continue (CALL BACK) //This will calback the execution once others are done.
                     3:......
                     4:.....



            Real Life Example:
                Window Media Players
                Web Browsers:

            WHEN we use ASynchronous Programming ?
            When:
                Accessing the Web
                Working with the files and databases
                Working with images


            HOW ??
            1. Traditional Approaches:
                Multi-threading
                Callbacks.
            2. New approach since .NET 4.5
                Async/ Await (Key Words)

             */
        }
    }
}
