//using System;
using System;
//using System.Collections.Generic;
//using System.Runtime.CompilerServices;
namespace CSharpIntermediateToAdvance
{
    class Program
    {

        static void Main(string[] args)
        {

            /*
            //Lecture 13
            Properties
            property as a class member that encapsulates a getter and a center for accessing
            a field. So why do we need a property simply for creating a getter setter with less code.

            to get rid of many setters and getters we use properties:
            Properties are decelared as punlic and should be same datatype as fileds.



            Auto- implemented Properties:

            */

        }
        public class Person
        {
            private DateTime _birthdate;

            // private datatype of set this is now not changeble.
           //................Method 1....................................
            public DateTime Birthdate { get; private set; }

            //Birthdate is a Property it is here helping us lower down the numbers of code.
        
            
            
            // .........................Method 2 .......................
            /*  public DateTime Birthdate
            {
                get { return _birthdate; }
                set { _birthdate = value; }
            }*/
        }

    }
}

