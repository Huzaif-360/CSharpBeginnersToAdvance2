using System;

namespace CSharpYouTubeTutorials
{
    class Program
    {
        static void Main()
        {

            //UT Lecture 7
            /*Type Conversion
             * 1. Implicit (Simplest)
             * 2. Explicit (Cascading)
             * 3. Non-Compatible (uisng Convert.ToInt/ToString  function) 
            */

            //Type 1
            int i = 100;
            float f = i;
            Console.WriteLine("float to int = {0}", f);
            
            //Type 2
            float fl= 12.09f;
            int j = (int)fl;
            Console.WriteLine("int to float = {0}", j);

            //Using Convert.ToInt32 function

            float ff = 1234567890.123f;
            int k = (int)ff;
            Console.WriteLine("int to float = {0}", k);

            /*
            float ff = 123456789011223344.123f;
            int k = Convert.ToInt32(ff);
            Console.WriteLine("int to float = {0}", k);
            */

            //Type 3 
            string s = "100";
            int number = Convert.ToInt32(s);
            Console.WriteLine("Convert.ToInt32 = {0}", number);

            //Using Parse
            string @str = "76584";
            int number2 = int.Parse(@str);
            Console.WriteLine("Convert.ToInt32 = {0}", number2);

            //....................................
            //............. Warning......TryParse ...........
            string convertnumber = "76584";
            int result = 0;


            //int.TryParse(convertnumber, result);
            bool check = int.TryParse(convertnumber, out result);
           
            if (check)
            {
                Console.WriteLine("string to integer = {0}", result);
            }
            else
            {
                Console.WriteLine("Your string can not be converted into integer. Pleases reonsider it");
            }
             
            





        }

    }

}