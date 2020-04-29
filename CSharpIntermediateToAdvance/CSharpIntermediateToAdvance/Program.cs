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

            Lecture 28
                Method Overiding
                    Modifying the implementation of an inherited method.
                    (This implementation may not be applied to the derived class)

                    Method Overloading Vs Method Overriding:
            
                Overloading:
	            Method with same name and differnt signatures
                Overrding:
	            Modifying the implementation of an inherited method.

                Base..........virtual (Keyword) 
                drivedd..........override(keyword)

                Poly in Greek means many more means of form.
                    Polymorphism means many forms.
                We have the concept of shape and the concept of drawing a shape.
                But that concept can have different forms depending on the objects we have and run time. All this done in polymorphism.

                    */

            //Creating a List of Shapes
            var shapes = new List<Shape>();

            //Creating a Circle
            shapes.Add(new Circle());

            //Creating a Rectangle
            shapes.Add(new Rectangle());

            //Creating a Triangle
            shapes.Add(new Triangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);


        }

        //Parent Class
        public class Shape
        {
            public int Width { get; set; }
            public int Height { get; set; }



            //Use of Virtual keywork ............Base Method
            public virtual void Draw()
            {
                //code
            }
        }

        //Derived Class 1
        public class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Draw a Circle1.");
            }
        }

        //Derived Class 2
        public class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Draw a Rectangle2.");
            }
        }

        //Derived Class 3
        public class Triangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Draw a Triangle3.");
            }
        }


        public class Canvas
        {
            public void DrawShapes(List<Shape> shapes)
            {
                foreach (var shape in shapes)
                {
                    shape.Draw();
                }
            }
        }
	}
}


