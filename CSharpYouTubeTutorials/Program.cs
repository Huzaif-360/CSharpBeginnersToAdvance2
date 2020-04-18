using System;

namespace CSharpYouTubeTutorials
{
    class Program
    {
        static void Main()
        {
            //Lecture 10
            //If Statements

            Console.WriteLine("Enter a number:- ");
            string number = Console.ReadLine();
            int Number = Convert.ToInt32(number);
            Console.WriteLine(Number);

            //........................... 1............................(Double Pipe) this does not checks 2nd condition  if 1st condition is true
            if (Number == 10 || Number==20 )
            {
                Console.WriteLine("Entered Number equals to 10 or 20");
            }
           else
            {
                Console.WriteLine("Entered Number is neither 10 nor 20");
            }

            //........................... 2............................(Single Pipe) this checks both conditions even if 1st condition is true
            if (Number == 10 | Number == 20)
            {
                Console.WriteLine("Entered Number equals to 10 or 20");
            }
            else
            {
                Console.WriteLine("Entered Number is neither 10 nor 20");
            }

            //........................... 3............................(Double &)this does not checks 2nd condition  if 1st condition is true
            if (Number == 10 && Number == 20)
            {
                Console.WriteLine("Entered Number equals to 10 and 20");
            }
            else
            {
                Console.WriteLine("Entered Number is neither 10 nor 20");
            }
            //........................... 4............................ (Single &) this checks both conditions even if 1st condition is true
            if (Number == 10 & Number == 20)
            {
                Console.WriteLine("Entered Number equals to 10 and  20");
            }
            else
            {
                Console.WriteLine("Entered Number is neither 10 nor 20");
            }

        }

    }

}
 
 
 
 