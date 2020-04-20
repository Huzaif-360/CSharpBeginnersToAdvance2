using System;
//using System.Collections.Generic;


namespace CSharpBeginners
{

    
    class Program
    {
        
        static void Main(string[] args)
        {
            //Section 6 Arrays and Lists
            //Lecture 54
            //Lists
            Console.WriteLine();
            var List1 = (new int[5] { 1, 2, 3, 4, 5 }) ;
            foreach(var n in List1)
            Console.WriteLine(n);

            //IndexOf
            Console.WriteLine(List1.IndexOf(2));

            //Add Range
            List1.Add(1);
            List1.AddRange(new int[2] { 4, 5, 6 });


        }
  
    }
}
