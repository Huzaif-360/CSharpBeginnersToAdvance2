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
             * Lecture 13
             * Dynamic
             * 
             * Confusing but easy:
             * 
             * Types of Programming Languages:
             * 
             *  1. Statically-typed languages:.........................(resolution at compile time)
             *      i.e. C#, JAVA etc
             *      
             *  2. Dynamically-typed languages:.........................(resolution at run time)
             *      i.e. Ruby, Javascript, Python
             * 
             * 
             * C# HISTORY:
             *  It is started as a static language
             *  .NET 4 added the dynamic capability to improve interoperability with:
             *      COM( e.g. writing office applications)
             *      Dynamic languages( Iron Python)
             */
            dynamic a = 10;
            dynamic b = 12;
            var c = a + b;  //Now var has decided itself the c would be a dynamic variable
            Console.WriteLine(c);




        }
    }
    

}
