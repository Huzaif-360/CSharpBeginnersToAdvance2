namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Udemy 37.
            var a = 10;
            var b = a;
            b++;
            System.Console.WriteLine("a: {0} b: {1}", a,b);
            //................................................
            int[] Array1 = new int[] { 1, 2, 3 };
            int[] Array2 = Array1;
            Array2[0] = 0;
            System.Console.WriteLine("Array1[0]= {0} \n Array2[0]= {1}", Array1[0], Array2[0]);
         }
    }
}
