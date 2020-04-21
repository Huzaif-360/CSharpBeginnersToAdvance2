using System;
using System.Collections.Generic;
//using System.Collections.Generic;
//using System.Text;

namespace CSharpBeginners
{

    
    class Program
    {

        static void Main(string[] args)
        {
            ///Section 8
            //Working with text

            Console.Write("Enter a word: ");
            // Note the ToLower() here. This is used to count for both A and a. 
            var input = Console.ReadLine().ToLower();

            var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
            var vowelsCount = 0;
            foreach (var character in input)
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }

            Console.WriteLine(vowelsCount);





        }

    }

    }

