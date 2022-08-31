using System;
namespace AbstractAndInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birthdate = Console.ReadLine();

            Citizen person = new Citizen(name, age,id,birthdate);

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Id);
            Console.WriteLine(person.Birthdate);

        }
    }
}