using System;

namespace CSharpIntermediateToAdvance
{
    partial class Program
    {

        static void Main(string[] args)
        {
            //Intermediate Section 4 Exercise
            var stack = new Stack();
            
            //Push Status
            stack.Push(19);
            stack.Push(2);
            


            //Pop Status
            Console.WriteLine("Count: {0}", stack.Size());
            Console.WriteLine(stack.Pop());
            Console.WriteLine("Count: {0}", stack.Size());
            Console.WriteLine(stack.Pop());
            Console.WriteLine("Count: {0}", stack.Size());
        }
    }
}



