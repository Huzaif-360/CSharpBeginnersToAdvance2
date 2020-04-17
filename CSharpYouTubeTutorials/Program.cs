using System;

namespace CSharpYouTubeTutorials
{
    class Program
    {
        static void Main()
        {

            //UT Lecture 6

            /*Nullable bool
            Now bool has 3 choices
            1. True
            2. False
            3. Null*/

            bool? your_Reply = null;

            ///Console.WriteLine("Enter your choice");
            //string your_Reply = Console.ReadLine();

            if (your_Reply==true)
            {
                Console.WriteLine("Your Choosed YES!");
            }
            else if(your_Reply==false)
            {
                Console.WriteLine("Your Choosed No!");
            }
            else
            {
                Console.WriteLine("You have made no choice");
            }

        }

    }

}