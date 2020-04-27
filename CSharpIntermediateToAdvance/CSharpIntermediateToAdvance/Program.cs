using System;
//using System.Runtime.CompilerServices;
//using System.Collections.Generic;

namespace CSharpIntermediateToAdvance
{
    class Program
    {

        static void Main(string[] args)
        {
            /*  Section 4
             *  Inheritance - Second Pillar of OOP
             *  Lecture 22
             *  Access Modifiers
             *  
             *  
             *  Black Box: Limited Visibility.
                Implementation of classes:
                we want to make classe hide form others/ user dor more appealing lookings.

                C# Access Modifiers:
                    1. Public
                    2. Private        
                    3. Protected
                    4. internal
                    5. protected inhernal.
    
            1. PUBLIC:
                Accessible from everywhere
	                CORRECET: Customer.CalculateRating.

            2. PRIVATE: 
	            Accessible only from the class
	                ERROR: Customer.CalculateRating.
            3. PROTECTED:
	            Accessible only from the class and its derived classes.
	                CORRECET: Customer.CalculateRating. 
		                (This Breaks encapsulation)

         ..............................Prefer to use PRIVATE insted of PROTECTED........................................

            4. INTERNAL:  (Refferer with classes not with members)
	            Accessible only from the same assembly.

            5. PROTECTED INTERNAL: (Object)
                Accessible Only from the same assemble or any derived classes.
                        (This is hardly used in coding)
            */
        }
        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public void Promote()
            {
                var calculator = new RateCalculator();
                var rating = calculator.Calculate(this);
                Console.WriteLine("Logic Promotion");
            }
            internal class RateCalculator
            {
                public int Calculate(Customer customer)
                {
                    return 0;
                }
            }
        }

        }
}



