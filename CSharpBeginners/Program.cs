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
            //Lecture 73
            //file    (for small small files)

            var path = @"C:\myfile\file.jgp";
            File.Copy(@"C:\temp\myfile.jgp", @"D:\temp\myfile.jgp");
            File.Delete(path);
            //fileinfo (for lare files)
            Console.WriteLine();
            if (File.Exists(path))
            {

            }



        }

    }

    }

