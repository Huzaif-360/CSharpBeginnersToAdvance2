using System;
//using System.Collections.Generic;
//using System.Threading;

namespace CSharpAdvanceCourse
{

    class program
    {
        static void Main(string[] args)
        {
            /*
             * Lecture 10
             * Extension Methods
             *      Allow us to add methods to an existing class with:
             *         1. Changing the code
             *         2. creating a new class that inherits from it
             *         
             */
            string post = "This is very very lpong pistdnjk hkjsjk";
            var shortmessage = post.Shorten(5);
            Console.WriteLine(shortmessage);
        }
    }

}
