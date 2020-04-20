using System;
//using System.Collections.Generic;


namespace CSharpBeginners
{

    
    class Program
    {
        
        static void Main(string[] args)
        {
            ///Section 8
            //Working with text
            //Lecture 64


            //String to int
            var num = "123";
            var str = int.Parse(num);
            Console.WriteLine(str);


            //int to string
            var n1 = 123;
            var n2 = Convert.ToInt32(n1);
            Console.WriteLine(n2);

            //Trim Name   ...............Trim Extra Spaces.........
            var myfullname = "Muhammad Huzaifa Shah     ";
            myfullname = myfullname.Trim();
            Console.WriteLine("My Trip Name = {0}", myfullname);

            //...............
            var index = myfullname.IndexOf(" ");





        }

    }
}
