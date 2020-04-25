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
             //Lecture 12 Access modifier:
                1. Public
                2. Private
                3. Protected
                4. internal
                5. protected inheri
                (this is done to make our program)

                private int age;


                OOP
                1. Encapsulation/ Information Hiding
                    (every class and function is responsible for it specific works)
 	                        1. Define fields as private
	                        2.  Provide gatter /setters method as public

                2. Inheritance
                3. Polymorphism

            */

        }
        public class Person
        {

            //Access Provider/Modifier
            //private and public
            public int number = 0;
            private DateTime _birthdate;

            public void SetBirthdate(DateTime birthdate)
            {
                _birthdate = birthdate;
            }

            public DateTime GetBirthdate()
            {
                return _birthdate;
            }
        }
    }
    }

