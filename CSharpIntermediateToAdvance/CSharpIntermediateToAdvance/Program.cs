//using System;
using System.Collections.Generic;
//using System.Runtime.CompilerServices;
namespace CSharpIntermediateToAdvance
{
    class Program
    {
        /* public void Myintroduction(string name)
         {
             Console.WriteLine("My name is" );
         }*/
        static void Main(string[] args)
        {

            /*
             * C# Intermediate Course
             * 
             * //Lecture 8
            Construstor
            Constructor overloading:
                            (same name as class but with different paarameter).
    
                1. Create public class
                    crete a seperate file customer.cs
                2. different parameter construstors
                3. construstor call wit attribute
                4. public List<order> Orders;
             */

        }
        public class Customer
        {
            public string Name;
            public int Id;
            public List<Order> Orders;

            public Customer()
            {
                Orders = new List<Order>();
            }

            public Customer(int id)
                : this()
            {
                this.Id = id;
            }

            public Customer(int id, string name)
                : this(id)
            {
                this.Name = name;
            }

        }
    }

    internal class Order
    {
    }
}
