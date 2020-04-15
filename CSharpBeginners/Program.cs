using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Huzaifa";
            var lastName = "Shah";
            //.................... Method 1 ............................................
            var fullName1 = name + " " + lastName;                                  
            Console.WriteLine(fullName1);

            //.................... Method 2 ............................................
            var fullName2 = string.Format("{0} {1}  ", name, lastName);           
            Console.WriteLine(fullName2);


        }
    }
}
