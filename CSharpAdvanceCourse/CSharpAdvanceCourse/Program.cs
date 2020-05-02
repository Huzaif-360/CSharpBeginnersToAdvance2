using System;

namespace CSharpAdvanceCourse
{

    //Lecture 8 
    /* Delegates
     * An object that knows how to call a method  or group of methods.
     * it is a reference to a function
     * 
     * This is used  to make the design of an applcation ( i.e. Frameworks) extensible and flexible.
     * Used in designing frameworks
     */




        //This code is ok but not good for designing a mega framework. because even to deploy a new change we have to recomile the entir program and rerun it. this is bad this
        //BCOZ according to role, our new change must not change other things.

    class program
    {


    }


    public class PhotoProcessor
    {
        public void Process(string path)
        {
            var photo = new Photo.Load(path);
            var filter = new Photofilter();
            filter.ApplyBrightness(photo);
           // filter.ApplyContrast(photo);
            //filter.Resize(photo);
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
    }
    public class Photo
    {

    }
}
