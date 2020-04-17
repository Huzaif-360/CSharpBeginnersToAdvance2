using System;

namespace CSharpYouTubeTutorials
{
    class Program
    {
        static void Main()
        {

            //UT Lecture 6

            /*
             * Checking ticket Status
             * Program using NULL coalescing operator
             * Only 3 Line code
             */

            int? TicketsOnSale = null; //87;
            int Tickets = TicketsOnSale ?? 0;
            Console.WriteLine("Available Tickets={0}", Tickets);

        }

    }

}