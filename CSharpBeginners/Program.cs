using System;
using System.Collections.Generic;




namespace CSharpBeginners
{

    
    class Program
    {

        static void Main(string[] args)
        {
            ///Section 8
            //Working with text
            //Lecture 69
            var sentence = "very very very very very very very very very very very very very very very very much long sentence";
            var summary = SummerizingText(sentence);
            Console.WriteLine(summary);
        }
           
        //Method Creation
            static string SummerizingText(string text, int count =20)
            {
                //const int count = 20;

                if (text.Length < count)

                    return text;
                
                var words = text.Split(' ');
                var totalchar = 0;


                //List for strings 
                var summarywords = new List<string>();

                foreach (var word in words)
                {

                    totalchar = word.Length + 1;
                    summarywords.Add(word);
                    if (totalchar > count)
                        break;
                }
                //join
                var summary = String.Join(" ", summarywords + "...");
                return summary;

                
            }


        }

    }

