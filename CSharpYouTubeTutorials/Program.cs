using System;

namespace CSharpYouTubeTutorials
{
    class Program
    {
        static void Main()
        {

            //UT Lecture 8
            //............Arrays.............
            int[] Arrays = new int[3];
            Arrays[0] = 1;
            Arrays[1] = 2;
            Arrays[2] = 3;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Arrays[i]);
            }
            //....................... insertion method 2...........
            var A2 = new string[4] { "Ali", "Usama", "Shahid", "Huzaifa" };
            for (int j=0; j<A2.Length; j++)
            {
                Console.WriteLine("Element in Array at index {0} is {1}",j, A2[j]);
            }










        }

    }

}