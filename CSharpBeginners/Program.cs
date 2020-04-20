using System;
namespace CSharpBeginners
{

    //Udemy 42;
    class Program
    {
        public enum season
        {
            Summer,
            Spring,
            Winter,
            Autumn
        }
        static void Main(string[] args)
        {
            var s1 = season.Winter;
            switch(s1)
            {
                case season.Spring:
                    Console.WriteLine("Flowers");
                    break;
                case season.Winter:
                    Console.WriteLine("cool weather");
                    break;
                default:
                    Console.WriteLine("nothing");
                    break;
            }

         }

    }
}
