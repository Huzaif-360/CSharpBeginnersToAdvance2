using System;

namespace CSharpAdvanceCourse
{
    class Program
    {
        public static string Items { get; private set; }
        public static string Title { get; private set; }

        static void Main(string[] args)
        {
            //Section 2
            // Lecture 7
            //Generics


            var Book = new Book { Items - "1111", Title - "Hello to Computing" };



            //Generic increase the code resubility.
            // it helps us get rid of all repeatitive lists calls 
            var number = new GenericList<int>();
            number.Add(10);
            var books = new GenericList<>();
            books.Add(new Book());

            //System.Collections.Generic.

        }
    }

    public class BookList
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }
        public Book this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }

    //Not useful
    //public class ObjectList
    //{
    //    public void Add(object list)
    //    {

    //    }
    //    public object this[int index]
    //    {
    //        get
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }




public class GenericList<T>
{
    public void Add( T value)
        {

        }
    public T this[int index]
    {
        get
        {
            throw new NotImplementedException();
        }
    }
}
}

