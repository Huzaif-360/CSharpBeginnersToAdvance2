using System;
using System.Collections.Generic;
//using System.Collections.Generic;
//using System.IO;
//using System.Collections.Generic;
//using System.Text;

namespace CSharpBeginners
{


    class Program
    {

        static void Main(string[] args)
        {
            //Section 10 
            //Debugging Application
            //Lecture 81

            var numbers = new List<int> { 1, 2 };
            var smallests = GetSmallests(numbers, 3);

            foreach (var number in numbers)
                Console.WriteLine(number);
        }
            public static List<int> GetSmallests(List<int> list, int count)
            {
                if (list == null)
                {
                    throw new ArgumentNullException("list");
                }
                if (list.Count < count || count <= 0)
                {
                    throw new ArgumentOutOfRangeException("Count", "count should be between 1 and count");
                }
            return list;

        //Errors

            }

    }
}




