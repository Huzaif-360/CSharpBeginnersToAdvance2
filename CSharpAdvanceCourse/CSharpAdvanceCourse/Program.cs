using System;

namespace CSharpAdvanceCourse
{


    //

    //Lecture 8 
    /* Delegates
     * An object that knows how to call a method  or group of methods.
     * it is a reference to a function
     * 
     * This is used  to make the design of an applcation ( i.e. Frameworks) extensible and flexible.
     * Used in designing frameworks
     */


        /*Type of Delegates
         * 1. Action ....... point to method that return VOID  
         * 2. Func   ......  Point to methods that return VALUE
         * 
        */
        //System.Action<>


    class program
    {
        //Interfaces can solve the problem of this multi method program using polymorphism
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filter = new Photofilter();
            // this delegate would help the user to enter what he wants to add or what feature he is wishing to add on the pics to edit it.
            //or the user can create any process itself 
            PhotoProcessor.PhotoFilterHandler filterHandler = filter.ApplyBrightness;
            //filterHandler += filter.ApplyContrast;

            //Adding a new feature
            filterHandler += RemoveRedEyeFiler;
                
                processor.Process("Photo.jpg", filter.ApplyBrightness);

        }
        static void RemoveRedEyeFiler(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");
        }

    }


    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);

        //Declaring a Delegate
        //Multifunction caller

        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = new Photo.Load(path);
            filterHandler(photo);
            
            photo.save();
        }
}

    //photofilter
    public class Photofilter
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply Brightness");
        }

        internal void ApplyBrightness(Photo.Load photo)
        {
            throw new NotImplementedException();
        }
        internal void ApplyContrast(Photo.Load photo)
        {
            throw new NotImplementedException();
        }
    }
    public class Photo
    {
        internal class Load
        {
            private string path;

            public Load(string path)
            {
                this.path = path;
            }

            internal void save()
            {
                throw new NotImplementedException();
            }
        }
    }
}
