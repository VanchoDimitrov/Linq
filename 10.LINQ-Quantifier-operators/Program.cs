using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.LINQ_Quantifier_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Define Data Source
            Person p = new Person();
            List<Person> persons = p.Persons(p.persons);

            // Linq query
            // Contains
            Person p1 = new Person() { PersonID = 8, Name = "John" };
            persons.Add(p1);

            bool query1 = persons.Contains(p1);

            // 3. Execution
            if (query1)//if the record is contained in persons collection
                Console.WriteLine(query1);

            Console.WriteLine();

            foreach (var i in persons)
            {
                Console.WriteLine(i.PersonID + ", " + i.Name);
            }

            Console.ReadKey();
        }

        class Person
        {
            public int PersonID { get; set; }
            public string Name { get; set; }
            public string yearOfEntry { get; set; }

            public List<Person> persons { get; set; } = new List<Person>();

            public List<Person> Persons(List<Person> persons)
            {
                persons = new List<Person>()
                {
                    new Person { PersonID = 1, Name = "John", yearOfEntry = "2020"},
                    new Person { PersonID=2, Name = "Jacky", yearOfEntry = "2019" },
                    new Person { PersonID=3, Name = "Monika", yearOfEntry = "2020" },
                    new Person { PersonID=3, Name = "Jesica", yearOfEntry = "2019" },
                    new Person { PersonID=3, Name = "Jackline", yearOfEntry = "2020" },
                    new Person { PersonID=3, Name = "Alexander", yearOfEntry = "2020" },
                    new Person { PersonID=3, Name = "Britney", yearOfEntry = "2019" }
                };

                return persons;
            }
        }
    }
}
