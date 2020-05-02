using System;
using System.Collections.Generic;

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

            /*If we don't pass arguments:
             *  LE ........... ()=>...
             *  
             * ...............................................
             * if we have 1 ar..gument:
             * x=> .................
             * 
             * * .................................................
             * if we have many args:
             * (x,y,z)=>.............
             */

            /*const int factor = 5;
            Func<int, int> multiplier = n => n * factor;
            Console.WriteLine(multiplier(10));
            Func<int, int> square = num => num * num;
            Console.WriteLine(square(5));
            */
            var books = new BookRepo().GetBooks();



            //books.FindAll. this is Predicate Method.

            //Normal Call
            var cheapbook = books.FindAll(book => book.Price>10);

            foreach(var book in cheapbook)
            {
                Console.WriteLine(book.title);

            }
            
            
            
            
            

        }
        /*Predicate Method
        static bool IsCheaper(Book book)
        {
            return book.Price < 10;
        }*/

        public class BookRepo
        {
            public List<Book> GetBooks()
            {
                return new List<Book>
                {
                    new Book{ title = "Title 1", Price =7},
                    new Book{ title = "Title 2", Price =11},
                    new Book{ title = "Title 3", Price =71}
                };
            }
        }
    }
}

