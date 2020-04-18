namespace Strings
{

    //Udemy 38;
    public class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Value type..(Independent).......
            var number = 1;
            // compy of number is sent to Increment Method 
            Increment(number);
            System.Console.WriteLine(number);

            //.............Reference type .... use class......(Dependent)................
            var person = new Person() { Age = 20 };
            MakeOld(person);
            System.Console.WriteLine(person.Age);
        }
        public static void Increment(int number) // this number is in different part of memory and in main number is at different location
        {
            number += 10;
        }
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
