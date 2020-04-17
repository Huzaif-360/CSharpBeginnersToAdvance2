using System;

namespace CSharpYouTubeTutorials
{
    class Program
    {
        static void Main()
        {

            //UT Lecture 5

            //.............. Without Ternary Operator .......................
            /* int number = 98;
             bool IsNumber;
             if (number == 98)
             {
                 IsNumber = true;
             }
             else
             {
                 IsNumber = false;
             }
             Console.WriteLine("Check on Number equals to 98 results in: - {0} ", IsNumber  );
             */

            //................ Using Ternary Operator ......................
            int number = 98;
            bool isNumber98 = number == 98 ? true : false;
            Console.WriteLine("Check condition answer = {0}", isNumber98);

                }
    }

}