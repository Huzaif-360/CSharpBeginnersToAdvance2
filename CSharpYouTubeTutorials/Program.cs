using System;

namespace CSharpYouTubeTutorials
{
    class Program
    {
        static void Main()
        {

            //UT Lecture 5

            //.............Assignment operator ...............
            int i = 10;
            bool b = true;

            //..................Arithmetic Operator...............................

            //.................Divison /................................
            int numerator = 10;
            int denominator = 2;
            int quotient = numerator / denominator;
            Console.WriteLine("Quotient = {0}", quotient);

            //.................Mod %................................

            int remainder = numerator % denominator;
            Console.WriteLine("Remainder = {0}", remainder);

            //..................Comparison Operator...............................
            int number = 11;
            if (number == 11)
            {
                Console.WriteLine("Number is equal to 11");
            }
            else
            {
                Console.WriteLine("Number is Not Equal to 11");
            }

            // To compare if 2 numbers are not
            // equal use comparison operator !=
            if (number != 77)
            {
                Console.WriteLine("Number is not equal to 77");
            }
            else
            {
                Console.WriteLine("Number is Not Equal to 77");
            }


            //..................Conditional (1) Operator...............................

            int number1 = 101;
            int number2 = 200;

            if (number1 == 102 && number2 == 202)
            {
                Console.WriteLine("Both conditions are true");
            }
            else if (number1 > number2)
            {
                Console.WriteLine("number1 is greater then number 2");
            }
            else
            {
                Console.WriteLine("number2 is greater then number 1");
            }


            //..................Conditional (2) Operator...............................

            int number3 = 10;
            int number4 = 21;

            if (number3 == 10 || number4 == 20)
            {
                Console.WriteLine("Atleast one of the condition is true");
            }
            else
            {
                Console.WriteLine("Both conditional are failed");
            }
        }
    }

}