using System;

namespace CSharpYouTubeTutorials
{
    class Program
    {
        static void Main()
        {

            //UT Lecture 4
            string name = "huzaifa";
            Console.WriteLine(name);

        //......................................
         
            var Quote =  "\"Union is strength\"";
            Console.WriteLine(Quote);
            //......................................

            var line = "One\nTwo\nThree";
            Console.WriteLine(line);


            //.....................Without @.......................
            var directory1 = "\\C:\\Program\\User\\CSharpcourse";
            Console.WriteLine(directory1);

            //.....................With @.......................
            var directory2 = @"\C:\Program\User\CSharpcourse";
            Console.WriteLine(directory2);









        }
    }
}
