using System;
using System.Collections.Generic;
//using System.Collections.Generic;
using System.IO;
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
            //Lecture 80

            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var smallests = GetSmallests(numbers, 3);
            foreach (var number in numbers)
                Console.WriteLine(number);

        }

        //Function 1
        public static List<int> GetSmallests(List<int> list, int count)
        {
            var smallests = new List<int>();
            
            //creating buffers
            var buffer = new List<int>(list);

            //while for checking
            while (smallests.Count < count)
            {
                var min = GetSmallest(list);
                var min = GetSmallest(buffer);
                smallests.Add(min);
                //list.Remove(min);
                buffer.Remove(min);
            }
        }

    }

}

