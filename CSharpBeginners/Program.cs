using System;
namespace CSharpBeginners
{

    //Udemy 42;
    class Program
    {
        
        static void Main(string[] args)
        {

            /*udemy 45
             * 
             * 
            for (var i = 0; i <= 10; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */
            //Method 1
            var Name = "Muhammad Huzaifa Shah";
            for (var i = 0; i < Name.Length; i++)
            {
                Console.WriteLine(Name[i]);
            }

            //Method 2
            foreach (var charac in Name)
            {
                Console.WriteLine(charac);
            }

        }

    }
}
