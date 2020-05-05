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
             * Lecture 14
             * Exceptional Handling
             *
             */
            var calclulator = new Calculator();
            var result = calclulator.Divide(4, 2);
            Console.WriteLine(result);

        }
    }
}
