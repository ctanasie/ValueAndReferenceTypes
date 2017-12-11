using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTypeValTypeParams
{
    class Person
    {
        public string personName;
        public int personAge;

        // Constructors.
        public Person(string name, int age)
        {
            personName = name;
            personAge = age;
        }

        public Person()
        {

        }

        public void Display()
        {
            Console.WriteLine($"Name: {personName}, Age: {personAge}");
        }
    }
}
