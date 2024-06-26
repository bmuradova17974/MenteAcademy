using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
  
    internal class Person
    {
        public string Name;
        public string Surname;
        public int Age;

        public Person(string name, string surname, int age)
        {
            Name=name;
            Surname=surname;
            Age=age;
        }

        public void FullName()
        {
            Console.WriteLine($"{Name} {Surname} {Age}");
        }


    }



}
