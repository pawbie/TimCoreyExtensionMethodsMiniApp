using System;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonModel();

            person.FirstName = "Please provide first name: ".RequestString();
            person.LastName = "Please provide last name: ".RequestString();
            person.Age = "Please provide age: ".RequestInteger(0, 120);

            Console.ReadLine();
        }
    }
}
