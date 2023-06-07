using Classes;
using System;

namespace Classes
{
  public class Person
    {
        public string? Name;
        public void Introduce(string to)
        {
            Console.WriteLine("hi {0}, i am {1}", to, Name);
        }
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
            //static member can be accessible only by the class,not by object
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        //var person = new Person();
        //person.Name = "john";
        //person.Introduce("sam");
        var pe = Person.Parse("lisa");
        pe.Introduce("sam");
    }
}