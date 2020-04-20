using System;
namespace CSharpBeginners
{

    //Udemy 42;
    class Program
    {
        
        static void Main(string[] args)
        {
            /* var check = 0;
            //udemy 46 While Loop
            while (check <= 5)
            {
                if (check % 2 == 0)
                {
                    Console.WriteLine(check);
                }
                check++;
            }



            //.............While Type 1.......................
            while (true)
            {
                Console.WriteLine("Enter your name:- ");
                var Name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(Name))
                {
                    break;
                }
                Console.WriteLine("@Echo : " + Name);
            }
            */


            //.............While Type 2.......................

            while (true)
            {
                Console.WriteLine("Enter your name:- ");
                var Name = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(Name))
                {
                    Console.WriteLine("@Echo : " + Name);
                    continue;
                }
                break;

            }
        }

    }
}
