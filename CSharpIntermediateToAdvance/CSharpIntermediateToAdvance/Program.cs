//using System;
//using System;
//using System.Collections.Generic;
//using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;

namespace CSharpIntermediateToAdvance
{
    class Program
    {

        static void Main(string[] args)
        {

            /*
        //Lecture 14
        Indexers:

        #using indexer
        An indexer is a way to access elements in a class that represents a list of values.
        
            
            var cookie = new HttpCookie //to see the name of user.
        var name = cookie["name"]   (this is indexer)
        var name = cookie.Getitem("name");  (without inderer we have to write a Getname method)

        public string this[string key]
        {
        get {----}
        set{----}
        }

            */

        }
        public class Person
        {
             
        private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();
            public DateTime Expiry { get; set; }

            public string this[string key]
            {
                get => _dictionary[key];
                set
                {
                    if (key != null) _dictionary[key] = value;
                }
            }
        }

    }
}

