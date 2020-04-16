using System;

namespace CSharpYouTubeTutorials
{
    class Program
    {
        static void Main()
        {

            //UT Lecture 2
            Console.WriteLine("Enter Your Name!");
            string name= Console.ReadLine();

            //................Method 1 Concatenation.....................
            Console.WriteLine("My name is " + name);

            //.............. Method 2  Place holder syntax .......................
            Console.WriteLine("My name is {0}", name);

            //...................................................................

            //.....................CSharp is Case senstive ................
            /* var NAME = "Huzaifa Shah";
             Console.WriteLine(Name);
             */


            Console.WriteLine("Enter Your First Name!");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name!");
            string lname = Console.ReadLine();
            Console.WriteLine("My name is {0} {1}", fname, lname);
        }
      
    }
}
