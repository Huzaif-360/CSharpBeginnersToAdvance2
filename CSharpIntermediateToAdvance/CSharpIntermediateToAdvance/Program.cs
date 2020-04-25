//using System;
//using System.Collections.Generic;
//using System.Runtime.CompilerServices;
namespace CSharpIntermediateToAdvance
{
    class Program
    {
        
        static void Main(string[] args)
        {

            /*
             /Lecture 10
            Methods
            1. signature of methods

            2. method overloading
            (same name with different parameters)
            Improvement: yes
            (var result = calculator.Add[1,2,3,4]; (pram modifier)

            3. modifiers
                parama modifier (useful)
                ref modifier (used in C# .net)
               (change value type into refernece type)
                out modifier(used in .Net)
            */
            
            System.Console.WriteLine("Running Classe of Customers");
            var customer = new Customer();
            var customer1 = new Customer(1);
            int N= customer1.Addnum();
            System.Console.WriteLine(N);
            // var customer = new Customer() {  name = "huzaifa" };
        }
        public class Customer
        {
            public int num = 0;
            public Customer()
                {
            }
            public Customer(int a)
            {
                 num = a;
            }
            public Customer(string n)
            {
            }

            public Customer(int a, int b)
            {
            }
            public int Addnum()
            {
                num += 2;
                System.Console.WriteLine("Number= {0}", num);
            }


        }
    }
    }

