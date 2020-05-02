using System;
using System.Collections.Generic;

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
        }
    }
}

