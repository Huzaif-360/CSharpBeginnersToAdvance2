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
            //Lecture 79
            var path = @"C:\Users\awais\Downloads\Video\image.jpg";
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var smallests = GetSmallests(numbers, 3);

            foreach (var number in smallests)
                Console.WriteLine(number);

        }

        //Function 1
        public static List<int> GetSmallests(List<int> list, int count)
        {
            var smallests = new List<int>();

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
            while (smallests.Count < count)
            {
                var min = GetSmallest(list);
                smallests.Add(min);
                list.Remove(min);
            }
            return smallests;
        }
            //Function 2
            public static int GetSmallest(List<int> list)
            {
                // Assume the first number is the smallest in the list.
                var min = list[0];
                for (var i = 1; i < list.Count; i++)
                {
                    if (list[i] < min)
                        min = list[i];
                }
                return min;
            }

        }

    }

}

