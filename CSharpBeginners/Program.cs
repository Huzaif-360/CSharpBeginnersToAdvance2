using System;

namespace Type_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Implicit Conversion
            byte b = 1;
            int i = b;
            Console.WriteLine(i);
            //.................................................................
            
            // Explicit Converesion
            int c = 256;
            byte d = (byte)c;
            Console.WriteLine(d);
            //.................................................................

            // Non- Compatible conversitons.
            var s = "1234";
            var j = Convert.ToInt32(s);
            Console.WriteLine(j); */

            //.................................................................
            // Exception Handling
            /* var number = "1234";
             var bbb= Convert.ToByte(number);
             Console.WriteLine(bbb);
             

            //.................................................................
            //Try catch
            try
            {
                var number = "1234";
                var bbb = Convert.ToByte(number);
                Console.WriteLine(bbb);
            }
            catch (Exception)
            {
                Console.WriteLine("This conversion can not be done due to less space in byte!!!");

            }*/

            //.................................................................

            //....................... OPERATORS ..............................
            var z = 1;
            var y = 2;
            Console.WriteLine("a+b = " + z + y);
            Console.WriteLine("a/b = " + z / y);
            Console.WriteLine("a/b = " + (float)z / (float)y);
            Console.WriteLine("a>b = " + (z > y));
            Console.WriteLine("a==b = " + (z == y));
            Console.WriteLine("a<b = " + (z < y));




        }
    }
}
