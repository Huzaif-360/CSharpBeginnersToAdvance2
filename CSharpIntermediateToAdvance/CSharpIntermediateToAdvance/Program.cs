using System;
//using System.Runtime.CompilerServices;
//using System.Collections.Generic;

namespace CSharpIntermediateToAdvance
{
    class Program
    {

        static void Main(string[] args)
        {
            //    System.Console.WriteLine("This section is exercise section and 1 example done and 2nd is completed logically");


            /*Lecture 18:
              Inheritance   
                (IS a Relationship)
                    ::: CAR is a Vehicle

           What is Inheritance?
                Inheritance is simply a kind of relationship between two classes that allows one to inherit code from the other is usually referred to as is a relationship.

           Why we use it?
                1. Code re-use
                2. Polymorphic Uses

           In UML:
                Representing Object: (SUPER CLASS)
                        Parent/ Base CLass
                Child Class: (SUB CLASS)
                        Derived Class 
            */
        }
        //Class 1:
        public class PresentationObject
        {
            public int Width { get; set; }
            public int Height { get; set; }

            public void Copy()
            {
                Console.WriteLine("Object copied to clipboard.");
            }

            public void Duplicated()
            {
                Console.WriteLine("Object was duplicated.");
            }
        }
        //Class 2:
        public class Text : PresentationObject
        {
            public int FontSize { get; set; }
            public string FontName { get; set; }

            public void AddHyperlink(string url)
            {
                Console.WriteLine("Added a link" + url);
            }
        }
    }
}



