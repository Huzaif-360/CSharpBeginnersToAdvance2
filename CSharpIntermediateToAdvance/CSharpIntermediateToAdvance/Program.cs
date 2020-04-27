using System;
//using System.Runtime.CompilerServices;
//using System.Collections.Generic;

namespace CSharpIntermediateToAdvance
{
    class Program
    {

        static void Main(string[] args)
        {
            /*  Section 4
             *  Inheritance - Second Pillar of OOP
             *  Lecture 23
             *  Constructors and Inheritance
             *  
             *  1. Base Class constructors are always executed first
             *  
                2. Base Class construstor are not inheited.
                (in derived class we need to recreate constructor).

             *  
             *  
             */
        }
        //..............Class 1 Parent Class.....................
        public class Vehicle
        {
            private readonly string _registrationNumber;

            public Vehicle()
            {
                Console.WriteLine("Vehicle is being initialized.");
            }

            public Vehicle(string registrationNumber)
            {
                _registrationNumber = registrationNumber;
                Console.WriteLine("Vehicle Initialization {0}", _registrationNumber);
            }
        }


        //..............Class 2 Child Class.....................
        public class Car : Vehicle
        {
            public Car()
            {
                Console.WriteLine("Car Initialization.");
            }

            public Car(string registrationNumber)
                : base(registrationNumber)
            {
                Console.WriteLine("Car Initialization{0}", registrationNumber);
            }
        }
    }
}



