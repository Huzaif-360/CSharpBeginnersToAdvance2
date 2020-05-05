using System;
using System.Collections.Generic;
using System.Threading;

namespace CSharpAdvanceCourse
{

    class program
    {
        static void Main(string[] args)
        {

            /*Lecture 9 
             * Events
             * 
             * WHAT IS EVENT:
             *          A mechanism for communication betweeen Objects
             *          
             * WHY WE NEED IT:
             *          Used in building Loosly Coupled Applications
             *          Helps in extindind code
             *          
             * Tightly Coupled Classes are needed to be recompiled at every signle modification
             * Loose Coupling reduces:
             *          Compilation time
             *          
             *          
             *      Event: Function that connect VideoEncode and MessageService is Event.
             *      VideoService : this is parent and it does not know anything about existance of MessageService or MailService. 
             *      It only know about only 1 method.
             *      BUT:
             *      how that method knows what to call??
             *            This is done by using delegate.
             *      
            */

            var video = new Video() { title = "Video 1" };
            var videoEncoder = new videoEncoder();//publisher
            var mailservice = new MailService();// Subscriber
            videoEncoder.VideoEncoded += mailservice.OnVideoEncoded;
            videoEncoder.Encode(vidoe);



        }

    }

    public class MialService
    {
        public void OnVideoEncoded(object soure, EventArgs e)
        {
            Console.WriteLine("Mail Server sendig and email");
        }
    }

    public class videoEncoder
    {
        //1. Define a delegate
        //2. Define an event based on that delegate
        //3. Raise the event





            //...................1..................
        //If name of the function is VideoEncoder then the name of delegate shoudl be added and EvenHandler.
        // and total name of the delegate function would become as:
        //VideoEncoderEventHandler
        public delegate void VideoEncoderEvenHandler(object source, EventArgs arg);


        //........................ 2..................
        public event VideoEncoderEvenHandler VideoEncoded;


        //.................3........................



        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(1000);
            ONVideoEncoder();
            }


        //Event publisher method should be :
        //1. Protected
        //2. Virtual
        //3. Void
        // name of the method should be On + name of the event
        // mean total = ONVVideoEncoder
        protected virtual void ONVideoEncoder()
        {
            if (VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
        }
            }

}

