using System;

namespace CSharpAdvanceCourse
{



    /*Constrains;
     *  where T: IComparable
     *  where T: Product
     *  where T: struct
     *  where T: class
     *  where T : new()
     */
    //We can make this class generic 
    // public class utilities<T> where T: IComparable
    public class utilities
    {

        //correct
        public int Mac( int a , int b)
        {
            return a > b ? a : b;
        }


        //Error, because comlier are treated as objects so error. 
        //public T Max<T>(T a, T b)
        //{
        //    return a > b ? a : b;
        //}


            //Right way............Generic Method in non generic class
        public T Max<T>(T a, T b) where T: IComparable
        {
            return a.CompareTo(b) >0? a : b;
        }

    }





    //.............................
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


            var dictionary = new GenericDictionary<string, Book>
                dictionary.Add("1234", new Book());
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




    public class GenericDictionary<Tkey, TValue>
        {
        public void Add(Tkey key, TValue value)
        {

        }
        }

       

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

