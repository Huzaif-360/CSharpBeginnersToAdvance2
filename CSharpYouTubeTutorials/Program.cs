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
             * Program without using NULL coalescing operator
             */

            int Tickets;
            int? TicketsOnSale = null; //87;

            if (TicketsOnSale == null)
            {
                Tickets = 0;
            }
            else
            {
                //(int)Exolicit conversion because of nullable & not nullable
                Tickets = (int)TicketsOnSale;
            }

            Console.WriteLine("Available Tickets={0}", Tickets);

        }

    }

}