//using System.Collections.Generic;
//using System.Threading;

using System;
using System.Linq;

namespace CSharpAdvanceCourse
{
    // cant do this because string is sealed class 
    //public class bstring: String
    // to get it done we do extension methods


    public static class StringExtension
    {
        public static string Shorten(this string str, int numberofwords)
        {
            if (numberofwords < 0)
                throw new ArgumentOutOfRangeException("This is an invalid entry");
            if (numberofwords == 0)
                return " ";
            var words = str.Split(' ');
            if (words.Length <= numberofwords)
                return str;
            return string.Join(" ", words.Take(numberofwords));

        }
    }

}
