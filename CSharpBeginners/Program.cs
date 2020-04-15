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
            Console.WriteLine(d);*/
            //.................................................................

            // Non- Compatible conversitons.
            var s = "1234";
            var j = Convert.ToInt32(s);
            Console.WriteLine(j);
            //.................................................................

            
        }
    }
}
