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
            //Lecture 74
            //Directory and DirectoryInfo

            //Directory 
            var path = @"C:\Users\Huzaifa\Downloads\Video";

            Directory.CreateDirectory(@"c:\folder");
            var files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                var content = File.ReadAllLines(path);
            }
                Console.WriteLine(files);
            }


        }

    }

