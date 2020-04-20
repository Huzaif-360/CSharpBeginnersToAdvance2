using System;
namespace CSharpBeginners
{

    //Udemy 42;
    class Program
    {
        
        static void Main(string[] args)
        {
            //Section 6 Arrays and Lists
            //Lecture 

            //Length
            var Array1 = new int[3] { 1, 2, 3 };
            Console.WriteLine("Length = "+ Array1.Length  );

            //IndexOf
            var index = Array.IndexOf(Array1, 3);
            Console.WriteLine(index);

            //Clear
            Array.Clear(Array1, 0, 2);
            //Check after Clear
            foreach (var n in Array1)
            Console.WriteLine(n);

            //Sorting 
            Array.Sort(Array1);
            //Check after Sorting
            foreach (var n in Array1)
            {
                Console.WriteLine(n);
            }


            //Reverse of Array
            Array.Reverse(Array1);
            //Check after Reversing
            foreach (var n in Array1)
            {
                Console.WriteLine(n);
            }
        }
  
    }
}
