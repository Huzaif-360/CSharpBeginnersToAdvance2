﻿using System;

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

            if (Number==1)
            {
                Console.WriteLine("Your Number = 1");
            }
            if (Number == 2)
            {
                Console.WriteLine("Your Number = 2");
            }
            if (Number == 3)
            {
                Console.WriteLine("Your Number = 3");
            }
            if (Number == 4)
            {
                Console.WriteLine("Your Number = 4");
            }
            if (Number != 1 && Number != 2 && Number !=3 && Number != 4)
            {
                Console.WriteLine("Your Number is not equla to 1,2,3,4 ");
            }
           
        }

    }

}
 
 
 
 