using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LINQ_Select_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Define Data Source
            Person p = new Person();
            var persons = p.Persons(p.persons);

            // Select query operator
            var query1 = from i in persons
                         select new
                         {
                             ID = i.PersonID,
                             Name = i.Name
                         };

            // same as above but method syntax
            var method1 = persons.Select(s => new { ID = s.PersonID, Name = s.Name });

            foreach (var i in query1)
            {
                Console.WriteLine(i.ID + ", " + i.Name);
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
