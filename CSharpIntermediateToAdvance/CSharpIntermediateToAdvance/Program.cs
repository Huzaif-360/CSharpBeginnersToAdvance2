using System;
//using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace CSharpIntermediateToAdvance
{
	class Program
	{

        static void Main(string[] args)
        {
            /* 
             * //Section 5
            Polymorphism: Third  Pillar of OOP

            
            //Lecture 29
            Abstract Classes and Members

            1. Abstract Modifiers:
	            Indicates that a class or a member is missing implementation
            
            public astract class shape
            {
            public abstract void Draw();
            }
            public class Circle: Shape
            {
            public override void Draw()
            {
            }   
            }


            2. Abstract Member:
	        Rules:	
	            1.Do not have any body,( implementation).
		        public abstract void Draw();
	
	            2. If a member is declared as abstract, the containing class need to be declared as abstract too.
	            public astract class shape
	            {
	            public abstract void Draw();
	            }
		
	            3. In a derived class you must implement all abstract members in the base abstract class.
	            public class Circle: Shape
	            {
	            public override void Draw()
	            {
	            }
	            }
	
	            4. Abstract classes can not be instaniated
	            var shape=new Shaoe(); //this won't compile

                3. Why to use Abstract?
	            when you want to provide some common behavior while forcing other
                developers to follow your design.
                in our shaping example are declaring the draw method as abstract. We'll make sure that anytime a developer derives a class from the shape 
                they will provide an implementation for the draw method. If we did not declare this method as abstract and instead provided an empty virtual method 
                we would run into the risk of a developer deriving a class from the shape without overriding the draw method.


                    */

            //Creating a List of Shapes
            var shapes = new List<Shape>();

            //Creating a Circle
            shapes.Add(new Circle());

            //Creating a Rectangle
            //shapes.Add(new Rectangle());

            //Creating a Triangle
            //shapes.Add(new Triangle());

           // var canvas = new Canvas();
            //anvas.DrawShapes(shapes);
        }

        //Parent Class
        public abstract class Shape
        {
            public abstract void Draw();
        }

        //Derived Class 1
        public class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Draw a Circle1.");
            }
        }
    }
}


