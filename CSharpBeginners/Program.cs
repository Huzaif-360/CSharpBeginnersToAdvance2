using System;

namespace Classes
{
    public class Person
    {
        public string fName;
        public string lName;
        public void Introduce()
        {
            Console.WriteLine("my name is " + fName + " " + lName);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();  //var= Person
            person.fName = "Huzaifa";
            person.lName = "Shah";
            person.Introduce();
        }
    }
}
