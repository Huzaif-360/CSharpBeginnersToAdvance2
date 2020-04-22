using System;
//using System.Collections.Generic;
using System.IO;
//using System.Collections.Generic;
//using System.Text;

namespace CSharpBeginners
{

    
    class Program
    {

        static void Main(string[] args)
        {
            //Section 9 
            //

           // var path = @"C:\Users\Downloads\Video";

            var path = @"C:\Users\Downloads\Video\image.jpg";

            Directory.CreateDirectory(@"c:\folder");
            var files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);
        }

        }

}

