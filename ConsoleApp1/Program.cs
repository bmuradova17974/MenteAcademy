using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Salam", "ha", 23);

            person.Name = "bilqeyis";
            person.Surname = "muradova";
            person.Age = 23;
            Console.WriteLine(person.Age);

            person.FullName();

            /* Person person = new Person()()
             {  Name = "",
                surname = "",
                age = 23

             
             */

        }
    }
}
