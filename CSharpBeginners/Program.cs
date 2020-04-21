using System;
//using System.Collections.Generic;
using System.Text;

namespace CSharpBeginners
{

    
    class Program
    {

        static void Main(string[] args)
        {
            ///Section 8
            //Working with text
            //Lecture 70
            //String Builder
            var builder = new StringBuilder();
            builder.Append('-', 10);
            Console.WriteLine(builder);
            builder
                //Append string
                .Append('+', 10)

                //Append line
                .AppendLine()

                //Append name
                .Append("Huzaifa")

                .AppendLine()
                .Append('+', 10)
                .Replace('+', '-')
                .Remove(0, 10)
                .Insert(0, new string("Name: "));
            builder.Append("Huzaifa");
            Console.WriteLine(builder);

            //Show first Char
            Console.WriteLine("First Char: " + builder[1]);





        }

        }

    }

