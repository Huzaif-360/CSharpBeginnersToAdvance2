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
             //Lecture 9
            Object Inilitiazers
            Initializer is simply a syntax or quickly initializing an object without the need to call one of its constructors.
            Well we do need that simply to avoid creating multiple constructors.
            */
            //Sytax
            System.Console.WriteLine("Running Classe of Customers");
            var customer = new Customer();
            var customer1 = new Customer(1);
           // var customer = new Customer() {  name = "huzaifa" };
        }
        public class Customer
        {
            public Customer()
                {
            }
            public Customer(int a)
            {
            }
            public Customer(string n)
            {
            }
            public Customer(int a, int b)
            {
            }


        }
    }
    }

