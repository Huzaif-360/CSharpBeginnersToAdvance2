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
             *  Lecture 24
             *  Upcasting and Downcasting.

            1. Conversion from derived class to a base class is UPCASTING.
            2. Conversion from base class to a derived class is DOWN-CASTING.


            UPCASTING:
                This is Implicit conversion.
                Circle Circle = new Circle();
                Shape shape= cirlce;

           DOWNCASTING:
                This is explicit conversion
                Circle anotherCircle= (Circle)shape;

                We can not cast Circle to another type.
	                1. It will give exceptioanl error
	                2. Use keyword  (as) this would not give exception but onject will not b converted and it would execute new conditions
	                3. USe Keyword (is) this chech type before conversion if type is not same it ends the execution.
             */

            var shape = new Shape();
            var text = (Text)shape;              // (This is Explicit Conversion)DownCasting....... But it is not safe because it can throw an exception 
            var text1 = shape as Text;          // (This is Check) This is the safe method because if it can't type cast then it return null
            if (text1 != null)
            {
                Console.WriteLine("ERROR Hai Bhai");
            }
            {

            }
            // Note: "IS" is keyword which we can use to check the type of object
            if (text1 is Text)
            {
                Console.WriteLine("Object has type Text");
            }

        }

        //Base Class
        public class Shape
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public int X { get; set; }
            public int Y { get; set; }

            public void Draw()
            {

            }
        }
        //Derived Class 
        public class Text : Shape
        {
            public int FontSize { get; set; }
            public string FontName { get; set; }
        }
    }
}



