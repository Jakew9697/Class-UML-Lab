using System;
using System.Collections.Generic;

namespace Class_UML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> Persons = new List<Person>()
            {
                new Staff("Marcus", "3340 oak hollow dr se", "GC", 10000),

                new Staff("Julio", "1231 Burnberry dr sw", "Davenport", 60000),

                new Student("Jake", "7556 Fase st se", 4, 26000, "Computer Science"),

                new Student("Tom", "555 DogWood", 2, 13000, "Architecture"),

                new Student("Bob", "4349 ada dr se ", 1, 11000, "Accounting"),
            };

            foreach (Person p in Persons)
            {
                Console.WriteLine(p);
            }
        }
    }
}
