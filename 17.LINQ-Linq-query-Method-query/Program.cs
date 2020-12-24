using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.LINQ_Linq_query_Method_query
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Datasource
            var persons = new List<Person>() {
                new Person{ name="John", lastName="Doe"},
                new Person{ name="Jason", lastName="Davidson"}
            };

            // 2. Linq query
            var query1 = from p in persons
                         where p.name == "John"
                         select new
                         {
                             Name = p.name,
                             LastName = p.lastName
                         };
            // 2.1 Meethod query
            var query2 = persons.Where(y => y.name == "John").Select(x => new
            {
                Name = x.name,
                LastName = x.lastName
            });


            // 3. Execute query
            foreach (var i in query1)
            {
                Console.WriteLine(i.Name + " " + i.LastName);
            }

            Console.WriteLine();

            foreach (var i in query2)
            {
                Console.WriteLine(i.Name + " " + i.LastName);
            }

            Console.ReadKey();
        }

        class Person
        {
            public string name { get; set; }
            public string lastName { get; set; }
        }
    }
}
