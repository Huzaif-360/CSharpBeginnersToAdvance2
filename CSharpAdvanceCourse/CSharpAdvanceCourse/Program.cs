using System;

namespace CSharpAdvanceCourse
{


    //

    /*Lecture 8 
     * Lambda Expresion
     * 
     * An Anonymous method
     *
     * No access Modifier
     * No name 
     * No return statement
     * 
     * 
     * WHY WE USE IT?
     *      To make code short
     *      to make code easy
     *      for our convience
    */


    class program
    {
        static void Main(string[] args)
        {

            //Lambda Expression 
            //agrs=> expression

            //Square
            //num => num * num;


            //Console.WriteLine(num(5));


            Func<int, int> square = num => num * num;
            Console.WriteLine(square(5));
                    
            //Console.WriteLine(value: Square(5));
            //Console.WriteLine(square(5));
        }
        //public int square(int num)
        //{
        //    return num * num;
        //}
    }
}
