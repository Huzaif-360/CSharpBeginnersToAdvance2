using System;

namespace CSharpYouTubeTutorials
{
    class Program
    {
        static void Main()
        {
            //Lecture 11
            //Switch Statements

            Console.WriteLine("Enter a number:- ");
            string number = Console.ReadLine();
            int Number = Convert.ToInt32(number);
            
            /*..............Using if statement ............
            if(Number==10)
            {
                Console.WriteLine("Your Number = 10" );
            }
            else if (Number == 20)
            {
                Console.WriteLine("Your Number = 20");
            }
            else if (Number == 30)
            {
                Console.WriteLine("Your Number = 30");
            }
            */
            switch(Number)
            {
                case 10:
                    Console.WriteLine("Your Number = 10");
                    break;
                case 20:
                    Console.WriteLine("Your Number = 20");
                    break;
                case 30:
                    Console.WriteLine("Your Number = 30");
                    break;
                default:
                    Console.WriteLine("Your Number is none of 10,20,30");
                    break;
            }


        }

    }

}
 
 
 
 