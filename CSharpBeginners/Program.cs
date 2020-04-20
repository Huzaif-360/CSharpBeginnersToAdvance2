using System;
namespace CSharpBeginners
{

    
    class Program
    {
        
        static void Main(string[] args)
        {
            //Udemy 48 
            //Random Classes



            /*Any Random Numbers
            var random = new Random();
            for (var i=0; i<10; i++)
            {
                Console.WriteLine(random.Next());
            }
            

            // Random Numbers in Limits
            var random = new Random();
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(1,22));
            }
            

            //Random Character In ASCII
            var random = new Random();
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine((char)random.Next(97, 122));
            }
            

            //Random Character In ASCII
            //FROM A_Z
            var random = new Random();
            for (var i = 0; i < 10; i++)
            
                Console.Write((char)('a' + random.Next(0,26)));
             Console.WriteLine();
            
            */

            //Create a Password
            char[] buffer = new char[10];
            var random = new Random();
            for (var i = 0; i < 10; i++)
            
                buffer[i]= ((char)('a' + random.Next(0, 26)));
                var password = new string(buffer);
                Console.WriteLine(buffer);
            
        }

    }
}
