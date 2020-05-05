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

            //object obj = "huzafia";
            //obj.



            
            
            //dynamic has no problem with code because it sees these things at runtime 

            dynamic name = "Huzaifa";   //here name is string
                name = 1001;            //here name is int..............this is beauty of dynamic 
            Console.WriteLine(name);

            //Error with static code
            //static name= "Huzaifa";
            //name = 1001;




        }
    }
    

}
