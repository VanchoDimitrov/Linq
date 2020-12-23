using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.LINQ_Element_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Define Data Source
            Person p = new Person();
            List<Person> persons = p.Persons(p.persons);
            List<int> numbers = new List<int>() { 111, 1, 2, 3, 4 };

            // Linq query

            // same as above but method syntax
            //Console.WriteLine(numbers.ElementAt(1));
            //Console.WriteLine(numbers.ElementAtOrDefault(1));
            //Console.WriteLine(numbers.First());
            //Console.WriteLine(numbers.FirstOrDefault());
            //Console.WriteLine(numbers.Last());
            //Console.WriteLine(numbers.LastOrDefault());
            //Console.WriteLine(numbers.Single(i => i < 1));
            Console.WriteLine(numbers.ElementAt(1));

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
