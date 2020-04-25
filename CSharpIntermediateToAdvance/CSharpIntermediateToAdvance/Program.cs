//using System;
using System.Collections.Generic;
//using System.Runtime.CompilerServices;
namespace CSharpIntermediateToAdvance
{
    class Program
    {

        static void Main(string[] args)
        {

            /*
             //Lecture 11
            //Fields
                it is Variable 
                Initialization:
	                List<Order> Orders;(for this we have to make constructor)
                and modified field:
                (List<Order> Orders new List<Order> []; (benificient as we need no constructor)
                Read only field: Effectiveness in obustuness of application
            */

        }
        public class Customer
        {

            //Fields
            public int ID;
            public string Name;
            public readonly List<Order> Orders = new List<Order>();

            public Customer(int id)
            {
                this.ID = id;
            }

            public Customer(int id, string name)
                : this(id)
            {
                this.Name = name;
            }
        }
        }
    }

