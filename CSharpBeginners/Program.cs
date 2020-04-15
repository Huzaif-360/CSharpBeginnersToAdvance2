using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[3];
            number[0] = 1;
            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]);
            Console.WriteLine(number[2]);
            Console.WriteLine("...............................");
            //.................................................................
            var check = new bool[3];
            check[0] = true;
            Console.WriteLine(check[0]);
            Console.WriteLine(check[1]);
            Console.WriteLine(check[2]);
            Console.WriteLine("...............................");
            //.................................................................
            var names = new string[3] { "Huzaifa", "Nouman", "Saad" };
            //names[0] = "Huzaifa";
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine("...............................");
        }
    }
}
