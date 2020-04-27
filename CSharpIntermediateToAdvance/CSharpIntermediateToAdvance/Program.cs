//using System;
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
		 *  Lecture 25
		 *  Boxing and Unboxing

		Value and Reference Types
		1. Value Types:
			Stored on the stack
			Have Shorter Life Time
		e.g. All Primitive Data Types
			Bytes, int, float, char, bool etc.
			They are struct type.


		2. Refernece Types:
			Stored in the heap 
		e.g. All Non- Primitive Data Types
			Object, Array, String, DbMigrator etc...

		OBJECT Class is the base of all classes in .NET Framework
			Circle Circle = new Circle();
			Shape shape= cirlce;
			object shape= circle; // this means object is working as a var.
			*/

		//BOXING:
			//	Thr process of converting a value type instance to an object refernece.
					int number=10;   // number is a value type (This is on the stack now)
					object obj= number; // Now this value type has become a refernce type this is boxing. (This is on the heap now)
										//OR
			object obj1 = 10; //(This is on the heap now)

			//UNBOXING:
			//	Oposite of BOXING, 
			object obj2= 10;
					int number1 = (int)obj;
					//(This is on the stack now)
				
		}
	}
}


